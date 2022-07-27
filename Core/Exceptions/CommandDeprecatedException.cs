namespace YTerminal.Core.Exceptions;
internal class CommandDeprecatedException : Exception
{
    public CommandDeprecatedException() : base("Bu komut artık kullanılmıyor") { }
}
