using System;

class MainClass {
 public static void Main (string[] args) {

   double a, b, c, maior;
   string x = Console.ReadLine();
   string[] y = x.Split();  
   a = double.Parse(y[0]);
   b = double.Parse(y[1]);
   c = double.Parse(y[2]);

   if (a > b && a > c) Console.WriteLine($"{a}, eh o maior");
   if (b > a && b > c) Console.WriteLine($"{b}, eh o maior");
   if (c > b && c > b) Console.WriteLine($"{c}, eh o maior");
 }
}