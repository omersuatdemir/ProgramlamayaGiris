static void Main(string[] args)
        {
            int a = 10, b = 15;

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine(a);
            Console.WriteLine(b);

            Console.ReadKey();
        }
