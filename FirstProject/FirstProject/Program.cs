using System;
using System.ComponentModel;
using System.Globalization;
using System.Threading;

namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string t = " ";
            for (int i = 0; i < 20; i++)
            {
                t += "*";
                Console.WriteLine(t);
            }
            
        }
    }
}
