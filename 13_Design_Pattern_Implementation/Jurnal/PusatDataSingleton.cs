using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul13_2211104017
{
    public class PusatDataSingleton
    {
        // Atribut Singleton dan List
        private static PusatDataSingleton _instance;
        private List<string> DataTersimpan;

        // Konstruktor Private
        private PusatDataSingleton()
        {
            DataTersimpan = new List<string>();
        }

        // Method Singleton
        public static PusatDataSingleton GetDataSingleton()
        {
            if (_instance == null)
            {
                _instance = new PusatDataSingleton();
            }
            return _instance;
        }

        // Method untuk mendapatkan semua data
        public List<string> GetSemuaData()
        {
            return DataTersimpan;
        }

        // Method untuk mencetak semua data
        public void PrintSemuaData()
        {
            Console.WriteLine(" Data Tersimpan:");
            foreach (string data in DataTersimpan)
            {
                Console.WriteLine("- " + data);
            }
        }

        // Method untuk menambahkan data
        public void AddSebuahData(string input)
        {
            DataTersimpan.Add(input);
        }

        // Method untuk menghapus data berdasarkan index
        public void HapusSebuahData(int index)
        {
            if (index >= 0 && index < DataTersimpan.Count)
            {
                DataTersimpan.RemoveAt(index);
            }
            else
            {
                Console.WriteLine("Index tidak valid.");
            }
        }
    }
}
