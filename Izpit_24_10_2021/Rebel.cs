using System;
using System.Collections.Generic;
using System.Text;

namespace Izpit_24_10_2021_1
{
    class Rebel : Person
    {
        protected int harm;
        public int Harm
        {
            get
            {
                return harm;
            }
            set
            {
                if (value > 0)
                {
                    harm = value;
                }
                else
                    throw new ArgumentException("Harm should be greater than 0!");
            }
        }
        public Rebel(string name, int age, int harm) : base(name, age)
        {
            this.Harm = harm;
            this.Age = age;
            base.Name = name;
        }
        public int Age
        {
            get
            {
                return base.Age;
            }
            set
            {
                if (value <= 50)
                {
                    base.Age = value;
                }
                else
                    throw new ArgumentException("Age should be less or equal to 50!");
            }
        }
        public override string ToString()
        {
            StringBuilder stb = new StringBuilder();
            stb.AppendLine(base.ToString());
            stb.AppendLine($"Harm: {this.harm}");
            return stb.ToString();
        }
    }
}
