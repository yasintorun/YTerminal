using System.Collections.Generic;
using YTerminal.Core.Dtos;

namespace YTerminal.Core.Abstractions
{
    internal interface ICommand
    {
        int Execute(IEnumerable<CommandArgumentDto> arguments);
    }
}
