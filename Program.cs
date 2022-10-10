using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

System.Console.WriteLine("Smartphone Iphone");
Iphone iphone = new Iphone("123456", "Modelo 1", "111111111", 64);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");

System.Console.WriteLine("Smartphone Nokia");
Nokia nokia = new Nokia("4987", "Modelo 2", "222222222", 64);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whatsapp");
