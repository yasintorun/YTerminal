# YTerminal
 Custom file system terminal with C#

C# .Net 6 ile gleiştirilmiştir.

Mediator design pattern sistemini örnek alınarak geliştirilmiştir.

SOLID kurallarına uymaya çalıştım.

Komut ekleme işlemi yapmak için komut adını ve komut için ICommand interface den türeyen bir sınıf oluşturup bu sınıfı projeye tanıtmamız yeterli olmaktadır.

Komut Adları: [CommandNames](https://github.com/yasintorun/YTerminal/blob/main/Core/Constants/CommandNames.cs)

Komutlar: [Commands](https://github.com/yasintorun/YTerminal/tree/main/Commands)

Komutun tanıtıldığı kısım: [CommandConfiguration](https://github.com/yasintorun/YTerminal/blob/main/Configs/CommandConfiguration.cs)

### Screenshots

![Terminal](https://github.com/yasintorun/YTerminal/blob/main/screenshots/YTerminal-0.PNG)
