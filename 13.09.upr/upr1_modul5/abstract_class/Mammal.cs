using System;
using System.Collections.Generic;
using System.Text;

namespace abstract_class
{
    public abstract class Mammal
    {
        public string Eyes{ get; set; }
        public string Fur { get; set; }
        public bool Tail { get; set; }

        public Mammal(string e, string f, bool t)
        {
            this.Eyes = e;
            this.Fur = f;
            this.Tail = t;
        }
        public Mammal(string e, bool t)
        {
            this.Eyes = e;
            this.Tail = t;
        }
        public void HelloMethod()
        {
            Console.WriteLine("Hello");
        }
    }
}
