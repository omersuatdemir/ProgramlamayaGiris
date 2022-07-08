namespace githubornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Oluşturduğumuz sınıftan bir nesne türettik.
            Deneme deneme = new Deneme();

            //Değer atama ve okuma yapabiliyoruz.
            deneme.Deger1 = "Deneme1";
            Console.WriteLine(deneme.Deger1);

            //Değer okuma yapabiliyoruz.
            deneme.Deger2 = "Deneme2"; //Bu kod hata verecek
            Console.WriteLine(deneme.Deger2); //Boş değer yazdıracak

            //Değer atama yapabiliyoruz.
            deneme.Deger3 = "Deneme3";
            Console.WriteLine(deneme.Deger3); //Bu kod hata verecek

            Console.ReadLine();
        }
    }

    class Deneme
    {
        public string Deger1 { get; set; }
        public string Deger2 { get; }
        public string Deger3
        {
            set { Deger1 = value; }
        }
    }
}
