using System;

class MainClass {
 public static void Main (string[] args) {
   int notaa, notab;
   Console.WriteLine("Digite a sua primeira nota");
   notaa = int.Parse(Console.ReadLine());
   Console.WriteLine("Digite a sua segunda nota");
   notab = int.Parse(Console.ReadLine());
   int notaaf, notabf, notas, media;
   notaaf = notaa * 2;
   notabf = notab * 3;
   notas = notaaf + notabf;
   media = notas / 5;
   Console.WriteLine(media);
 }
} 