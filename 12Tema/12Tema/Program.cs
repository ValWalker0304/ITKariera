using System;

namespace _12Tema
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==========Сумиране на числа==========");
            /*int n = int.Parse(Console.ReadLine());
            int sum = 0;
            do
            {
                sum = sum + (n % 10);
                n = n / 10;
            } while (n > 0);
            Console.WriteLine(sum);*/
            Console.WriteLine("==========Факториел==========");
            int n = int.Parse(Console.ReadLine());
            int sum = 1;
            do
            {
                sum = sum * 1;
                n--;
            } while (n > 1);
            Console.WriteLine(sum);
        }
    }
}
