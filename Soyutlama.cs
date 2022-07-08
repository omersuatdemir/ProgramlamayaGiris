namespace githubornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Araba araba = new Araba();
            araba.İlerle();

            Bisiklet bisiklet = new Bisiklet();
            bisiklet.İlerle();

            Console.ReadKey();
        }
    }

    abstract class Araç
    {
        public abstract void İlerle();
    }

    class Araba : Araç
    {
        public override void İlerle()
        {
            Console.WriteLine("Araba ilerliyor...");
        }
    }
    class Bisiklet : Araç
    {
        public override void İlerle()
        {
            Console.WriteLine("Bisiklet ilerliyor...");
        }
    }
}
