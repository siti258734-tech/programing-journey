using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugas_7._1
{
    internal class Program
    {
        static void Kali(int a, int b, int c)
        {
            int hasil = a * b * c;
            Console.WriteLine("Hasil perkalian: " + hasil);
        }

        static void Main(string[] args)
        {
            Kali(2, 3, 4);   // contoh pemanggilan

        }
    }
}
