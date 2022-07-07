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
            Kedi tekir = new Kedi(4,"turuncu");
            Console.WriteLine(tekir.yas + " " + tekir.renk);
            tekir.renk = "gri";
            Console.WriteLine(tekir.renk);


            tekir.Miyavla();
            Kedi.Func1();

            Console.ReadKey();
        }
    }

    class Kedi
    {
        //Nesnelerin alabileceği alanlar.
        public int yas;
        public string renk;

        //Yapıcı Metot
        public Kedi(int yas, string renk)
        {
            Console.WriteLine("Yeni bir kedi oluşturuldu.");
            this.yas = yas;
            this.renk = renk;
        }

        //Sınıflarda fonksiyonlar tanımlanır, nesnelerin fonksiyonları metottur.

        //bu bir metottur
        public void Miyavla()
        {
            Console.WriteLine("Miyav!");
        }

        //bu bir fonksiyondur
        public static void Func1()
        {
            Console.WriteLine("Fonksiyon çağırıldı.");
        }
    }
}
