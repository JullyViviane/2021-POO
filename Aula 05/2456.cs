using System;

class MainClass {
 public static void Main (string[] args) {

   int a, b, c, d, e;
   string x = Console.ReadLine();
   string[] x1 = x.Split(' ');

   a = int.Parse(x1[0]);
   b = int.Parse(x1[1]);
   c = int.Parse(x1[2]);
   d = int.Parse(x1[3]);
   e = int.Parse(x1[4]);

   if ((a > b && a > c && a > d && a > e) && (b > c && b > d && b > e) && (c > d && c > e) && (d > e)) Console.WriteLine("D");

   if ((a < b && a < c && a < d && a < e) && (b < c && b < d && b < e) && (c < d && c < e) && (d < e)) Console.WriteLine("C");

   else
   Console.WriteLine("N");
 }
}