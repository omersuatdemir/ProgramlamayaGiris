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
        
            //bu kodlar bölünebilirliğin algoritmalarıdır, bunların yerine direkt olarak x % y == 0 olarak kontrol edebilirsiniz.


            //sayıyı kullanıcıdan alıyoruz
            int sayı = Convert.ToInt32(Console.ReadLine());

            //sayının son rakamını buluyoruz
            int sonRakam = Convert.ToInt32(sayı.ToString()[sayı.ToString().Length - 1]);

            //sayının rakamlarının toplamını buluyoruz
            int rakamlartoplami = 0;
            foreach (char rakam in sayı.ToString())
            {
                rakamlartoplami += Convert.ToInt32(rakam.ToString());
            }

            //2 ile bölünürlüğünü kontrol etme
            if (sonRakam % 2 == 0)
            {
                Console.WriteLine(sayı + " 2'ye bölünebilir.");
            }
            else
            {
                Console.WriteLine(sayı + " 2'ye bölünemez.");
            }

            //3 ile bölünürlüğünü kontrol etme
            if (rakamlartoplami % 3 == 0)
            {
                Console.WriteLine(sayı + " 3'e bölünebilir.");
            }
            else
            {
                Console.WriteLine(sayı + " 3'e bölünemez.");
            }

            //4 ile bölünürlüğünü kontrol etme
            if (Convert.ToInt32(sayı.ToString().Length) >= 2)
            {
                if (((Convert.ToInt32(sayı.ToString()[sayı.ToString().Length - 2])) * 10)
                + sonRakam % 4 == 0)
                {
                    Console.WriteLine(sayı + " 4'e bölünebilir.");
                }
                else
                {
                    Console.WriteLine(sayı + " 4'e bölünemez.");
                }
            }
            else
            {
                if (sonRakam % 4 == 0)
                {
                    Console.WriteLine(sayı + " 4'e bölünebilir.");
                }
                else
                {
                    Console.WriteLine(sayı + " 4'e bölünemez.");
                }
            }

            //5 ile bölünürlüğünü kontrol etme
            if (sonRakam == 0 || sonRakam == 5)
            {
                Console.WriteLine(sayı + " 5'e bölünebilir.");
            }
            else
            {
                Console.WriteLine(sayı + " 5'e bölünemez.");
            }

            //6 ile bölünürlüğünü kontrol etme
            if (sayı % 3 == 0 && sayı % 2 == 0)
            {
                Console.WriteLine(sayı + " 6'ya bölünebilir.");
            }
            else
            {
                Console.WriteLine(sayı + " 6'ya bölünemez.");
            }

            //8 ile bölünürlüğünü kontrol etme
            if (sayı.ToString().Length >= 3)
            {
                if (((((Convert.ToInt32(sayı.ToString()[sayı.ToString().Length - 3]))) * 100) +
                    ((Convert.ToInt32(sayı.ToString()[sayı.ToString().Length - 2])) * 10) +
                    sonRakam) % 8 == 0)
                {
                    Console.WriteLine(sayı + " 8'e bölünebilir.");
                }
                else
                {
                    Console.WriteLine(sayı + " 8'e bölünemez.");
                }
            }
            else
            {
                if (sayı.ToString().Length == 2)
                {
                    if (((Convert.ToInt32(sayı.ToString()[sayı.ToString().Length - 2])) * 10) + sonRakam % 8 == 0)
                    {
                        Console.WriteLine(sayı + " 8'e bölünebilir.");
                    }
                    else
                    {
                        Console.WriteLine(sayı + " 8'e bölünemez.");
                    }
                }
                else
                {
                    if (sayı == 8 || sayı == 0)
                    {
                        Console.WriteLine(sayı + " 8'e bölünebilir.");
                    }
                    else
                    {
                        Console.WriteLine(sayı + " 8'e bölünemez.");
                    }
                }
            }

            //9 ile bölünürlüğünü kontrol etme
            if (rakamlartoplami % 9 == 0)
            {
                Console.WriteLine(sayı + " 9'a bölünebilir.");
            }
            else
            {
                Console.WriteLine(sayı + " 9'a bölünemez.");
            }

            //10 ile bölünürlüğünü kontrol etme
            if (sonRakam == 0)
            {
                Console.WriteLine(sayı + " 10'a bölünebilir.");
            }
            else
            {
                Console.WriteLine(sayı + " 10'a bölünemez.");
            }

            //11 ile bölünürlüğünü kontrol etme
            if (sayı.ToString().Length >= 2)
            {
                Console.WriteLine("----------");

                int artılılar = 0;
                for (int i = sayı.ToString().Length - 1; i >= 0; i -= 2)
                {
                    artılılar += Convert.ToInt32(Convert.ToString(sayı.ToString()[i]));
                }

                int eksililer = 0;
                for (int i = sayı.ToString().Length - 2; i >= 0; i -= 2)
                {
                    eksililer += Convert.ToInt32(Convert.ToString(sayı.ToString()[i]));
                }

                if ((Convert.ToInt32(artılılar) 
                    - Convert.ToInt32(eksililer)) % 11 == 0)
                {
                    Console.WriteLine(sayı + " 11'e bölünebilir.");
                }
                else
                {
                    Console.WriteLine(sayı + " 11'e bölünemez.");
                }
            }
            else
            {
                if (sayı == 11 || sayı == 0)
                {
                    Console.WriteLine(sayı + " 11'e bölünebilir.");
                }
                else
                {
                    Console.WriteLine(sayı + " 11'e bölünemez.");
                }
            }

            Console.ReadKey();
        }
    }
}
