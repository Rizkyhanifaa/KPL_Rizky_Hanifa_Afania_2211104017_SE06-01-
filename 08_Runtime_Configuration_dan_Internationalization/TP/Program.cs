using System;

class Program
{
    static void Main()
    {
        CovidConfig config = new CovidConfig();

        Console.WriteLine("Apakah Anda ingin mengubah satuan suhu? (y/n): ");
        string changeUnit = Console.ReadLine();
        if (changeUnit.ToLower() == "y")
        {
            config.UbahSatuan();
            Console.WriteLine("Satuan suhu telah diubah menjadi " + config.SatuanSuhu);
        }

        Console.Write($"Berapa suhu badan anda saat ini? Dalam nilai {config.SatuanSuhu}: ");
        double suhu = Convert.ToDouble(Console.ReadLine());

        Console.Write("Berapa hari yang lalu (perkiraan) anda terakhir memiliki gejala demam? ");
        int hariDemam = Convert.ToInt32(Console.ReadLine());

        bool suhuDalamBatas = config.SatuanSuhu == "celcius" ? (suhu >= 36.5 && suhu <= 37.5) : (suhu >= 97.7 && suhu <= 99.5);
        bool hariDalamBatas = hariDemam < config.BatasHariDeman;

        Console.WriteLine(suhuDalamBatas && hariDalamBatas ? config.PesanDiterima : config.PesanDitolak);
    }
}
