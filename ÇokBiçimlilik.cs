namespace githubornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Araç araç = new Araç();
            araç.İlerle();

            Araba araba = new Araba();
            araba.İlerle();

            Console.ReadKey();
        }
    }

    class Araç
    {
        public void İlerle()
        {
            Console.WriteLine("Araç ilerliyor...");
        }
    }

    class Araba : Araç
    {
        public void İlerle()
        {
            Console.WriteLine("Araba ilerliyor...");
        }
    }
}
