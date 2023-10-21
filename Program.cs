using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");

Smartphone nokia = new Nokia("9999999999", "Modelo 1", "111111111", 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine();

Console.WriteLine("Smartphone IPhone");

Smartphone iphone = new Iphone("44444444", "Modelo 2", "5555555", 120);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");