using System;

namespace DnevnaPe4lba
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double m = double.Parse(Console.ReadLine());
            double k = double.Parse(Console.ReadLine());
            double mesec = 0;
            double goddoh = 0;
            double danuk = 0;
            double chistdoh = 0;
            double srd = 0;
            if (n >= 5 && 30 >= n && m >= 10 && 2000 > m && k >= 0.99 && 1.99 >= k)
            {
                mesec = n * m;
                goddoh = mesec * 12 + mesec * 2.5;
                danuk = 0.25 * goddoh;
                chistdoh = goddoh - danuk;
                chistdoh = chistdoh * k;
                srd = chistdoh / 365;
                Console.WriteLine("{0:f2}", srd);
            }
            else Console.WriteLine("Invalid Course");
        }
    }
}
