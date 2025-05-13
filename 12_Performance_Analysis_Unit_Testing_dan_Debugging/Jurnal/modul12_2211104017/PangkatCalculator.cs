using System;

namespace modul12_2211104017
{
    public class PangkatCalculator
    {
        public int CariNilaiPangkat(int a, int b)
        {
            // Aturan 1: Jika b == 0, hasil selalu 1 (walaupun a adalah 0)
            if (b == 0) return 1;

            // Aturan 2: Jika b < 0, hasil adalah -1
            if (b < 0) return -1;

            // Aturan 3: Jika a > 100 atau b > 10, hasil adalah -2
            if (a > 100 || b > 10) return -2;

            // Aturan 4: Hitung pangkat dengan aman (tanpa Math.Pow) dan deteksi overflow
            try
            {
                checked
                {
                    int result = 1;
                    for (int i = 0; i < b; i++)
                    {
                        result = checked(result * a);
                    }
                    return result;
                }
            }
            catch (OverflowException)
            {
                return -3; // Overflow terdeteksi
            }

            return -3; // Error lain (jika ada)
        }
    }
}
