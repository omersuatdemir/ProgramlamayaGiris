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
            OzyineliDongu(10);

            Console.ReadKey();
        }

        static void OzyineliDongu(int x)
        {
            if (x == 0)
            {

            }
            else
            {
                Console.WriteLine(x);
                OzyineliDongu(x-1);
            }
        }
    }
}
