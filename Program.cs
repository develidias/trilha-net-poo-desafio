using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone /

Console.WriteLine("Smartphone Nokia:");
Nokia c12 = new Nokia(numero: "11 999999999", modelo: "C12", imei: "999999999", memoria: 64);
c12.Ligar();
c12.InstalarAplicativo("Spotify");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Iphone proMax15 = new Iphone(numero: "16 999999999", modelo: "15 PRO MAX", imei: "000000000", memoria: 512);
proMax15.ReceberLigacao();     
proMax15.InstalarAplicativo("WhatsApp");