using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latihan_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Calculator";

            int option;
            int a, b;

            MainMenu();
            while (true)
            {
                // jika konversi input ke tipe int berhasil, maka store input ke variable option
                if (!int.TryParse(Console.ReadLine(), out option) || option < 1 || option > 4)
                {
                    Console.Write("Invalid input. Pilih opsi 1-4: ");
                }
                else
                {
                    break;
                }

            }

            Console.Write("Masukkan nilai a: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Masukkan nilai b: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            switch (option)
            {
                case 1:
                    Console.WriteLine("Hasil Penjumlahan " + a + " + " + b + " = " + Penjumlahan(a, b));
                    break;
                case 2:
                    Console.WriteLine("Hasil Pengurangan " + a + " - " + b + " = " + Pengurangan(a, b));
                    break;
                case 3:
                    Console.WriteLine("Hasil Perkalian " + a + " * " + b + " = " + Perkalian(a, b));
                    break;
                case 4:
                    Console.WriteLine("Hasil Pembagian " + a + " / " + b + " = " + Pembagian(a, b));
                    break;
            }
            Console.WriteLine("Tekan keyboard untuk keluar");
            Console.ReadKey();
        }
        static int Penjumlahan(int a, int b)
        {
            return a + b;
        }
        static int Pengurangan(int a, int b)
        {
            return a - b;
        }
        static int Perkalian(int a, int b)
        {
            return a * b;
        }
        static int Pembagian(int a, int b)
        {
            return a / b;
        }
        static void MainMenu()
        {
            Console.WriteLine("1. Penjumlahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");
            Console.Write("Pilih Opsi:  ");
        }
    }
}
