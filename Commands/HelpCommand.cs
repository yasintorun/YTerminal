using YTerminal.Core.Abstractions;
using YTerminal.Core.Dtos;

namespace YTerminal.Commands;
internal class HelpCommand : ICommand
{
    public int Execute(IEnumerable<CommandArgumentDto> arguments)
    {
        Console.WriteLine($"" +
            $"Selam \n" +
            $"YTerminal basit araçlar sunmaktadır. Bunlar; \n" +
            $"mkdir: Klasör oluşturma komutudur. örn: mkdir yeni-klasör \n" +
            $"resize: Klasördeki tüm resimleri belirtilen boyuta göre yeniden boyutlandırır. \n" +
            $"\tEk parametreler şunlardır; \n" +
            $"\t\t--w: yeni genişlik (width) değeridir. \n" +
            $"\t\t--h: yeni yükseklik (height) değeridir. \n" +
            $"help: Yardım menusu\n" +
            $"\nYTerminal - Created by Yasin T.\n");
            
        return 1;
    }
}
