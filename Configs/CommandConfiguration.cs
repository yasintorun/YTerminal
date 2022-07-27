using YTerminal.Commands;
using YTerminal.Core.Dtos;
using YTerminal.Core.Constants;
using YTerminal.Core.Abstractions;
using YTerminal.Core.Exceptions;

namespace YTerminal.Configs
{
    internal static class CommandConfiguration
    {
        private static readonly List<CommandDto> commands = new()
        {
            new(CommandNames.Help, typeof(HelpCommand)),
            new(CommandNames.Mkdir, typeof(MkdirCommand)),
            new(CommandNames.Resize, typeof(int)) //ICommand olmadığı için resize komutunu çağırdığımızda hata verecektir.
        };

        public static ICommand GetCommand(string commandName)
        {
            var command = commands.FirstOrDefault(c => c.Name == commandName);
            if (command == null)
                throw new CommandNotFoundException(); //Komut adı geçersiz

            if (command.Command.GetInterface(nameof(ICommand)) != typeof(ICommand))
                throw new CommandNotImplementedException(); // Komut implemente edilmemiş.

            ICommand? commandInstance = Activator.CreateInstance(command.Command) as ICommand;
            
            if(commandInstance == null)
                throw new CommandDeprecatedException(); //Komut mevcut ama kullanılmıyor.

            return commandInstance;
        }
    }
}
