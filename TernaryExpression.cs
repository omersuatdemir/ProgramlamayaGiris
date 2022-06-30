static void Main(string[] args)
        {
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("İki sayıdan büyük olanı: " + 
                ((sayi1 >= sayi2) ? sayi1 : sayi2));

            Console.ReadKey();
        }
