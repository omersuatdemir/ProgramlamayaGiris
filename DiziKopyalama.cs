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
            int[] dizi1 = new int[] { 1, 2, 3, 4, 5 };

            int[] dizi2 = new int[dizi1.Length];

            // dizi1 dizisini dizi2 ye kopyalıyoruz
            dizi1.CopyTo(dizi2, 0);

            foreach (int x in dizi2)
            {
                Console.WriteLine(x);
            }

            Console.ReadKey();
        }
    }
}
