using System;

class MainClass {
 public static void Main (string[] args) {
   
   double altura, basee, area, perimetro, diagonal, test;
   Console.WriteLine("Digite a base do retangulo");
   basee = double.Parse(Console.ReadLine());
   Console.WriteLine("Digite a altura do retangulo");
   altura = double.Parse(Console.ReadLine());
   
   area = basee * altura;
   perimetro = 2 * basee + 2 * altura;
   test = basee * basee + altura * altura;
   diagonal = Math.Sqrt(basee * basee + altura * altura);

   Console.WriteLine($"Area = {area}");
   Console.WriteLine($"Perimetro = {perimetro}");
   Console.WriteLine($"Diagonal = {diagonal}");

 }
}