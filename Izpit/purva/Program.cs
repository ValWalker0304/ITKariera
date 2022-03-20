using System;

namespace purva
{
    class Program
    {
        static void Main(string[] args)
        {
            double qlv = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double p = double.Parse(Console.ReadLine());
            double m = double.Parse(Console.ReadLine());
            double qkg = double.Parse(Console.ReadLine());
            double cenamalina = qlv / 2;
            double cenaportokal = cenamalina - 0.4 * cenamalina;
            double cenabanan = cenamalina - 0.8 * cenamalina;
            double sumaq = qkg * qlv;
            double sumap = p * cenaportokal;
            double sumam = m * cenamalina;
            double sumb = cenabanan * b;
            Console.WriteLine("{0}", sumb + sumam + sumap + sumaq);
        }
    }
}
