using System;

class MainClass {
 public static void Main (string[] args) {

   double valor = double.Parse(Console.ReadLine());

   if (valor >= 0 && valor <= 25.0000) 
   Console.WriteLine("Intervalo [0,25]");

   if (valor > 25.0000 && valor <= 50.0000) Console.WriteLine("Intervalo [25,50]");

   if (valor > 50.0000 && valor <= 75.0000) Console.WriteLine("Intervalo [50,75]");

   if (valor>75.0000 && valor <= 100.0000) 
   Console.WriteLine("Intervalo [75,100]");
   
   if (valor < 0 || valor > 100.0000)
	 Console.WriteLine("Fora de intervalo");
 }
}