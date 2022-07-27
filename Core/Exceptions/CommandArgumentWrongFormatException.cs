namespace YTerminal.Core.Exceptions;
internal class CommandArgumentWrongFormatException : Exception
{
    public CommandArgumentWrongFormatException() : base("Arguman formatı doğru biçimde değil. Argumanları -- eki ile vermeniz gerekmektedir. Örnek kullanım ve detaylı bilgi için 'help' komutunu kullanınız.") { }
}
