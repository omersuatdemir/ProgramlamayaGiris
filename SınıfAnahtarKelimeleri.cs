using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace githubornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //String sınıfının oluşturma metodunun kullanımı
            String metin1 = new String(new char[] { 'M', 'e', 'r', 'h', 'a', 'b', 'a' });
            string metin2 = new String(new char[] { 'D', 'ü', 'n', 'y', 'a' });

            //Buradaki String ile normalde kullandığımız string arasında fark yok.
            String metin3 = "Merhaba";
            string metin4 = "Dünya";


            Console.WriteLine(metin1 + " " + metin2);
            Console.WriteLine(metin3 + " " + metin4);

            //aynı durum char sınıfı için de geçerli
            Char[] karakterler1 = new Char[5];
            Char[] karakterler2 = new char[5];
            char[] karakterler3 = new char[5];
            char[] karakterler4 = new Char[5];

            /*
            Tanımladığımız değişkenler aslında sınıflardan oluşuyor ve bazı anahtar kelimeler,
            kullanım kolaylığı veya estetik için sınıfların yerini bu şekilde alabiliyor.
            Örneğin int = System.Int32 
            
            Ama genel olarak, tanımlanan değişken ya da nesne üzerinde kod yazılırken
            "string" ve Sınıfın özellikleri üzerinde kod yazılıyorsa "String" kullanılır.
            Örneğin string isim = "Ömer" / String.Copy("Merhaba Dünya")
            Aslında bu iki kod da büyük küçük harflerle yazılabilir ama gelenek işte :)
            */

            Console.ReadKey();
        }
    }
}
