static void Main(string[] args)
        {
            int sayi1 = 3;
            float sayi2 = 3.14f;
            double sayi3 = 3.1d;
            char karakter = 'A';
            string isim = "Ömer";
            bool deger = true;

            //Aritmetik Operatörler
            Console.WriteLine(sayi1 + sayi2); //toplar
            Console.WriteLine(sayi1 - sayi2); //çıkarır
            Console.WriteLine(sayi1 * sayi2); //çarpar
            Console.WriteLine(sayi1 / sayi2); //böler
            Console.WriteLine(sayi1 % sayi2); //bölümünden kalanı verir

            //Mantıksal Operatörler
            Console.WriteLine(true || false); //veya operatörü
            Console.WriteLine(true && true); //ve operatörü
            Console.WriteLine(!deger); //çevirici

            //Koşul Operatörleri
            Console.WriteLine(5 == 10); //eşitse
            Console.WriteLine(5 != 10); //eşit değilse
            Console.WriteLine(5 < 10); //küçükse
            Console.WriteLine(5 <= 10); //küçük eşitse
            Console.WriteLine(5 > 10); //büyükse
            Console.WriteLine(5 >= 10); //büyük eşitse

            //String Birleştirme Operatörü
            Console.WriteLine(isim + karakter);

            //Atama Operatörleri
            sayi2 = (float)sayi3; //atama
            sayi3 += sayi1; //sayi3 = sayi3 + sayi1 
            sayi3 -= sayi1; //sayi3 = sayi3 - sayi1 
            sayi1 *= (int)sayi2; //sayi1 = sayi1 * sayi2
            sayi1 /= (int)sayi2; //sayi1 = sayi1 / sayi2
            sayi1 %= (int)sayi2; //sayi1 = sayi1 % sayi2

            //Arttırma - Azaltma Operatörleri
            sayi1++; //sayi1 = sayi1 + 1 => sayi1 += 1
            sayi1--; //sayi1 = sayi1 - 1 => sayi1 -= 1


            Console.ReadLine();
        }
