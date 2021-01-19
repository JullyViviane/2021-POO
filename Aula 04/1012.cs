using System;

class MainClass {
 public static void Main (string[] args) {

   string x = Console.ReadLine();
   string[] x1 = x.Split(' ');

   double a, b, c, pi;
   a = double.Parse(x1[0]);
   b = double.Parse(x1[1]);
   c = double.Parse(x1[2]);
   pi = 3.14159;

   double triangulo = (a * c)/2;
   double circulo = pi * (c * c);
   double trapezio = (c * (a + b))/2;
   double quadrado = b * b;
   double retangulo = a * b;

   Console.WriteLine($"TRIANGULO: {triangulo:0.000}
CIRCULO: {circulo:0.000}
TRAPEZIO: {trapezio:0.000}
QUADRADO: {quadrado:0.000}
RETANGULO: {retangulo:0.000}");
 }
}