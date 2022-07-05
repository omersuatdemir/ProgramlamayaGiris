using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace githubornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Matematik.Pi);
            Console.WriteLine(Matematik.Minimum(15, 20));
            Console.WriteLine(Matematik.Maksimum(15,20));
            Console.WriteLine(Matematik.Üslü(2,4));
            Console.WriteLine(Matematik.Karekök(4));
            Console.WriteLine(Matematik.Faktöriyel(5));
            Console.WriteLine(Matematik.Fibonacci(7));
            Console.WriteLine(Matematik.Mutlak(-7));
            Console.WriteLine(Matematik.Yuvarla(3.52));

            Console.ReadKey();
        }
    }

    public class Matematik
    {
        public static double Pi = 3.1415926535897931;
        public static int Minimum(int x, int y)
        {
            if (x > y)
            {
                return y;
            }
            else
            {
                return x;
            }
        }
        public static int Maksimum(int x, int y)
        {
            if (x > y)
            {
                return x;
            }
            else
            {
                return y;
            }
        }
        public static int Üslü(int x, int y)
        {
            if (y == 0)
            {
                return 1;
            }
            else
            {
                int x1 = x;
                for (int i = 1; i < y; i++)
                {
                    x1 *= x;
                }
                return x1;
            }
        }
        public static double Karekök(int x)
        {
            double kök = 1;
            for (int i = 0; i != x + 1; i++)
            {
                kök = (x / kök + kök) / 2;
            }
            return kök;
        }
        public static int Mutlak(int x)
        {
            if (x < 0)
            {
                return x * -1;
            }
            else
            {
                return x;
            }
        }
        public static int Faktöriyel(int x)
        {
            int faktoriyel = 1;
            for (int i = 1; i <= x; i++)
            {
                faktoriyel *= i;
            }
            return faktoriyel;
        }
        public static int Fibonacci(int x)
        {
            if (x <= 1)
            {
                return x;
            }
            return Fibonacci(x - 1) + Fibonacci(x - 2);
        }
        public static int Yuvarla(double x)
        {
            if (x - (int)x >= 0.5)
            {
                return (int)x + 1;
            }
            else
            {
                return (int)x;
            }
        }
    }
}
