static void Main(string[] args)
        {
            Console.WriteLine("Boyunuzu girin (cm)");
            int cm = Convert.ToInt32(Console.ReadLine());
            float m = (float)cm / 100;

            Console.WriteLine("Kilonuzu girin (kg)");
            int kg = Convert.ToInt32(Console.ReadLine());

            float indeks = (float)kg / (m * m);
            Console.WriteLine("Vücut Kitle İndeksi : ");

            if (indeks < 18.5f)
            {
                Console.WriteLine("İdeal kilonun altında.");
            }
            if (indeks >= 18.5f && indeks < 25f)
            {
                Console.WriteLine("İdeal kiloda.");
            }
            if (indeks >= 25f && indeks < 29f)
            {
                Console.WriteLine("İdeal kilonun üstünde.");
            }
            if (indeks >= 30f && indeks < 35f)
            {
                Console.WriteLine("Obez.");
            }
            if (indeks > 35f)
            {
                Console.WriteLine("Aşırı Obez.");
            }

            Console.ReadKey();
        }
