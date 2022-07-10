static void Main(string[] args)
        {
            for (int i = 2; i <= 1000; i++)
            {
                bool kontrol = false;
                for (int j = 2; j < i; j++)
                {
                    if ((i % j) == 0)
                    {
                        kontrol = true;
                    }
                }
                if (!kontrol)
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadKey();
        }
