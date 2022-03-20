using System;
using System.Collections.Generic;
using System.Text;

namespace abstract_class
{
    public class Person : Mammal,IAnimal
    {
        public string Name { get; set; }
        public string Habitat { get; set; }
        public int Age { get; set; }

        public Person(string n, int a, string h, string e, bool t)
            :base(e,t)
        {
            this.Name = n;
            this.Age = a;
            this.Habitat = h;
        }

        public void Introduce()
        {
            Console.WriteLine($"{this.Name}-{this.Age}-{this.Habitat}-{this.Eyes}-{this.Tail}");
        }
    }
}
