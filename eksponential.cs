using System;

class Program
{
    static void Main(string[] args)
    {
        double x = 2.0; // Nilai x
        double y = 3.0; // Nilai y

        double result = Math.Pow(x, 1 / y); // Menghitung hasil

        Console.WriteLine("Hasil dari " + x + " pangkat 1/" + y + " adalah " + result); // Menampilkan hasil

        Console.ReadLine(); // Menunggu pengguna menekan tombol enter
    }
}
