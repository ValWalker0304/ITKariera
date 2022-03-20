using System;

namespace _2zadacha
{
    class Program
    {
        static void Main(string[] args)
        {
            int holidays = int.Parse(Console.ReadLine());
            int rabotni_dni = 365 - holidays;
            int galq_kotkata = (rabotni_dni * 63) + (holidays * 127);
            int razlika = 30000 - galq_kotkata;
            int minut = Math.Abs(razlika % 60);
            int chas =Math.Abs(razlika / 60);
            if (30000 - razlika > 0)
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine(chas + " hours and " + minut + " minutes more for play");
            }
            else if (30000 - razlika < 0)
            {
                Console.WriteLine("Tom runs away");
                Console.WriteLine(chas + " hours and " + minut + " minutes less for play");
            }

        }
    }
}
