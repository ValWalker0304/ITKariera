using System;

namespace PodoubleRec
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            if (Math.Max(x1, x2) >= x && x >= Math.Min(x1, x2) && Math.Max(y1, y2) >= y && y >= Math.Min(y1, y2))
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Outside");
                
            }
        }
    }
}
