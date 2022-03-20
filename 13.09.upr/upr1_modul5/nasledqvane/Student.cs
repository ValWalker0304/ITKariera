using System;
using System.Collections.Generic;
using System.Text;

namespace nasledqvane
{
    public class Student:Person
    {
        public string Specialty { get; set; }
        public int Course { get; set; }
        public Student(string n, int a, string c, int co, string sp)
            :base(n,a,c)
        {
            this.Course = co;
            this.Specialty = sp;
        }

        public void IntroduceMyself()
        {
            base.Introduce();
            Console.WriteLine("I am a student.");  
        }
        public override void Introduce()
        {
            Console.WriteLine($"Hello, I am {this.Name}");
        }
    }
}
