using System;



namespace _30_11_2021
{
    static class Arithmetic
    {
        public static int Min(int a, int b)
        {
            if (a < b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
        public static int Max(int a, int b)
        {
            return Math.Max(a, b);
        }
        public static double PowD(double x, int y)
        {
            return Math.Pow(x, y);
        }
        public static long Fib(int n)
        {
            long a = 0; long b = 1; long c = 0;
            for (int i = 0; i < n; i++)
            {
                if (i <= 1)
                {
                    c = i;
                }
                else
                {
                    c = a + b;
                    a = b;
                    b = c;
                }
               
            }
            return c;
        }
        public static int Fac(int n)
        {
            int num = n;
            for (int i = n - 1; i > 0; i--)
            {
                num = num * i;
            }
            return num;
        }
        public static int Fac1(int n)
        {
            int num = n;
            for (int i = 1; i <= n; i++)
            {
                num = num * i;
            }
            return num;
        }
    }
}
