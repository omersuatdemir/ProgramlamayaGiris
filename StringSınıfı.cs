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


            Console.ReadKey();
        }
