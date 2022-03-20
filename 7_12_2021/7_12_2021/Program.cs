using System;
using System.Collections.Generic;
using System.Linq;

namespace _7_12_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a whole number:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine($"Factorial: {CustomMath.Factorial(x)}");
            Console.WriteLine();
            Console.WriteLine("Please enter n & k:");
            List<int> input = new List<int>(Console.ReadLine().Split(" ").Select(int.Parse).ToList());
            int n = input[0];
            int k = input[1];
            Console.WriteLine($"Combinations: {CustomMath.Combinations(n, k)}");
        }
    }
}
