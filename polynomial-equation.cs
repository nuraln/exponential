using System;

class Program
{
    static void Main(string[] args)
    {
        // Menentukan suku banyak
        int n = 5;

        // Inisialisasi array untuk menyimpan koefisien persamaan
        double[] a = new double[n + 1];
        a[0] = 2.0;
        a[1] = -1.0;
        a[2] = 3.0;
        a[3] = 0.5;
        a[4] = -2.0;
        a[5] = 1.5;

        // Inisialisasi array untuk menyimpan solusi persamaan
        double[] x = new double[n];

        // Menggunakan metode eliminasi Gauss untuk menyelesaikan persamaan
        for (int k = 0; k < n - 1; k++)
        {
            for (int i = k + 1; i < n; i++)
            {
                double factor = a[i, k] / a[k, k];
                for (int j = k + 1; j < n + 1; j++)
                {
                    a[i, j] -= factor * a[k, j];
                }
            }
        }

        // Menyelesaikan solusi dengan substitusi mundur
        x[n - 1] = a[n - 1, n] / a[n - 1, n - 1];
        for (int i = n - 2; i >= 0; i--)
        {
            double sum = a[i, n];
            for (int j = i + 1; j < n; j++)
            {
                sum -= a[i, j] * x[j];
            }
            x[i] = sum / a[i, i];
        }

        // Menampilkan solusi persamaan
        Console.WriteLine("Solusi persamaan adalah:");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("x" + (i + 1) + " = " + x[i]);
        }

        // Menunggu pengguna menekan tombol enter
        Console.ReadLine();
    }
}
