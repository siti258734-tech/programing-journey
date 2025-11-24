using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugas_7._2
{
    internal class Program
    {
        static double RataRata(double n1, double n2, double n3)
        {
            return (n1 + n2 + n3) / 3.0;
        }

        static void Main(string[] args)
        {
            double hasil = RataRata(80, 90, 100);
            Console.WriteLine("Rata-rata: " + hasil);

        }
    }
}
