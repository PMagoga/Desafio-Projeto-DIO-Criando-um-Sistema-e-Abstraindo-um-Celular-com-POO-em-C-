using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "98199558", modelo: "Modelo A", imei: "1123123", memoria: "64");
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone");
Smartphone iphone = new Iphone(numero: "4654887", modelo: "ModeloB", imei: "987456321", memoria: "128");
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");