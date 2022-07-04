internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Faktöryel(5));

            Console.ReadKey();
        }

        static int Faktöryel(int x)
        {
            if (x == 0 || x == 1)
            {
                return 1;
            }

            return x * Faktöryel(x - 1);
        }

    }
