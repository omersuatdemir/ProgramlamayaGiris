static void Main(string[] args)
        {
            int ondalikSayi = Convert.ToInt32(Console.ReadLine());
            int kalan;
            //String.Empty değeri "" değerine eşittir, kullanımı görün diye yazdım.
            string ikilikSayi = String.Empty;

            while (ondalikSayi > 0)
            {
                kalan = ondalikSayi % 2;
                ondalikSayi /= 2;
                ikilikSayi = kalan.ToString() + ikilikSayi;
            }
            Console.WriteLine(ikilikSayi);

            Console.ReadKey();
        }
