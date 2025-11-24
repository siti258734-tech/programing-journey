using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugas_7._3
{
    internal class Program
    {
        static double KonversiSuhu(double celcius)
        {
            return (celcius * 9.0 / 5.0) + 32.0;
        }

        static void Main(string[] args)
        {
            Console.Write("Masukkan suhu (Celcius): ");
            double c = double.Parse(Console.ReadLine());

            double f = KonversiSuhu(c);
            Console.WriteLine("Hasil konversi ke Fahrenheit: " + f);

        }
    }
}
