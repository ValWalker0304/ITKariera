using System;

namespace ChetnaNechetna
{
    class Program
    {
        static void Main(string[] args)
        {
            /* int n = int.Parse(Console.ReadLine());
           double leftsum = 0;
           double rightsum = 0;

           for (int i = 0; i < n; i++)
           {
               leftsum += int.Parse(Console.ReadLine());
           }

           for (int i = 0; i < n; i++)
           {
               rightsum += int.Parse(Console.ReadLine());
           }

           if(leftsum == rightsum)
           {
               Console.WriteLine("Yes " + (leftsum + rightsum));
           }

           else
           {
               Console.WriteLine("No " + Math.Abs(leftsum - rightsum));
           } */

            int n = int.Parse(Console.ReadLine());
            double evensum = 0;
            double oddsum = 0;

            for (int i = 0; i < n; i++)
            {
                double num = double.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evensum += num;
                }
                else
                {
                    oddsum += num;
                }

            }

            if (evensum == oddsum)
            {
                Console.WriteLine("Sum = " + (evensum));
            }

            else
            {
                Console.WriteLine("No " + Math.Abs(evensum - oddsum));
            }



        }
    }
}
