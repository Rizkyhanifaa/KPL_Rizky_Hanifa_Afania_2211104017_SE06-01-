using System;

// Kelas generik untuk menampilkan sapaan kepada user
public class GreetingUtility
{
    public static void DisplayGreeting<T>(T userName)
    {
        Console.WriteLine($"Halo user {userName}");
    }
}

// Kelas generik untuk menyimpan dan menampilkan data
public class GenericData<T>
{
    private T _data;

    // Konstruktor untuk menyimpan data
    public GenericData(T data)
    {
        _data = data;
    }

    // Method untuk mencetak data yang tersimpan
    public void DisplayData()
    {
        Console.WriteLine($"Data yang tersimpan adalah: {_data}");
    }
}

// Kelas utama Program
class Program
{
    static void Main()
    {
        // Menampilkan sapaan untuk user
        GreetingUtility.DisplayGreeting("Rizky Hanifa Afania");

        // Membuat objek GenericData dengan NIM dan menampilkan data
        GenericData<string> studentData = new GenericData<string>("2211104017");
        studentData.DisplayData();
    }
}
