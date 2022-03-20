using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace upr1_modul5
{
    public class Box<T>
    {
        private List<T> data;
        public Box()
        {
            this.data = new List<T>();
        }
        public int Count => this.data.Count();

        public void Add(T item)
        { 
            this.data.Add(item); 
        }
        public void Remove()
        {
            var rem = this.data.Last();
            this.data.RemoveAt(this.data.Count - 1);
            Console.WriteLine("Removed: " + rem);
        }

        public void PrintAll()
        {
            Console.WriteLine(string.Join(", ", this.data));
        }

    }
}
