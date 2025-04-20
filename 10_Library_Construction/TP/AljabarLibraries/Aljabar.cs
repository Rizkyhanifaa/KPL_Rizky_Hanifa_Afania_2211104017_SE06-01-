using System;

namespace AljabarLibraries
{
    public class Aljabar
    {
        public static double[] AkarPersamaanKuadrat(double[] persamaan)
        {
            double a = persamaan[0];
            double b = persamaan[1];
            double c = persamaan[2];
            double diskriminan = b * b - 4 * a * c;

            if (diskriminan < 0)
            {
                return new double[0]; 
            }

            double x1 = (-b + Math.Sqrt(diskriminan)) / (2 * a);
            double x2 = (-b - Math.Sqrt(diskriminan)) / (2 * a);

            return new double[] { x1, x2 };
        }

        public static double[] HasilKuadrat(double[] persamaan)
        {
            double a = persamaan[0];
            double b = persamaan[1];

            double a_kuadrat = a * a;
            double ab_dua = 2 * a * b;
            double b_kuadrat = b * b;

            return new double[] { a_kuadrat, ab_dua, b_kuadrat };
        }
    }
}


