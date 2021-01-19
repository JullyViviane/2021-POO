using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Digite seu nome completo");
    string a = Console.ReadLine();
    string[] b = a.Split();
    string nome = b[0];
    string sobrenome = b[1];

    Console.WriteLine($"{sobrenome}, {nome}");
      
  }
}