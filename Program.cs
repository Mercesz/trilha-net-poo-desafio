using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
// Instanciando um objeto da classe Nokia
Nokia nokia = new Nokia("11999999999", "Modelo Nokia", "123456789", 64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
// Instanciando um objeto da classe Iphone
Iphone iphone = new Iphone("11999999999", "Modelo Iphone", "987654321", 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");

// TODO: Realizar os testes com as classes Nokia e Iphone