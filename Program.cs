using System;
using System.Collections.Generic;

class KodePos
{
    // Dictionary untuk menyimpan daftar kelurahan dan kode posnya
    private static Dictionary<string, string> daftarKodePos = new Dictionary<string, string>
    {
        {"Batununggal", "40266"},
        {"Kujangsari", "40287"},
        {"Mengger", "40267"},
        {"Wates", "40256"},
        {"Cijaura", "40287"},
        {"Jatisari", "40286"},
        {"Margasari", "40286"},
        {"Sekejati", "40286"},
        {"Kebonwaru", "40272"},
        {"Maleer", "40274"},
        {"Samoja", "40273"}
    };

    // Method untuk mendapatkan kode pos berdasarkan nama kelurahan
    public static string GetKodePos(string kelurahan)
    {
        // Mengecek apakah kelurahan ada dalam dictionary
        if (daftarKodePos.ContainsKey(kelurahan))
        {
            return daftarKodePos[kelurahan]; // Mengembalikan kode pos jika ditemukan
        }
        else
        {
            return "Kode pos tidak ditemukan"; // Mengembalikan pesan jika tidak ditemukan
        }
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Masukkan nama kelurahan: ");
        string inputKelurahan = Console.ReadLine(); // Membaca input dari user

        // Memanggil method GetKodePos untuk mencari kode pos
        string kodePos = KodePos.GetKodePos(inputKelurahan);

        Console.WriteLine($"Kode pos untuk {inputKelurahan}: {kodePos}"); // Menampilkan hasil pencarian
    }
}
