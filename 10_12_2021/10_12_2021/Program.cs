using System;
using System.Collections.Generic;
using System.Linq;

namespace _10_12_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            FilmInfo film1 = new FilmInfo();
            Console.WriteLine("Напишете информация за филма");
            Console.WriteLine("Име на филма: ");
            film1.Name = Console.ReadLine();
            Console.WriteLine("Напишете жанр на филма: ");
            film1.Genre = Console.ReadLine();
            Console.WriteLine("Напишете дата: ");
            film1.Date = int.Parse(Console.ReadLine());
            
        }
    }
}
