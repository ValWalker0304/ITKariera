using System;

namespace CenaZaTransport
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string d = Console.ReadLine();
            double a = 0;
            double t = 0;
            double v = 0;
            if (n < 20)
            {
                if (d == "day")
                {
                    t = 0.70 + n * 0.79;
                }
                else
                {
                    t = 0.70 + n * 0.90;
                }
                Console.WriteLine(t);
            }
            else if (n < 100)
            {
                if (d == "day")
                {
                    t = 0.70 + n * 0.79;
                    a = 0.09 * n;
                }
                else
                {
                    t = 0.70 + n * 0.90;
                    a = 0.09 * n;
                }
                Console.WriteLine(Math.Min(a,t));
            }
            else
            {
                if (d == "day")
                {
                    t = 0.70 + n * 0.79;
                    a = 0.09 * n;
                    v = 0.06 * n;
                }
                else
                {
                    t = 0.70 + n * 0.90;
                    a = 0.09 * n;
                    v = 0.06 * n;
                }
                double sum1 = Math.Min(a, v);
                double sum2 = Math.Min(v, t);
                Console.WriteLine(Math.Round(Math.Min(sum1, sum2),2));
            }
        }
    }
}
