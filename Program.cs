using DesafioPOO.Models;

// Testes implementados

Nokia nokia = new Nokia(numero: "11 9876-54321", modelo: "C12", imei: "31245458778545", memoria: 512);
Console.Clear();
Console.WriteLine("\nSmartphone NOKIA:\n");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo(nomeApp: "Instagram");

Iphone iphone= new Iphone(numero: "11 99887-6655", "Iphone 15 Plus", "3265754815904521", 1024);
Console.WriteLine("\nSmartphone IPHONE:\n");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("X");