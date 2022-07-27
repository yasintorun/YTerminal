using YTerminal.Core.Middleware;

while (true)
{
    Console.Write("YTerminal$ ");
    var command = Console.ReadLine();
    if (string.IsNullOrEmpty(command))
    {
        Console.WriteLine("Geçersiz giriş. YTerminali öğrenmek için 'help' komutunu kullanabilirsiniz.");
    }
    else
    {
        try
        {
            CommandMiddleware.Execute(command);
        } catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}