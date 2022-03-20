using System;
using System.Collections.Generic;
using System.Linq;

namespace _16_10_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> imena = new List<string>();
            int counter = int.Parse(Console.ReadLine());
            while (counter > 0)
            {
                imena.Add(Console.ReadLine());
                counter--;
            }
            imena.Sort();
            Console.WriteLine(String.Join(", ", imena));
        }
    }
}
