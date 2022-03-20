using System;

namespace FigureFace
{
    class Program
    {
        static void Main(string[] args)
        {
            string f = Console.ReadLine();
            var a = double.Parse(Console.ReadLine());
            double s = 0;
            if (f.ToLower() == "square") 
            {
                s = a * a;
                Console.WriteLine(s);
            }
            else if (f.ToLower() == "circle")
            {
                s = Math.PI * a * a;
                Console.WriteLine(s);
            }
            if (f.ToLower() == "rectangle")
            {
                var d = double.Parse(Console.ReadLine());
                s = (d * a);
                Console.WriteLine(s);

            }
            else if (f.ToLower() == "triangle") 
            {
                var d = double.Parse(Console.ReadLine());
                s = (d * a) / 2;
                Console.WriteLine(s);
            }
        }
    }
}
