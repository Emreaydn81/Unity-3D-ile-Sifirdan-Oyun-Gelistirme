namespace _20.Metod_Örnekleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    // Soru 1) İki Sayıyı Toplayan Fonksiyonu yazınız.kullanıcıdan alıncak.
            //    int sayi1, sayi2;
            //    int toplam;
            //    Console.WriteLine("Sayı 1: ");
            //    sayi1 =Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Sayı 2: ");
            //    sayi2 = Convert.ToInt32(Console.ReadLine());
            //    toplam = Topla(sayi1, sayi2);
            //    Console.WriteLine(toplam);
            //    Console.ReadLine();


            //}
            //static int Topla(int sayi1,int sayi2)
            //{
            //    return sayi2 + sayi1;
            //}
            //Soru 2)Verilen Ölçülerdeki Karenin Alanını hesaplayan fonksiyonu yazın.
            //    Console.WriteLine("Karenin bir kenarını yazın: ");
            //    int kenar = Convert.ToInt32(Console.ReadLine());
            //    int alan = KareAlaniHesapla(kenar);
            //    Console.WriteLine("Karenin Alanı: " + alan);
            //    Console.ReadLine();
            //}
            //static int KareAlaniHesapla(int aKenari)
            //{
            //    return aKenari * aKenari;
            //}

            //Soru 3) Kare,Üçgen Ve Daire Seçilecek bunun alanı hesaplanacak
            // a * a
            // h * taban / 2
            // pi * r * r

            //    Console.WriteLine("Alan Hesaplamak İstediginiz Şekili seçin: 1-Kare 2-Üçgen 3-Daire");
            //    int secim = Convert.ToInt32(Console.ReadLine());
            //    switch(secim)
            //    {
            //        case 1:
            //            Console.WriteLine("Lütfen a kenarı giriniz: ");
            //            int a = Convert.ToInt32(Console.ReadLine());
            //            int alan = KareAlaniHesapla(a);
            //            Console.WriteLine("Karenin Alani {0} dır.", alan);
            //            break;
            //        case 2:
            //            Console.WriteLine("Tabanı Girin:");
            //            int taban = Convert.ToInt32(Console.ReadLine());
            //            Console.WriteLine("Yüksekliği Girin: ");
            //            int yükseklik = Convert.ToInt32(Console.ReadLine());
            //            int alanucgen = UcgenAlaniHesapla(taban, yükseklik);
            //            Console.WriteLine("Üçgenin Alanı: {0}", alanucgen);
            //            break;
            //        case 3:
            //            Console.WriteLine("r degeri giriniz: ");
            //            int r = Convert.ToInt32(Console.ReadLine());
            //            double alanDaire = DaireAlaniHesapla(r);
            //            Console.WriteLine("Dairenin Alanı {0} :", alanDaire );
            //            break;
            //        default:

            //            Console.WriteLine("Yanlış Seçim Yaptınız.");
            //            break;
            //    }
            //    Console.ReadLine();

            //}
            //static double DaireAlaniHesapla(double yariCap)
            //{
            //    return yariCap * yariCap * Math.PI;
            //}

            //static int UcgenAlaniHesapla(int taban, int yükseklik)
            //{
            //    return taban * yükseklik / 2;
            //}

            //static int KareAlaniHesapla(int aKenari)
            //{
            //    return aKenari * aKenari;
            //}

            //Soru 4) Metin İçerisinde Kaç Cümle Bulan Kodu Yazınız.

            //    Console.WriteLine("Bir Cümle Giriniz: ");
            //    string metin = Console.ReadLine();
            //    int kelimeSayisi = kelimeSayisiBul(metin);
            //    Console.WriteLine("Cümledeki kelime sayısı: {0} ", kelimeSayisi);
            //    Console.ReadLine();


            //}
            //private static int kelimeSayisiBul(string metin)
            //{
            //    int sayac = 1;
            //    //boşlukları say her boşlukta sayacı arttır.
            //    foreach (char karakter in metin)
            //    {
            //        if (karakter == ' ')
            //        {
            //            sayac++;
            //        }
            //    }
            //    return sayac;
            //}

            //Params

            int toplam2 = Topla(3, 4, 6, 3);
            Console.WriteLine(toplam2);
            Console.ReadLine();
            

        }

        static int Topla(params int[] sayi)
        {
            int toplam = 0;
            for(int i = 0; i < sayi.Length; i++)
            {
                toplam += sayi[i];
            }
            return toplam;
        }
     

    }
 }
