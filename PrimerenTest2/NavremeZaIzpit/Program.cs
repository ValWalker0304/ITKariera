using System;
using System.ComponentModel;

namespace NavremeZaIzpit
{
    class Program
    {
        static void Main(string[] args)
        {
            int h1 = int.Parse(Console.ReadLine());
            int min1 = int.Parse(Console.ReadLine());
            int h2 = int.Parse(Console.ReadLine());
            int min2 = int.Parse(Console.ReadLine());
            if (h1 == h2)
            {
                if (min2 > min1)
                {
                    Console.WriteLine("Late");
                    Console.WriteLine((min2 - min1) + " minutes after the start");
                }
                else if (min1 == min2 || min2 - min1 <= 30)
                {
                    Console.WriteLine("On time");
                    Console.WriteLine((min1 - min2) + " minutes before the start");
                }
                else if (min1 - min2 > 30)
                {
                    Console.WriteLine("Early");
                    Console.WriteLine((min1 - min2) + " minutes before the start");
                }
            }
            else if (h1 > h2)
            {
                min1 = min1 + ((h1 - h2) * 60);
                if (min1 - min2 < 30)
                {
                    Console.WriteLine("On time");
                    Console.WriteLine(min1 - min2 + " minutes before the start");
                }
                else
                {
                    if (min1 - min2 <= 60)
                    {
                        Console.WriteLine("Early");
                        Console.WriteLine(min1 - min2 + " minutes before the start");
                    }
                    else
                    {
                        Console.WriteLine("Early");
                        Console.WriteLine((h1 - h2) + ":" + (min1 - min2) + " minutes before the start");
                    }

                }

            }
            else if (h2 > h1)
            {
                min2 = min2 + ((h2 - h1) * 60);
                if (min2 - min1 <= 60)
                {
                    Console.WriteLine("Late");
                    Console.WriteLine(min2 - min1 + " minutes after the start");
                }
                else
                {
                    if (min2 - min1 > 60)
                    {
                        int t = (min2 - min1) - 60;
                        Console.WriteLine("Late");
                        if (t < 10)
                        {
                            Console.WriteLine((h2 - h1) + ":" + "0" + t + " minutes after the start");
                        }
                        else
                        {
                            Console.WriteLine((h2 - h1) + ":" + t + " minutes after the start");
                        }

                    }
                    else
                    {
                        Console.WriteLine("Late");
                        Console.WriteLine((h2 - h1) + ":" + (min2 - min1) + " minutes after the start");
                    }

                }
            }
        }
    }
}
