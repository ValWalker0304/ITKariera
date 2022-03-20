using System;

namespace ConverterMettic
{
    class Program
    {
        static void Main(string[] args)
        {
            double i = double.Parse(Console.ReadLine());
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();
            switch (input1)
            {
                case "m":
                    switch (input2)
                    {
                        case "m": Console.WriteLine(i + " m"); break;
                        case "mm": Console.WriteLine(i * 1000 + " mm"); break;
                        case "cm": Console.WriteLine(i * 100 + " cm"); break;
                        case "mi": Console.WriteLine(i * 0.000621371192 + " mi"); break;
                        case "in": Console.WriteLine(i * 39.3700787 + " in"); break;
                        case "km": Console.WriteLine(i * 0.001 + " km"); break;
                        case "ft": Console.WriteLine(i * 3.2808399 + " ft"); break;
                        case "yd": Console.WriteLine(i * 1.0936133 + " yd"); break;

                    }
                    break;
                case "mm":
                    switch (input2)
                    {
                        case "m": Console.WriteLine(i * 0.001 + " m"); break;
                        case "mm": Console.WriteLine(i + " mm"); break;
                        case "cm": Console.WriteLine(i * 0.1 + " cm"); break;
                        case "mi": Console.WriteLine(i * (6.213711922 * (10 ^ -7)) + " mi"); break;
                        case "in": Console.WriteLine(i * 0.0393700787 + "in"); break;
                        case "km": Console.WriteLine(i * (1 * (10 ^ -6)) + " km"); break;
                        case "ft": Console.WriteLine(i * 0.0032808399 + " ft"); break;
                        case "yd": Console.WriteLine(i * 0.0010936133 + " yd"); break;

                    }
                    break;
                case "cm":
                    switch (input2)
                    {
                        case "m": Console.WriteLine(i * 0.01 + " m"); break;
                        case "mm": Console.WriteLine(i * 10 + " mm"); break;
                        case "cm": Console.WriteLine(i + " cm"); break;
                        case "mi": Console.WriteLine(i * (6.21371192 * (10 ^ -6)) + " mi"); break;
                        case "in": Console.WriteLine(i * 0.393700787 + " in"); break;
                        case "km": Console.WriteLine(i * (1 * (10 ^ -5)) + " km"); break;
                        case "ft": Console.WriteLine(i * 0.032808399 + " ft"); break;
                        case "yd": Console.WriteLine(i * 0.010936133 + " yd"); break;

                    }
                    break;
                case "mi":
                    switch (input2)
                    {
                        case "m": Console.WriteLine(i * 1609.344 + " m"); break;
                        case "mm": Console.WriteLine(i * 1609344 + " mm"); break;
                        case "cm": Console.WriteLine(i * 160934.4 + " cm"); break;
                        case "mi": Console.WriteLine(i + " mi"); break;
                        case "in": Console.WriteLine(i * 63360 + " in"); break;
                        case "km": Console.WriteLine(i * 1.609344 + " km"); break;
                        case "ft": Console.WriteLine(i * 5280 + " ft"); break;
                        case "yd": Console.WriteLine(i * 1760 + " yd"); break;

                    }
                    break;
                case "in":
                    switch (input2)
                    {
                        case "m": Console.WriteLine(i * 39.3700787 + " m"); break;
                        case "mm": Console.WriteLine(i * 25.4 + " mm"); break;
                        case "cm": Console.WriteLine(i * 2.54 + " cm"); break;
                        case "mi": Console.WriteLine(i / 63360 + " mi"); break;
                        case "in": Console.WriteLine(i + "in"); break;
                        case "km": Console.WriteLine(i / 39370 + " km"); break;
                        case "ft": Console.WriteLine(i / 12 + " ft"); break;
                        case "yd": Console.WriteLine(i / 36 + " yd"); break;

                    }
                    break;
                case "km":
                    switch (input2)
                    {
                        case "m": Console.WriteLine(i * 1000 + " m"); break;
                        case "mm": Console.WriteLine(i * 1e+6 + " mm"); break;
                        case "cm": Console.WriteLine(i * 100000 + " cm"); break;
                        case "mi": Console.WriteLine(i / 1.609 + " mi"); break;
                        case "in": Console.WriteLine(i * 39370 + " in"); break;
                        case "km": Console.WriteLine(i + " km"); break;
                        case "ft": Console.WriteLine(i * 3281 + " ft"); break;
                        case "yd": Console.WriteLine(i * 1094 + " yd"); break;

                    }
                    break;
                case "ft":
                    switch (input2)
                    {
                        case "m": Console.WriteLine(i / 3.281 + " m"); break;
                        case "mm": Console.WriteLine(i * 305 + " mm"); break;
                        case "cm": Console.WriteLine(i * 30.48 + " cm"); break;
                        case "mi": Console.WriteLine(i / 5280 + " mi"); break;
                        case "in": Console.WriteLine(i * 12 + " in"); break;
                        case "km": Console.WriteLine(i / 3281 + " km"); break;
                        case "ft": Console.WriteLine(i + " ft"); break;
                        case "yd": Console.WriteLine(i / 3 + " yd"); break;

                    }
                    break;
                case "yd":
                    switch (input2)
                    {
                        case "m": Console.WriteLine(i / 1.094 + " m"); break;
                        case "mm": Console.WriteLine(i * 914 + " mm"); break;
                        case "cm": Console.WriteLine(i * 91.44 + " cm"); break;
                        case "mi": Console.WriteLine(i / 1760 + " mi"); break;
                        case "in": Console.WriteLine(i * 36 + " in"); break;
                        case "km": Console.WriteLine(i / 1094 + " km"); break;
                        case "ft": Console.WriteLine(i * 3 + " ft"); break;
                        case "yd": Console.WriteLine(i + " yd"); break;

                    }
                    break;
            }
        }
    }
}
