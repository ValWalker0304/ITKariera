using System;
using System.Collections.Generic;
using System.Text;

namespace Izpit_24_10_2021_1
{
    public class Peasant : Person
    {
        protected int productivity;
        public int Productivity
        {
            get
            {
                return productivity;
            }
            set
            {
                if (value > 0)
                {
                    productivity = value;
                }
                else
                    throw new ArgumentException("Productivity cannot be less or equal to 0!");
            }
                
        }
        public Peasant(string name, int age, int productivity) 
            : base(name, age)
        {
            this.Productivity = productivity;
            this.Age = age;
            base.Name = name;
        }
        public  int Age
        {
            get
            {
                return base.Age;
            }
            set
            {
               
                if (value <= 110)
                {
                    base.Age = value;
                }
                else
                    throw new ArgumentException("Age cannot be greater than 110!");
            }

        }
        public override string ToString()
        {
            StringBuilder stb = new StringBuilder();
            stb.AppendLine(base.ToString());
            stb.AppendLine($"Productivity: {this.productivity}");
            return stb.ToString();
        }
    }
}
