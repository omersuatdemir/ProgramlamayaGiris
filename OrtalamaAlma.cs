static void Main(string[] args)
        {
            int s1 = 50, s2 = 55, s3 = 60;
            float ortalama = (((float)s1 + (float)s2 + (float)s3) / 3);
            bool kontrol = ortalama >= 50;

            if (kontrol)
            {
                Console.WriteLine("Geçer");
            }
            else
            {
                Console.WriteLine("Kalır");
            }

            Console.ReadKey();
        }
