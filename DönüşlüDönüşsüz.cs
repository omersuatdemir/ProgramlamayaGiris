internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Dönüşlü());
            Dönüşsüz();

            Console.ReadKey();
        }

        static string Dönüşlü()
        {
            return "Merhaba Dünya!";
        }

        static void Dönüşsüz()
        {
            Console.WriteLine("Merhaba Dünya!");
        }
    }
