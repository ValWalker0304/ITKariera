using System;

namespace Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            switch (month)
            {
                case "May":
                    if (nights > 7 && nights < 14)
                    {
                        Console.WriteLine("Studio {0:f2}", nights * (50 - (50 * 0.05)));
                        Console.WriteLine("Apartament {0:f2} lv.", nights * 65);
                    }
                    else if (nights > 14)
                    {
                        Console.WriteLine("Studio {0:f2} lv.", nights * (50 - (50 * 0.3)));
                        Console.WriteLine("Apartament {0:f2} lv.", nights * (65 - (65 * 0.1)));
                    }
                    else
                    {
                        Console.WriteLine("Studio {0:f2} lv.", nights * 50);
                        Console.WriteLine("Apartament {0:f2} lv.", nights * 65);
                    }

                    break;
                case "June":
                    if (nights > 14)
                    {
                        Console.WriteLine("Studio {0:f2} lv.", nights * (75.20 - (72.50 * 0.2)));
                        Console.WriteLine("Apartament {0:f2} lv.", nights * (68.70 - (68.70 * 0.1)));

                    }
                    else
                    {
                        Console.WriteLine("Studio {0:f2} lv.", nights * 75.20);
                        Console.WriteLine("Apar {0:f2} lv.", nights * 68.70);
                    }
                    break;
                case "August":
                    if (nights > 14)
                    {
                        Console.WriteLine("Studio {0:f2} lv.", nights * 76);
                        Console.WriteLine("Apartament {0:f2} lv.", nights * (77 - (77 * 0.1)));
                    }
                    else
                    {
                        Console.WriteLine("Studio {0:f2} lv.", nights * 76);
                        Console.WriteLine("Apartament {0:f2} lv.", nights * 77);
                    }
                    break;
                case "September":
                    if (nights > 14)
                    {
                        Console.WriteLine("Studio {0:f2} lv.", nights * (75.20 - (72.50 * 0.2)));
                        Console.WriteLine("Apartament {0:f2} lv.", nights * (68.70 - (68.70 * 0.1)));
                    }
                    else
                    {
                        Console.WriteLine("Studio {0:f2} lv.", nights * 75.20);
                        Console.WriteLine("Apar {0:f2} lv.", nights * 68.70);
                    }
                    break;
                case "July":
                    if (nights > 14)
                    {
                        Console.WriteLine("Studio {0:f2} lv.", nights * 76);
                        Console.WriteLine("Apartament {0:f2} lv.", nights * (77 - (77 * 0.1)));
                    }
                    else
                    {
                        Console.WriteLine("Studio {0:f2} lv.", nights * 76);
                        Console.WriteLine("Apartament {0:f2} lv.", nights * 77);
                    }
                    break;
                case "October":
                    if (nights > 7 && nights < 14)
                    {
                        Console.WriteLine("Studio {0:f2}", nights * (50 - (50 * 0.05)));
                        Console.WriteLine("Apartament {0:f2} lv.", nights * 65);
                    }
                    else if (nights > 14)
                    {
                        Console.WriteLine("Studio {0:f2} lv.", nights * (50 - (50 * 0.3)));
                        Console.WriteLine("Apartament {0:f2} lv.", nights * (65 - (65 * 0.1)));
                    }
                    else
                    {
                        Console.WriteLine("Studio {0:f2} lv.", nights * 50);
                        Console.WriteLine("Apartament {0:f2} lv.", nights * 65);
                    }
                    break;
            }
        }
    }
}
