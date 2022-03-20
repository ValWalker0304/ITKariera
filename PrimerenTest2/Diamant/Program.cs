using System;

namespace Diamant
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int idk = n * 3;
            int n2 = n;
            int n1 = n;
            int p1 = n * 4;
            int p2 = 1;

            Console.WriteLine(new string('.', n) + new string('*', 3 * n) + new string('.', n));
            for (int i = 0; i <= n; i++)
            {
                if (n2 <= 0)
                {
                    break;
                }
                Console.WriteLine(new string('.', n2 - 1) + new string('*', 1) + new string('.', idk) + new string('*', 1) + new string('.', n2 - 1));
                n2--;
                idk += 2;
            }
            Console.WriteLine(new string('*', 5 * n1));
            for (int i = 0; i < (2 * n1) + 1; i++)
            {
                Console.WriteLine(new string('.', p2) + new string('*', 1) + new string('.', (5 * n) - 2 * (1 + p2)) + new string('*', 1) + new string('.', p2));
                p2++;
                p1 = p1 - 2;
                if (p1 <= 0)
                {
                    break;
                }
            }
            Console.WriteLine(new string('.', (2 * n) + 1) + new string('*', n - 2) + new string('.', (2 * n) + 1));
        }
    }
}
