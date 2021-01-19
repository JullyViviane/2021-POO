using System;

class MainClass {
 public static void Main (string[] args) {

   int a, b, c;
   string x = Console.ReadLine();
   string[] x1 = x.Split(' ');

   a = int.Parse(x1[0]);
   b = int.Parse(x1[1]);
   c = int.Parse(x1[2]);

   int maior = Math.Max(a,b);
   if (maior < c) maior = c;

   int menor = Math.Min(a,b);
   if (menor > c) menor = c;

   int meio = 0;
   if (maior != a && menor != a) meio = a;
   if (maior != b && menor != b) meio = b;
   if (maior != c && menor != c) meio = c;

   Console.WriteLine($"{menor}");
   Console.WriteLine($"{meio}");
   Console.WriteLine($"{maior}");
 }
}