using YTerminal.Core.Abstractions;
using YTerminal.Core.Dtos;

namespace YTerminal.Commands;
internal class MkdirCommand : ICommand
{
    public int Execute(IEnumerable<CommandArgumentDto> argument)
    {
        Console.WriteLine($"Mkdir command run with argument: {argument}");
            
        //TODO: Created new folder.

        return 1;
    }
}
