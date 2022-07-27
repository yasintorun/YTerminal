namespace YTerminal.Core.Exceptions;
internal class CommandNotFoundException : Exception
{
    public CommandNotFoundException() : base("Geçersiz komut girdiniz. Şu komutu deneyin: help") { }
}
