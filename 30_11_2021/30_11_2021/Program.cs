using System;

namespace _30_11_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишете стойност за x");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Напишете стойност за y");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Напишете стойност за n");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Напиши каква функция да бъде извършена");
            string func = Console.ReadLine();
             switch (func)
             {
                case "Min":
                    Console.WriteLine($"Min e равно {Arithmetic.Min(x, y)}");
                    break;
                case "Max":
                    Console.WriteLine($"Max e равно {Arithmetic.Max(x, y)}");
                    break;
                case "Power":
                    Console.WriteLine($"Числото x на степен 2 е  {Arithmetic.PowD(x,y)}");
                    break;
                case "Fib":
                    Console.WriteLine( $"{n}тото число от фибоначи е {Arithmetic.Fib(n)}");
                    break;
                case "Fac":
                    Console.WriteLine($"Факториела на {n} е {Arithmetic.Fac(n)}");
                    break;
                default:
                break;
             }
        }
    }
}
