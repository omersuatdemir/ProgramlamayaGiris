using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dersler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Müşteri müşteri1 = new Müşteri("Ömer Suat",1234,20,Müşteri.HesapTürü.Kişisel);
            müşteri1.ParaYatır(500);
            Müşteri müşteri2 = new Müşteri("Ahmet Mehmet",4321,20,Müşteri.HesapTürü.Şirket);
            müşteri1.ParaAktarımı(200, müşteri2);
            Müşteri.FaizHesapla(müşteri1);
            Müşteri.FaizHesapla(müşteri2);

            Console.ReadKey();
        }
    }
    class Müşteri
    {
        private static double faizOranı = 25d / 100d; //0.25 ile aynı şey
        public enum HesapTürü
        {
            Kişisel,
            Şirket
        }
        private string isim;
        public string Isim { get { return isim; } }
        private int hesapNo;
        public int HesapNo { get { return hesapNo; } }
        public int yas;
        private int bakiye;
        public int Bakiye { get { return bakiye; } }
        public Müşteri(string isim, int hesapNo, int yas, HesapTürü hesapTürü)
        {
            this.isim = isim;
            this.hesapNo = hesapNo;
            this.yas = yas;

            Console.WriteLine(isim + "adlı müşterinin " + hesapNo + " numaralı hesabı açıldı.");
        }
        public void ParaYatır(int miktar)
        {
            bakiye += miktar;
            Console.WriteLine(hesapNo + " numaralı hesaba " + miktar + "TL yatırıldı.");
        }
        public void ParaÇek(int miktar)
        {
            bakiye -= miktar;
            Console.WriteLine(hesapNo + " numaralı hesabından " + miktar + "TL çekildi.");
        }

        public void ParaAktarımı(int miktar, Müşteri alıcı)
        {
            bakiye -= miktar;
            alıcı.bakiye += miktar;
            Console.WriteLine($"{hesapNo} numaralı hesaptan {alıcı.hesapNo} numaralı" +
                $" hesaba {miktar}TL gönderildi.\nGönderenin güncel bakiyesi: " +
                $"{bakiye}\nAlıcının güncel bakiyesi: {alıcı.bakiye}");
        }

        public static void FaizHesapla(Müşteri müşteri)
        {
            double sonuc = (müşteri.bakiye * faizOranı) + müşteri.bakiye;
            Console.WriteLine($"Müşterinin güncel bakiyesi: {müşteri.bakiye}\n" +
                $"Bir yıl sonraki bakiyesi: {sonuc}");
        }
    }
}
