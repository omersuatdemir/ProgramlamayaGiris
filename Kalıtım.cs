namespace githubornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Araç bisiklet = new Araç();
            bisiklet.tekerSayısı = 2;
            bisiklet.üretimTarihi = 2020;
            Console.WriteLine(bisiklet.tekerSayısı + "\n" + bisiklet.üretimTarihi);

            Console.WriteLine("-----------------");

            Araba araba = new Araba();
            araba.tekerSayısı = 4;
            araba.üretimTarihi = 1978;
            araba.marka = "Toyota";
            araba.model = "Supra";
            Console.WriteLine(araba.tekerSayısı + "\n" + araba.üretimTarihi + "\n" +
                araba.marka + "\n" + araba.model);
        }
    }

    class Araç
    {
        public int tekerSayısı;
        public int üretimTarihi;
    }

    class Araba : Araç
    {
        public string marka;
        public string model;
    }
}
