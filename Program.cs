using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia");

Nokia nokia = new Nokia(numero: "123456789", modelo: "Nokia 3310", imei: "123456789", memoria: 16);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("--------------------------------------------");

Console.WriteLine("Smartphone Iphone");
Iphone iphone = new Iphone(numero: "987654321", modelo: "Iphone 13 Pro Max", imei: "987654321", memoria: 16);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("WhatsApp");