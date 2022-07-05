static void Main(string[] args)
        {
            string metin = "Merhaba Dünya";
            string tersMetin = "";
            for (int i = metin.Length - 1; i >= 0; i--)
            {
                tersMetin += metin[i];
            }
            Console.WriteLine(tersMetin);

            Console.ReadKey();
        }
