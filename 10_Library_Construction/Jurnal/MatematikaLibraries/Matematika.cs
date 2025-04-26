namespace MatematikaLibraries
{
    public class Matematika
    {
        public int FPB(int input1, int input2)
        {
            while (input2 != 0)
            {
                int temp = input2;
                input2 = input1 % input2;
                input1 = temp;
            }
            return input1;
        }

        public int KPK(int input1, int input2)
        {
            return (input1 * input2) / FPB(input1, input2);
        }

        public string Turunan(int[] persamaan)
        {
            List<string> hasil = new List<string>();
            for (int i = 0; i < persamaan.Length - 1; i++)
            {
                int koef = persamaan[i] * (persamaan.Length - i - 1);
                int pangkat = persamaan.Length - i - 2;
                if (koef == 0) continue;
                string suku = (pangkat == 0) ? $"{koef}" :
                              (pangkat == 1) ? $"{koef}x" :
                              $"{koef}x^{pangkat}";
                hasil.Add(suku);
            }
            return string.Join(" + ", hasil).Replace("+ -", "- ");
        }

        public string Integral(int[] persamaan)
        {
            List<string> hasil = new List<string>();
            for (int i = 0; i < persamaan.Length; i++)
            {
                int pangkat = persamaan.Length - i;
                double koef = (double)persamaan[i] / pangkat;
                string koefStr = koef == 1 ? "" : koef == -1 ? "-" : koef.ToString("0.#");
                string suku = pangkat == 1 ? $"{koefStr}x" : $"{koefStr}x^{pangkat}";
                hasil.Add(suku);
            }
            hasil.Add("C");
            return string.Join(" + ", hasil).Replace("+ -", "- ");
        }
    }
}
