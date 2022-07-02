static void Main(string[] args)
        {
            Ornek(10);
            Ornek("deneme");

            Console.ReadKey();
        }

        static void Ornek(int x)
        {
            Console.WriteLine(1);
        }

        static void Ornek(string x)
        {
            Console.WriteLine(2);
        }
