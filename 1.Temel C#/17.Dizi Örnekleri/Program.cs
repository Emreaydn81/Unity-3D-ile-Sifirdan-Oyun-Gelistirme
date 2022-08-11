namespace _17.Dizi_Örnekleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Soru 1) Bir dizideki en küçük ve en büyük sayıları bulan kodu yazınız.

            //int[] dizi = new int[] { 5, 2, 6, -10, 9888, 20, 222, 13245, 1, 5, 6, 9 };
            // int enkucuk = dizi[0], enbuyuk = dizi[0];
            //for(int i = 0; i < dizi.Length; i ++)
            //{
            //    if(enkucuk > dizi[i])
            //    {
            //        enkucuk = dizi[i];
            //    }
            //    if(enbuyuk < dizi[i])
            //    {
            //        enbuyuk = dizi[i];
            //    }
            //}
            //Console.WriteLine("{0} En Büyük Eleman ve {1} en küçük elemandır. ", enbuyuk, enkucuk);
            //Console.ReadLine();

            //Soru 2) 10 elemanlı bir diziye 1-200 arasında rasgele sayılar atayın.
            //A - 100 den büyük sayıların sayısını bulun
            //B- 150 den küçük sayıların ortalamasını bulun
            //C - çift sayıların sayısını bulun

            //int[] sayilar = new int[10];
            //Random rnd = new Random();
            //for(int i = 0; i < sayilar.Length; i++)
            //{
            //    sayilar[i] = rnd.Next(1, 200);
            //    Console.Write(sayilar[i] + "\t");
            //}
            //Console.WriteLine();
            ////A
            //int sayac = 0;
            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    if (sayilar[i] > 100)
            //    {
            //        sayac++;

            //    }
            //}
            //Console.WriteLine("Yüzden büyük sayıların sayısı {0}", sayac);

            //B
            //ortalama = toplam / dizi uzunlugu

            //int ortalama, toplam = 0, sayacB = 0;
            //for(int i  = 0; i < sayilar.Length; i ++ )
            //{
            //    if (sayilar[i] < 150)
            //    {
            //        toplam += sayilar[i];
            //        sayacB++;
            //    }

            //}
            //ortalama = toplam / sayacB;
            //Console.WriteLine("150 den küçük sayıların ortalaması: {0}", ortalama);

            ////C
            //int ciftsayilarsayaci = 0;
            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    if (sayilar[i] % 2 == 0)
            //    {
            //        ciftsayilarsayaci++;
            //    }
            //}

            //Console.WriteLine("Çift Sayıların sayısı {0} dır.", ciftsayilarsayaci);
            //Console.ReadLine();

            //Soru 3) Girilen Kelimeyi harf harf alt alta yazdıran kodu yazın.
            //Console.WriteLine("Bir Metin Giriniz.");
            //string giris = Console.ReadLine();
            //foreach (char karakter in giris)
            //{
            //    Console.WriteLine(karakter);
            //}
            //Console.ReadLine();

            //Soru 4) Girilen bir metni tersten yazdıran uygulamayı yazın.
            Console.WriteLine("Bir Metin Giriniz.");
            string metin = Console.ReadLine();
            for (int i = metin.Length-1; i >= 0; i--)
            {
                Console.Write(metin[i]);
            }
            Console.WriteLine();

            Console.ReadLine();
            }
    }
}