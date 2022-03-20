using System;
using System.Collections.Generic;
using System.Linq;

namespace _17_11_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = int.Parse(Console.ReadLine());
            var persons = new List<Person>();
            for (int i = 0; i < lines; i++)
            {
                var cmdArgs = Console.ReadLine().Split();
                var person = new Person(cmdArgs[0], cmdArgs[1], int.Parse(cmdArgs[2]),double.Parse(cmdArgs[3]));
                persons.Add(person);
            }
            var bonus = double.Parse(Console.ReadLine());
            foreach (var item in persons)
            {
                item.IncreaseSalary(bonus);
            }
            persons.ForEach(x => Console.WriteLine(x.ToString()));
        }
    }
}
