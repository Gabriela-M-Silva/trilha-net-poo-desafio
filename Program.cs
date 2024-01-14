using DesafioPOO.Models;

Console.WriteLine("Testando o Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "12345", modelo: "Modelo 1", imei: "000011", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("Skeelo");

Console.WriteLine("\n");

Console.WriteLine("Testando o Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "54321", modelo: "Modelo 2", imei: "110000", memoria: 256);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("ReadEra");