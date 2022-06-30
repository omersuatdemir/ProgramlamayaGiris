static void Main(string[] args)
        {
            int sayı = Convert.ToInt32(Console.ReadLine());

            switch (sayı)
            {
                case 5:
                    Console.WriteLine("Girdiğiniz sayı 5");
                    break;

                case 10:
                    Console.WriteLine("Girdiğiniz sayı 10");
                    break;

                case 15:
                    Console.WriteLine("Girdiğiniz sayı 15");
                    break;
                default:
                    Console.WriteLine("Girdiğiniz sayı listede yok.");
                    break;
            }

            Console.ReadKey();
        }
