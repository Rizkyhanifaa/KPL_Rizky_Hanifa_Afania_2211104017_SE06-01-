using System;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;

class KuliahMahasiswa2211104017
{
    public class MataKuliah
    {
        public string Code { get; set; }
        public string Name { get; set; }
    }

    public class Kuliah
    {
        public List<MataKuliah> Courses { get; set; }
    }

    public static void ReadJSON()
    {
        string filePath = "tp7_2_2211104017.json"; 

        if (File.Exists(filePath))
        {
            string jsonData = File.ReadAllText(filePath);
            var daftarKuliah = JsonConvert.DeserializeObject<Kuliah>(jsonData);

            Console.WriteLine("\nDaftar mata kuliah yang diambil:");
            int i = 1;
            foreach (var matkul in daftarKuliah.Courses)
            {
                Console.WriteLine($"MK {i} {matkul.Code} - {matkul.Name}");
                i++;
            }
        }
        else
        {
            Console.WriteLine("File JSON tidak ditemukan! Pastikan file berada di folder project.");
        }
    }
}
