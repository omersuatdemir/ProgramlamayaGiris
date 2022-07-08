static void Main(string[] args)
        {
            //Bu tür dönüşümleriyle iligli detaylı bilgi için.
            //https://code-maze.com/csharp-intparse-vs-convert-toint32/

            //integer (int / Int32) sınıfının bir fonksiyonu ile de tür dönüşümü yapılabilir.
            int deger1 = int.Parse(Console.ReadLine());
            Console.WriteLine(deger1);

            //Parse fonksiyonunun farklı bir kullanımı
            Console.WriteLine(Char.Parse("A"));

            //Farklı sınıflarda parse fonksiyonu bulunur.

            Console.ReadLine();
        }
