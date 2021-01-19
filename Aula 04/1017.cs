using System;

class MainClass {
 public static void Main (string[] args) {

   double tempo, velocidade, litros;
   string a = Console.ReadLine();
   string[] a1 = a.Split(' ');
   tempo = double.Parse(a1[0]);

   string b = Console.ReadLine();
   string[] b1 = b.Split(' ');
   velocidade = double.Parse(b1[0]);

   litros = (tempo * velocidade)/12;

   Console.WriteLine($"{litros:0.000}");
 }
}