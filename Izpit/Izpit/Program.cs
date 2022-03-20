using System;

namespace Izpit
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int b2 = 0;
            int b3 = 0;
            int b4 = 0;

            for (int i = 0; i < n; i++)
            {
                int cn = int.Parse(Console.ReadLine());

                if (cn % 2 == 0)
                {
                    b2++;
                }
                if (cn % 3 == 0)
                {
                    b3++;
                }
                if (cn % 5 == 0)
                {
                    b4++;
                }
            }

            Console.WriteLine(b2);
            Console.WriteLine(b3);
            Console.WriteLine(b4);
        }
    }
}
