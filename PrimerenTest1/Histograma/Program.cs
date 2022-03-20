using System;

namespace Histograma
{
    class Program
    {
        static void Main(string[] args)
        {
            int y = int.Parse(Console.ReadLine());
            int a1 = 0;
            int a2 = 0;
            int a3 = 0;
            int a4 = 0;
            int a5 = 0;
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;
            for (int i = 0; i < y; i++)
            {
                int n = int.Parse(Console.ReadLine());

                if (n < 200)
                {
                    a1++;
                }
                else if (n > 199 && n < 400)
                {
                    a2++;
                }
                else if (n > 399 && n < 500)
                {
                    a3++;
                }
                else if (n > 599 && n < 800)
                {
                    a4++;
                }
                else if (n > 799)
                {
                    a5++;
                }
            }
            p1 = a1 / y * 100;
            p2 = a2 / y * 100;
            p3 = a3 / y * 100;
            p4 = a4 / y * 100;
            p5 = a5 / y * 100;
            Console.WriteLine("{0:f2}%", p1);
            Console.WriteLine("{0:f2}%", p2);
            Console.WriteLine("{0:f2}%", p3);
            Console.WriteLine("{0:f2}%", p4);
            Console.WriteLine("{0:f2}%", p5);
            /*int n = int.Parse(Console.ReadLine());

            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;
            double g1 = 0;
            double g2 = 0;
            double g3 = 0;
            double g4 = 0;
            double g5 = 0;



            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num < 200)
                {
                    p1 += 1;
                }
                else if (num >= 200 && num <= 399)
                {
                    p2 += 1;
                }
                else if (num >= 400 && num <= 599)
                {
                    p3 += 1;

                }
                else if (num >= 600 && num <= 799)
                {
                    p4 += 1;
                }
                else
                {
                    p5 += 1;
                }




            }
            g1 = p1 / n * 100;
            g2 = p2 / n * 100;
            g3 = p3 / n * 100;
            g4 = p4 / n * 100;
            g5 = p5 / n * 100;


            Console.WriteLine("{0:f2}", g1);
            Console.WriteLine("{0:f2}", g2);
            Console.WriteLine("{0:f2}", g3);
            Console.WriteLine("{0:f2}", g4);
            Console.WriteLine("{0:f2}", g5);*/
        }
    }
}
