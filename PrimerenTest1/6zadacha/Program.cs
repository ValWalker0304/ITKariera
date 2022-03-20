using System;

namespace _6zadacha
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            double result = 0;
            int num1 = num / 100;
            int num2 = (num % 100) / 10;
            int num3 = num % 10;

            for (int i = 0; i < num1 + num2; i++)
            {
                for (int i1 = 0; i1 < num1 + num3; i1++)
                {
                    if (num % 5 == 0)
                    {

                        result = num - num1;
                        Console.Write(result + " ");
                        num -= num1;

                    }
                    else if (num % 3 == 0)
                    {

                        result = num - num2;
                        Console.Write(result + " ");
                        num -= num2;
                    }
                    else
                    {

                        result = num + num3;
                        Console.Write(result + " ");
                        num += num3;


                    }
                }
                Console.WriteLine();
            }
        }
    }
}
