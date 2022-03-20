using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string cin = Console.ReadLine();
            double red = double.Parse(Console.ReadLine());
            double colona = double.Parse(Console.ReadLine());
            double result = (red * colona);

            switch (cin)
            {
                case "Premiere": result = (result * 12); Console.WriteLine(String.Format("{0:f2}", result)); break;
                case "Normal": result = (result * 7.5); Console.WriteLine(String.Format("{0:f2}", result)); break;
                case "Discount": result = (result * 5); Console.WriteLine(String.Format("{0:f2}", result)); break;
            }


        }
    }
}