using System;
using System.Dynamic;
using System.Linq;

namespace ElementNaSuma
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] m = new int[n];
            bool isTrue = true;
            for (int i = 0; i < n; i++)
            {
                int g = int.Parse(Console.ReadLine());
                int k = int.Parse(Console.ReadLine());
                m[i] = g + k;
            }
            for (int i = 0; i < m.Length - 1; i++)
            {
                if (m[i] == m[i + 1])
                {

                }
                else
                {
                    isTrue = false;
                    break;
                }
            }
            if (isTrue == false)
            {
                Console.WriteLine("No, Diff = " + (m.Max() - m.Min()));
            }
            else
            {
                Console.WriteLine("Yes, Sum = " + m[0]);
            }




            /*for (int i = 0; i < n; i++)
            {
                int a  i = int.Parse(Console.ReadLine());
            }
            int suma = 0;
            int sumb = 0;
            int sumc = 0;
            if (suma == sumb && sumc == n && sumc == sumb)                             
            {
                Console.WriteLine("Yes,value = " + n);
            }
            else
            {
                int x =Math.Max(suma, sumb);
                int y = Math.Max(sumb, sumc);
                int r = Math.Max(x, y);
                Console.WriteLine("No,maxdiff = " + r);
            }*/

            /*Console.Write("n = ");
            var n = int.Parse(Console.ReadLine());
            var max = 0;
            var sum1 = 0;
            for (var i = 1; i <= n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                sum1 += num;
                if (num > max)
                    max = num;
            }
            if (sum1 - max == max)
            {
                Console.WriteLine("Yes ", "Sum = " + max);
            }

            else
            {
                Console.WriteLine("No ", "Diff = " + (max - Math.Abs(sum1 - max)));
            }*/



        }
    }
}
