using System;
using System.Collections.Generic;
using System.Linq;

namespace PointCorXCorY
{
    class Program
    {

        public class Point
        {
            private int corX;
            private int corY;
            public int CorX
            {
                get { return this.corX; }
                set { this.corX = value; }
            }
            public int CorY
            {
                get { return this.corY; }
                set { this.corY = value; }
            }
        }
        public void Quadrant()
        {
            if (true)
            {

            }
        }
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            if (command == "Point")
            {
                Point cordinates = new Point();
                Console.WriteLine("Въведете кордината за x");
                cordinates.CorX = int.Parse(Console.ReadLine());
                Console.WriteLine("Въведете кордината за y");
                cordinates.CorX = int.Parse(Console.ReadLine());
            }
            else if (command == "Section")
            {

            }
        }
    }
}
