using System;
using AljabarLibraries;

namespace AljabarConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Nama : Rizky Hanifa Afania ---");
            Console.WriteLine("--- NIM  : 2211104017 ---");
            Console.WriteLine("--- Kelas: SE0601 ---");

            // AkarPersamaanKuadrat
            double[] persamaan1 = { 1, -3, -10 };
            double[] akar = Aljabar.AkarPersamaanKuadrat(persamaan1);

            Console.WriteLine("\nDiketahui Akar Persamaan Kuadrat = {1, -3, -10}");
            Console.WriteLine("Hasil Akar Persamaan:");
            foreach (double x in akar)
            {
                Console.WriteLine( x );
            }

            // HasilKuadrat
            double[] persamaan2 = { 2, -3 };
            double[] kuadrat = Aljabar.HasilKuadrat(persamaan2);

            Console.WriteLine("\nDiketahui Kuadrat = {2, -3}");
            Console.WriteLine("Hasil Kuadrat:");
            foreach (double x in kuadrat)
            {
                Console.WriteLine( x );
            }
        }
    }
}



