using System;

namespace PrimerenTest2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a1 = double.Parse(Console.ReadLine());
            double a2 = double.Parse(Console.ReadLine());
            int a3 = int.Parse(Console.ReadLine());
            int a4 = int.Parse(Console.ReadLine());
            double sum1 = a1 * a3;
            double sum2 = a2 * a4;
            double max = sum1 + sum2;
            max = max / 1.94;
            Console.WriteLine(max);
        }
    }
}
