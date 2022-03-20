using System;
using System.Threading.Tasks;

namespace Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int days = int.Parse(Console.ReadLine());
            int l = 7;
            int treated = 0;
            int untreated = 0;
            int treateda = 0;
            int untreateda = 0;
            for (int i = 0; i < days; i++)
            {
                int patients = int.Parse(Console.ReadLine());
                if (i % 2 == 0 && untreateda > treateda)
                {
                    l++;
                }
                untreated = patients - l;
                if (untreated < 0)
                {
                    untreated = 0;
                }
                Math.Abs(untreateda = untreateda + untreated);
                Math.Abs(treated = patients - untreated);
                Math.Abs(treateda = treateda + treated);

            }
            Console.WriteLine("Treated patients: " + treateda);
            Console.WriteLine("Untreated patients: " + untreateda);
            //Console.WriteLine("Doctors: " + l);
            Console.WriteLine("Ако резултата е грешен един от лекарите е притърпял инцидент");*/











            int n = int.Parse(Console.ReadLine());
            int l = 7;
            int atherHos = 0;
            int cure = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && atherHos > cure)
                {
                    l++;
                }
                int patie = int.Parse(Console.ReadLine());
                if (patie <= l)
                {
                    cure += patie;
                }
                else
                {
                    cure += l;
                    atherHos += patie - l;
                }
            }
            Console.WriteLine("Izlekuvani:" + cure);
            Console.WriteLine("Ne iz:" + atherHos);
        }
    }
}

