using System;
using System.IO;
using Newtonsoft.Json;

class CovidConfig
{
    private const string ConfigFilePath = "covid_config.json";
    public string SatuanSuhu { get; set; } = "celcius";
    public int BatasHariDeman { get; set; } = 14;
    public string PesanDitolak { get; set; } = "Anda tidak diperbolehkan masuk ke dalam gedung ini";
    public string PesanDiterima { get; set; } = "Anda dipersilahkan untuk masuk ke dalam gedung ini";

    public CovidConfig()
    {
        LoadConfig();
    }

    private void LoadConfig()
    {
        if (File.Exists(ConfigFilePath))
        {
            string json = File.ReadAllText(ConfigFilePath);

            if (!string.IsNullOrWhiteSpace(json)) 
            {
                var config = JsonConvert.DeserializeObject<CovidConfig>(json);
                if (config != null)
                {
                    SatuanSuhu = config.SatuanSuhu ?? "celcius";
                    BatasHariDeman = config.BatasHariDeman > 0 ? config.BatasHariDeman : 14;
                    PesanDitolak = config.PesanDitolak ?? "Anda tidak diperbolehkan masuk ke dalam gedung ini";
                    PesanDiterima = config.PesanDiterima ?? "Anda dipersilahkan untuk masuk ke dalam gedung ini";
                    return;
                }
            }
        }

        Console.WriteLine("⚠️ File konfigurasi tidak ditemukan atau rusak. Menggunakan nilai default...");
        SaveConfig();
    }

    public void SaveConfig()
    {
        string json = JsonConvert.SerializeObject(this, Formatting.Indented);
        File.WriteAllText(ConfigFilePath, json);
    }

    public void UbahSatuan()
    {
        SatuanSuhu = SatuanSuhu == "celcius" ? "fahrenheit" : "celcius";
        SaveConfig();
    }
}
