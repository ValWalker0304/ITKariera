using System;

namespace upr1_modul5
{
    class Program
    {
        static void Main(string[] args)
        {
            //шаблонни класове

            //пример 1
            Box<string> box1 = new Box<string>();
            Console.WriteLine(box1.Count);
            box1.Add("hello");
            box1.Add("world");
            Console.WriteLine(box1.Count);
            box1.Remove();
            box1.Add("orange");
            box1.PrintAll();

            Console.WriteLine();
            //пример 2
            Box<int> box2 = new Box<int>();
            box2.Add(1);
            box2.Add(2);
            box2.Add(3);
            box2.Add(4);
            box2.Remove();
            box2.PrintAll();

            Console.WriteLine();
            //пример 3
            Box<bool> box3 = new Box<bool>();
            box3.Add(true);
            box3.Add(true);
            box3.Add(false);
            Console.WriteLine(box3.Count);
            box3.PrintAll();
        }
    }
}
