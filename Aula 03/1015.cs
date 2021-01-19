using System;

class MainClass {
 public static void Main (string[] args) {

   double x1, x2, y1, y2;
   string a = Console.ReadLine();
   string[] a1 = a.Split(' ');
   x1 = double.Parse(a1[0]);
   y1 = double.Parse(a1[1]);

   string m = Console.ReadLine();
   string[] b1 = m.Split(' ');
   x2 = double.Parse(b1[0]);
   y2 = double.Parse(b1[1]);

   double d = Math.Pow((x2-x1),2) + Math.Pow((y2-y1),2);
   double distancia = Math.Pow(d,0.5);

   Console.WriteLine($"{distancia:0.0000}");
 }
}