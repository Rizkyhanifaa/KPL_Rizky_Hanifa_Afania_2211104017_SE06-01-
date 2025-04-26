using System;
using MatematikaLibraries;

class Program
{
    static void Main()
    {
        Console.WriteLine("--- Nama: Rizky Hanifa Afania ---");
        Console.WriteLine("--- NIM: 2211104017 ---");
        Console.WriteLine("--- Kelas: SE0601 ---");

        Matematika mtk = new Matematika();

        Console.WriteLine("\nA. Menghitung FPB dari 60 dan 45 ");
        Console.WriteLine("   Hasilnya =  " + mtk.FPB(60, 45));

        Console.WriteLine("\nB. Menghitung KPK dari 12 dan 8 ");
        Console.WriteLine("   Hasilnya =  " + mtk.KPK(12, 8));

        int[] persamaan1 = { 1, 4, -12, 9 };
        Console.WriteLine("\nC. Menghitung Turunan dari x^3 + 4x^2 -12x + 9 ");
        Console.WriteLine("   Hasilnya =  " + mtk.Turunan(persamaan1));

        int[] persamaan2 = { 4, 6, -12, 9 };
        Console.WriteLine("\nD. Menghitung Integral dari 4x^3 + 6x^2 -12x + 9: " );
        Console.WriteLine("   Hasilnya =  " + mtk.Integral(persamaan2));
    }
}
