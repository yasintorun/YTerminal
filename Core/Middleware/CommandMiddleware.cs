
using YTerminal.Configs;
using YTerminal.Core.Abstractions;
using YTerminal.Core.Dtos;
using YTerminal.Core.Exceptions;

namespace YTerminal.Core.Middleware
{
    internal static class CommandMiddleware
    {
        public static void Execute(string commandLine)
        {
            var commandName = commandLine.Split(' ')[0];

            ICommand command = CommandConfiguration.GetCommand(commandName);
            try
            {
                var arguments = commandLine.Split(' ');

                var argumentList = new List<CommandArgumentDto>();

                for(int i = 1; i < arguments.Length; i++)
                {
                    var arg = arguments[i];
                    if (!arg.StartsWith("--")) continue;
                    
                    //TODO: Convert Regex
                    if(arg.Length < 3 || i >= arguments.Length - 1)
                    {
                        throw new CommandArgumentWrongFormatException();      
                    }

                    argumentList.Add(new(arg.Substring(2), arguments[i + 1]));
                    i++; //Bir sonraki değere bakmaya gerek yok. Çünkü yukarıda value olarak kullandık. Yani key olamaz.
                }

                command.Execute(argumentList);
            } 
            catch { throw; }
        }
    }
}
