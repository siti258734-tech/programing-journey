using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contoh_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Membuat array unyuk menyimpan data siswa
            string[] nama = new string[3];
            string[] jeniskelamin = new string[3];
            string[] kelas = new string[3];

            // input data siswa
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Masukkan nama siswa ke-{i + 1}: ");
                nama[i] = Console.ReadLine();

                Console.Write("Masukkan jenis kelamin (L/P): ");
                jeniskelamin [i] = Console.ReadLine();

                Console.Write("Masukkan kelas: ");
                kelas[i] = Console.ReadLine();
            }
            // Menampilkan data siswa 
            Console.WriteLine("\n=== Data Siswa ===");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Nama: {nama[i]} | JK: {jeniskelamin[i]} | kelas: {kelas[i]} ");
            }
            Console.ReadKey(); // Agar jendela konsol tidak langsung menutup
        }
    }
}
