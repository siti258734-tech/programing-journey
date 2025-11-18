using System;

namespace Latihan2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int total = 0;

            while (i <= 5)
            {
                total += i;
                i++;
            }
            Console.WriteLine("total = " + total);
        }
    }
}
