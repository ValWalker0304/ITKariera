using System;

namespace PrimerenTest1
{
    class Program
    {
        static void Main(string[] args)
        {
            int bitcoin = int.Parse(Console.ReadLine());
            double china = double.Parse(Console.ReadLine());
            double com = double.Parse(Console.ReadLine());
            double bit_bgn = 0;
            double china_usd = 0;
            double usd_bgn = 0;
            double max = 0;
            double sum = 0;
            bit_bgn = bitcoin * 1168;
            china_usd = china * 0.15;
            usd_bgn = china_usd * 1.76;
            max = usd_bgn + bit_bgn;
            max = max  / 1.95;
            sum = max * (com / 100);
            Console.WriteLine(max - sum);
        }
    }
}
