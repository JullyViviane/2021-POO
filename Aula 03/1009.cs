using System;

class MainClass {
 public static void Main (string[] args) {
   
   double salario, montante;
   string vendedor;

   Console.WriteLine("Digite o nome do vendedor.");
   vendedor = Console.ReadLine();

   Console.WriteLine("Digite o salário do vendedor");
   salario = double.Parse(Console.ReadLine());

   Console.WriteLine("Digite o montante total das vendas efetuadas por este vendedor");
   montante = double.Parse(Console.ReadLine());

   double bonus = montante * 0.15;
   double total = salario + bonus;

   Console.WriteLine($"TOTAL = R$ {total}");
 }
}