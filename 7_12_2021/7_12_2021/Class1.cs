using System;
using System.Collections.Generic;
using System.Text;

namespace _7_12_2021
{
    class CustomMath
    {
        public static int Factorial(int x)
        {

            int i;
            for (i = x - 1; i > 0; i--)
            {
                x = x * i;
            }
            return x;
        }

        public static int Combinations(int n, int k)
        {
            if (n <= 1)
                return 1;
            return Factorial(n) / (Factorial(k) * Factorial(n - k));
        }


    }
}
