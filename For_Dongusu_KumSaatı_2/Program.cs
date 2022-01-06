
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Dongusu_KumSaatı_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi, i, j, k, x, y, z;
            Console.Write("Lütfen bir sayı giriniz   : ");
            sayi = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine();
            for (i = 1; i <= sayi; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write(" ");
                }
                for (k = i; k <= sayi; k++)
                {
                    Console.Write(i);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            for (x = 1; x <= sayi; x++)
            {
                for (y = x; y <= sayi; y++)
                {
                    Console.Write(" ");
                }
                for (z = 1; z <= x; z++)
                {
                    Console.Write(x);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
