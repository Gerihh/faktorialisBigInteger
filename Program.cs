//BigInteger osztály (struktúra) elérése:
//System.numerics hozzáadása a referenciákhoz
using System;
using System.Numerics;

namespace faktoriálisBigInteger
{
    class Program
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Faktoriális meghatározása 20-40 között");
            for (int szám = 20; szám <= 1000; szám++)
            {
                BigInteger faktor = 1;
                for (int i = 2; i <= szám; i++)
                {
                    faktor = faktor * i;
                }
                Console.WriteLine($"{szám}!={faktor}");
            }
            
            Console.ReadKey();
        }
    }
}
