using System;
using System.Collections.Generic;
using System.Linq;

namespace Rain
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> start = new List<int>();
            for (int i = 0; i < nums.Count - 1; i++)
            {
                start.Add(nums[i]);
            }
            int index = int.Parse(Console.ReadLine());
            int steps = 1;
            while (nums[index] != 0)
            {
                steps++;
                if (nums[index] <= 0)
                {
                    foreach (var item in nums)
                    {
                        Console.Write(nums[item] + " ");
                    }
                    Console.WriteLine(steps);
                }
                for (int i = 0; i < nums.Count - 1; i++)
                {
                    nums[i]--;
                }
                for (int a = 0; a < nums.Count; a++)
                {
                    if (nums[a] < 0)
                    {
                        nums[a] += start[a];
                    }
                }
                index = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < nums.Count - 1; i++)
            {
                Console.Write(nums[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine(steps);
        }
    }
}
