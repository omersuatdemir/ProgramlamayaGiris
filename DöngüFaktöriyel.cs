static void Main(string[] args)
        {
            int sayi, faktoriyel = 1;

            Console.WriteLine("Faktöriyel için sayı girin: ");
            sayi = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= sayi; i++)
            {
                faktoriyel *= i;
            }

            Console.WriteLine("Faktoriyeli: " + faktoriyel);

            Console.ReadKey();
        }
