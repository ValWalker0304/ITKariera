using System;
using System.Globalization;

namespace _3zadacha
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int idk = n * 3;
            int n_2 = n;
            int n_1 = n;
            int red = n * 4;
            int kur = 1;

            Console.WriteLine(new string('.', n) + new string('*', 3 * n) + new string('.', n));
            for (int i = 0; i <= n; i++)
            {
                if (n_2 <= 0)
                {
                    break;
                }

                Console.WriteLine(new string('.', n_2 - 1) + new string('*', 1) + new string('.', idk) + new string('*', 1) + new string('.', n_2 - 1));
                n_2--;
                idk += 2;


            }
            Console.WriteLine(new string('*', 5 * n_1));
            for (int i = 0; i < (2 * n_1) + 1; i++)
            {
                Console.WriteLine(new string('.', kur) + new string('*', 1) + new string('.', (5 * n) - 2 * (1 + kur)) + new string('*', 1) + new string('.', kur));
                kur++;
                red = red - 2;
                if (red <= 0)
                {
                    break;
                }


            }
            Console.WriteLine(new string('.', (2 * n) + 1) + new string('*', n - 2) + new string('.', (2 * n) + 1));
        }
    }
}
