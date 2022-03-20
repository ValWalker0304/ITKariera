using System;

namespace Plod_nevalidno
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string p = Console.ReadLine();
            switch (p)
            {
                case "banana":Console.WriteLine("fruit");break;
                case "apple": Console.WriteLine("fruit"); break;
                case "kiwi": Console.WriteLine("fruit"); break;
                case "cherry": Console.WriteLine("fruit"); break;
                case "lemon": Console.WriteLine("fruit"); break;
                case "grape": Console.WriteLine("fruit"); break;
                case "tomato": Console.WriteLine("vegetable"); break;
                case "cucumber": Console.WriteLine("vegetable"); break;
                case "carrot": Console.WriteLine("vegetable"); break;
                case "pepper": Console.WriteLine("vegetable"); break;
                default: Console.WriteLine("Unknow"); break;
            }*/
            int a = int.Parse(Console.ReadLine());
            if (a >=100 && a<=200 || a == 0)
            {
                //Console.WriteLine("Числото е валидно");
            }
            else
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
