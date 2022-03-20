using System;

namespace Producten
{
    class Program
    {
        static void Main(string[] args)
        {
            string p = Console.ReadLine();
            string g = Console.ReadLine();
            double k = double.Parse(Console.ReadLine());
            switch (p)
            {
                case "coffee":
                    switch (g)
                    {
                        case "Sofia": Console.WriteLine(k * 0.50); break;
                        case "Varna": Console.WriteLine(k * 0.45); break;
                        case "Plovdiv": Console.WriteLine(k * 0.40); break;
                    }
                    break;
                case "water":
                    switch (g)
                    {
                        case "Sofia": Console.WriteLine(k * 0.80); break;
                        case "Varna": Console.WriteLine(k * 0.70); break;
                        case "Plovdiv": Console.WriteLine(k * 0.70); break;
                    }
                    break;
                case "beer":
                    switch (g)
                    {
                        case "Sofia": Console.WriteLine(k * 1.20); break;
                        case "Varna": Console.WriteLine(k * 1.10); break;
                        case "Plovdiv": Console.WriteLine(k * 1.15); break;
                    }
                    break;
                case "sweets":
                    switch (g)
                    {
                        case "Sofia": Console.WriteLine(k * 1.45); break;
                        case "Varna": Console.WriteLine(k * 1.35); break;
                        case "Plovdiv": Console.WriteLine(k * 1.30); break;
                    }
                    break;
                case "peanuts":
                    switch (g)
                    {
                        case "Sofia": Console.WriteLine(k * 1.60); break;
                        case "Varna": Console.WriteLine(k * 1.55); break;
                        case "Plovdiv": Console.WriteLine(k * 1.50); break;
                    }
                    break;

            }
        }
    }
}
