using DesafioPOO.Models;

// Implementado
Console.WriteLine("Smartphone iPhone");
Smartphone iphone = new Iphone(numero: "1234", modelo: "iPhone 12", imei: "12345646", memoria: 256);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");

Console.WriteLine();

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "5678", modelo: "Nokia G60", imei: "7874354534", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("Telegram");