using System;

namespace Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            double p = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());
            int t = int.Parse(Console.ReadLine());
            double rab = 0;
            double rabd = 0;
            double ob = 0;
            rab = (d-(0.1 * d))*8;
            rabd = t * d * 2;
            ob = rab + rabd;
            if (ob > p)
            {
                Console.WriteLine($"Yes!{Math.Floor(Math.Abs(ob-p))} hours left.");
            }
            else
            {
                Console.WriteLine($"Not enough time!{Math.Floor(Math.Abs(p -ob))} hours needed.");
            }
        }
    }
}
