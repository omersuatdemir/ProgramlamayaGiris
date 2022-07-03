string asalSayilar = "";
            for (int i = 2; i <= 1000; i++)
            {
                bool kontrol = false;
                for (int j = 2; j < i; j++)
                {
                    if ((i % j) == 0)
                    {
                        kontrol = true;
                    }
                }
                if (!kontrol)
                {
                    asalSayilar += i + " ";
                }
            }

            foreach (string asal in asalSayilar.Split(' '))
            {
                Console.WriteLine(asal);
            }
