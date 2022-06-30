static void Main(string[] args)
        {
            int sayı = Convert.ToInt32(Console.ReadLine());

            if (sayı > 50)
            {
                Console.WriteLine("Girilen sayı 50 den büyük.");
            }
            else
            {
                if (sayı < 50)
                {
                    Console.WriteLine("Girilen sayı 50 den küçük.");
                }
                else
                {
                    Console.WriteLine("Girilen sayı 50'ye eşit.");
                }
            }

            Console.ReadKey();
        }
