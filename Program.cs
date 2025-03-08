
using System;

enum DoorState
{
    Terkunci,
    Terbuka
}

class DoorMachine
{
    private DoorState state;

    // Konstruktor, state awal = Terkunci
    public DoorMachine()
    {
        state = DoorState.Terkunci;
        Console.WriteLine("Pintu terkunci");
    }

    // Method untuk membuka pintu
    public void BukaPintu()
    {
        if (state == DoorState.Terkunci)
        {
            Console.WriteLine("Tidak bisa membuka, pintu masih terkunci!");
        }
        else
        {
            Console.WriteLine("Pintu sudah terbuka");
        }
    }

    // Method untuk mengunci pintu
    public void KunciPintu()
    {
        if (state == DoorState.Terkunci)
        {
            Console.WriteLine("Pintu sudah terkunci");
        }
        else
        {
            state = DoorState.Terkunci;
            Console.WriteLine("Pintu terkunci");
        }
    }

    // Method untuk membuka kunci pintu
    public void BukaKunci()
    {
        if (state == DoorState.Terbuka)
        {
            Console.WriteLine("Pintu sudah tidak terkunci");
        }
        else
        {
            state = DoorState.Terbuka;
            Console.WriteLine("Pintu tidak terkunci");
        }
    }

    // Method utama untuk menjalankan simulasi
    static void Main(string[] args)
    {
        DoorMachine pintu = new DoorMachine();

        // Simulasi perubahan state
        pintu.BukaPintu();  // Tidak bisa buka, masih terkunci
        pintu.BukaKunci();  // Membuka kunci pintu
        pintu.BukaPintu();  // Pintu terbuka
        pintu.KunciPintu(); // Mengunci kembali pintu
    }
}
