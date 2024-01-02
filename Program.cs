using DesafioPOO.Models;

//Implementado Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Celular Nokia");
Smartphone nokia = new Nokia("11999999999", "A-150", "589421376", 32);
nokia.Ligar();
nokia.InstalarAplicativo("Youtube");

Console.WriteLine("+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+");

Console.WriteLine("Celular Iphone");
Smartphone iphone = new Iphone("11888888888", "5s", "714856239", 256);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("AppleStore");
