using System;

class MainClass {
 public static void Main (string[] args) {

   int n, n1, n2, n5, n10, n20, n50, n100;

   n = int.Parse(Console.ReadLine());
   Console.WriteLine($"{n}");

   n100 = n / 100;
   n = n - n100*100;

   n50 = n / 50;
   n = n - n50*50;

   n20 = n / 20;
   n = n - n20*20;

   n10 = n / 10;
   n = n - n10*10;

   n5 = n / 5;
   n = n - n5*5;

   n2 = n / 2;
   n = n - n2*2;

   n1 = n / 1;
   n = n - n1*1;

   Console.WriteLine($"{n100} nota(s) de R$ 100,00");
   Console.WriteLine($"{n50} nota(s) de R$ 50,00");
   Console.WriteLine($"{n20} nota(s) de R$ 20,00");
   Console.WriteLine($"{n10} nota(s) de R$ 10,00");
   Console.WriteLine($"{n5} nota(s) de R$ 5,00");
   Console.WriteLine($"{n1} nota(s) de R$ 1,00");
 }
}