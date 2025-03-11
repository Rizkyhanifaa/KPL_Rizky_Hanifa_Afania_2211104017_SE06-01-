using System;
using System.Collections.Generic;

class Penjumlahan
{
    public static T JumlahTigaAngka<T>(T angka1, T angka2, T angka3)
    {
        dynamic a = angka1;
        dynamic b = angka2;
        dynamic c = angka3;
        return a + b + c;
    }
}
class SimpleDataBase<T>
{
    private List<T> storedData;
    private List<DateTime> inputDates;

    public SimpleDataBase()
    {
        storedData = new List<T>();
        inputDates = new List<DateTime>();
    }

    public void AddNewData(T data)
    {
        storedData.Add(data);
        inputDates.Add(DateTime.UtcNow);
    }

    public void PrintAllData()
    {
        for (int i = 0; i < storedData.Count; i++)
        {
            Console.WriteLine($"Data {i + 1} berisi: {storedData[i]}, yang disimpan pada waktu UTC: {inputDates[i]}");
        }
    }
}

class Program
{
    static void Main()
    {
        int angka1 = 22; // Dua digit pertama dari NIM 2211104017
        int angka2 = 11; // Dua digit kedua dari NIM 2211104017
        int angka3 = 10; // Dua digit ketiga dari NIM 2211104017

        int hasil = Penjumlahan.JumlahTigaAngka(angka1, angka2, angka3);
        Console.WriteLine("NIM saya 2211104017");
        Console.WriteLine("Penjumlahan tiga input angka dari 2-digit NIM (22+11+10)");
        Console.WriteLine($"\n--- Hasil penjumlahan: {hasil} ---");

        SimpleDataBase<int> database = new SimpleDataBase<int>();
        database.AddNewData(angka1);
        database.AddNewData(angka2);
        database.AddNewData(angka3);

        Console.WriteLine("\nData yang tersimpan:");
        database.PrintAllData();
    }
}

