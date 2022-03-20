using System;
using System.Collections.Generic;
using System.Text;

namespace nasledqvane
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }

        public Person(string n, int a, string c) 
        {
            this.Name = n;
            this.Age = a;
            this.City = c;
        }
        public virtual void Introduce() 
        {
            Console.WriteLine($"I am {this.Name} and I live in {this.City}");
        }
    }
}
