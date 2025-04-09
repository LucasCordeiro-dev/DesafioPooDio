using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia (numero:"123456", modelo: "M1",imei:"2222222",memoria:64);
nokia.Ligar();
nokia.InstalarAplicativo("ZAP-ZAP");

Console.WriteLine("\n");


Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone (numero: "654321",modelo: "M2",imei:"1111111",memoria:120);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Safari");