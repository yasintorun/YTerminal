namespace YTerminal.Core.Exceptions;
internal class CommandNotImplementedException : Exception
{
    public CommandNotImplementedException() : base("Bu komut henüz kullanılamaz") { }
}
