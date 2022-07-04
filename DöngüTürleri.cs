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
            for (int i1 = 1; i1 <= 10; i1++)
            {
                Console.WriteLine(i1);
            }

            int i2 = 1;
            while (i2 <= 10)
            {
                Console.WriteLine(i2);
                i2++;
            }

            int i3 = 1;
            do
            {
                Console.WriteLine(i3);
                i3++;
            }
            while (i3 <= 10);

            Console.ReadKey();
        }
    }
}
