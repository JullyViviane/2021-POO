using System;

class MainClass {
 public static void Main (string[] args) {

   int a, b, c, d;
   string x = Console.ReadLine();
   string[] x1 = x.Split(' ');

   a = int.Parse(x1[0]);
   b = int.Parse(x1[1]);
   c = int.Parse(x1[2]);
   d = int.Parse(x1[3]);

   if ((b > c && d > a) && (c + d > b + a) && (c >= 0 && d >= 0) && (a % 2 == 0)) Console.WriteLine("Valores aceitos");
   else Console.WriteLine("Valores nao aceitos");
 }
}