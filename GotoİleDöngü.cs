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
            int i = 0;
            donguBasi:
            if (i <= 10)
            {
                Console.WriteLine(i);
                i++;
                goto donguBasi;
            }

            Console.ReadKey();
        }
    }
}
