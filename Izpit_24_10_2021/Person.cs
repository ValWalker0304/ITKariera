using System;
using System.Collections.Generic;
using System.Text;

namespace Izpit_24_10_2021_1
{
    public abstract class Person
    {
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value.Length >= 3 && value.Length <= 30)
                {
                    this.name = value;
                }
                else
                {
                    throw new ArgumentException("Name should be between 3 and 30 characters!");
                }
            }
        }
        private int age;
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value >= 0)
                {
                    this.age = value;
                }
                else
                    throw new ArgumentException("Age should be 0 or positive!");
            }
        }
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public override string ToString()
        {
            StringBuilder stb = new StringBuilder();
            stb.AppendLine($"Name: {this.name}");
            stb.AppendLine($"Age: {this.age}");
            return stb.ToString();
        }
    }
}
