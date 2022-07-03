static void Main(string[] args)
        {
            string degisken = "Merhaba Dünya";

            //metindeki harfleri küçük yapar
            Console.WriteLine(degisken.ToLower());

            //metindeki harfleri büyük yapar
            Console.WriteLine(degisken.ToUpper());

            //seçilen metinleri değiştirir
            Console.WriteLine(degisken.Replace("Merhaba", "Selam"));

            //metnin girilen değeri içerip içermediğini kontrol eder
            Console.WriteLine(degisken.Contains("Dünya"));

            //içine girilen karakteri başta ve sonda varsa siler
            Console.WriteLine(degisken.Trim('a'));

            //içine girilen değerle başladığını kontrol eder
            Console.WriteLine(degisken.StartsWith("Merhaba"));

            //içine girilen değerle bittiğini kontrol eder
            Console.WriteLine(degisken.EndsWith("Dünya"));

            //ilk argüman indeks, indeksten sonraki 2. argüman kadar siler
            Console.WriteLine(degisken.Remove(0, 3));

            //Baştan başlar ve parametre kadar siler
            Console.WriteLine(degisken.Substring(2));

            //girilen karakterin ilk hangi sırada olduğunu döndürür
            Console.WriteLine(degisken.IndexOf('a'));

            //metnin karakterlerini char[] türünde bir diziye çevirir
            foreach (char x in degisken.ToCharArray())
            {
                Console.Write(x);
            }
            Console.WriteLine();

            //girilen karakterin arasında kalan metinleri diziye çevirir
            foreach (string x in degisken.Split(' '))
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();

            //string bir char[] dizisiymiş gibi davranılabilir
            Console.WriteLine(degisken[3]);

            foreach (char x in degisken)
            {
                Console.Write(x);
            }
            Console.WriteLine();

            //string'in uzunluğunu verir
            Console.WriteLine(degisken.Length);

            Console.ReadKey();
        }
