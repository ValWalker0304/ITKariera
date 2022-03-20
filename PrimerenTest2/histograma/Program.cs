using System;

namespace histograma
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double a1 = 0;
            double a2 = 0;
            double a3 = 0;
            double a4 = 0;
            double a5 = 0;
            double f1 = 0;
            double f2 = 0;
            double f3 = 0;
            double f4 = 0;
            double f5 = 0;



            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num < 200)
                {
                    a1 += 1;
                }
                else if (num >= 200 && num <= 399)
                {
                    a2 += 1;
                }
                else if (num >= 400 && num <= 599)
                {
                    a3 += 1;

                }
                else if (num >= 600 && num <= 799)
                {
                    a4 += 1;
                }
                else
                {
                    a5 += 1;
                }




            }
            f1 = a1 / n * 100;
            f2 = a2 / n * 100;
            f3 = a3 / n * 100;
            f4 = a4 / n * 100;
            f5 = a5 / n * 100;


            Console.WriteLine("{0:f2}%", f1);
            Console.WriteLine("{0:f2}%", f2);
            Console.WriteLine("{0:f2}%", f3);
            Console.WriteLine("{0:f2}%", f4);
            Console.WriteLine("{0:f2}%", f5);
        }
    }
}
