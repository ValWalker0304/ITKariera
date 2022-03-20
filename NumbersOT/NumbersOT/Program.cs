using System;
using System.Dynamic;

namespace NumbersOT
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==========Сума=========");
            Console.WriteLine((3522 + 52353) * 23 - (2336 * 501 + 23432 - 6743) * 3);
            Console.WriteLine("===========от 1 до 20=========");
            for (int i = 1; i < 21; i++)
            {
                Console.WriteLine(i.ToString());
            }
            Console.WriteLine("=========Лице на правоъгълник=========");
            Console.WriteLine("Въведи дължина");
            var a = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Въведи ширина");
            var b = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Лицето на правоъгълника е " + a * b);
            Console.WriteLine("=========от USD към BGN==========");
            Console.WriteLine("Въведи стойност");
            var v = double.Parse(Console.ReadLine());
            v = v * 1.79549;
            Console.WriteLine(Math.Round(v, 2));
            Console.WriteLine("=========Лице на трапец==========");
            Console.WriteLine("Въведи голяма страна");
            var a1 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Въведи малка страна");
            var b1 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Въведи височина");
            var h1 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Лицето на трапеца е " + (a1 + b1) * h1 / 2);
            Console.WriteLine("=========Обиколка и лице на кръг==========");
            Console.WriteLine("Въведи радиус");
            var r = double.Parse(Console.ReadLine());
            double area = 0;
            double perimeter = 0;
            area = Math.Round(Math.PI * r * r);
            perimeter = Math.Round(2 * Math.PI * r);
            Console.WriteLine("Периметърът на кръга е " + perimeter + " а лицето му е " + area);
            Console.WriteLine("=========Лице на правоъгълник в равнина==========");
            decimal c1 = 0;
            decimal c2 = 0;
            Console.WriteLine("Въведи x1,2  ");
            var x1 = decimal.Parse(Console.ReadLine());
            var x2 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Въведи y1,2  ");
            var y1 = decimal.Parse(Console.ReadLine());
            var y2 = decimal.Parse(Console.ReadLine());
            c1 = Math.Max(x1,x2) - Math.Min(y1,y2);
            c2 = Math.Max(y1,y2) - Math.Min(x1,x2);
            Console.WriteLine(c1 * c2);
            Console.WriteLine("=========Лице на триъгълник==========");
            Console.WriteLine("Напишете основа");
            var a3 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Напишете височина");
            var h3 = decimal.Parse(Console.ReadLine());
            decimal s;
            s = (a3 * h3) / 2;
            Console.WriteLine("Лицето на триъгълник е " + s);

        }
    }
}






