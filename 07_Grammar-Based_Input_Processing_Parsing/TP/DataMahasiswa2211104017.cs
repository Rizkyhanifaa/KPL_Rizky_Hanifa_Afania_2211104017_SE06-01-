using System;
using System.IO;
using Newtonsoft.Json;

class DataMahasiswa2211104017
{
    public string NamaDepan { get; set; }
    public string NamaBelakang { get; set; }
    public string NIM { get; set; }
    public string Fakultas { get; set; }

    public static void ReadJSON()
    {
        string filePath = "tp7_1_2211104017.json"; 

        if (File.Exists(filePath))
        {
            string jsonData = File.ReadAllText(filePath);

            // Parsing JSON ke Object
            var mahasiswa = JsonConvert.DeserializeObject<dynamic>(jsonData);

            string namaDepan = mahasiswa.nama.depan;
            string namaBelakang = mahasiswa.nama.belakang;
            string nim = mahasiswa.nim;
            string fakultas = mahasiswa.fakultas;

            Console.WriteLine($"Nama {namaDepan} {namaBelakang} dengan NIM {nim} dari fakultas {fakultas}");
        }
        else
        {
            Console.WriteLine("File JSON tidak ditemukan! Pastikan file berada di folder project.");
        }
    }
}
