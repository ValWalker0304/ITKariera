using System;

namespace vtora
{
    class Program
    {
        static void Main(string[] args)
        {
            double teniska = double.Parse(Console.ReadLine());
            double maxsum = double.Parse(Console.ReadLine());
            double shorti = teniska * 0.75;
            double chorap = shorti * 0.2;
            double butonki = (teniska + shorti) * 2;
            double obj = shorti + chorap + teniska + butonki;
            double obj2 = obj - (obj * 0.15);
            if (obj2 > maxsum)
            {
                Console.WriteLine("Yes, he will earn the world-cup replica ball!");
                Console.WriteLine("His sum is {0:f2} lv.",obj2);
            }
            else
            {
                Console.WriteLine("No, he will not earn the world-cup replica ball.");
                Console.WriteLine("He needs {0:f2} lv. more.",maxsum - obj2);
            }
        }
    }
}
