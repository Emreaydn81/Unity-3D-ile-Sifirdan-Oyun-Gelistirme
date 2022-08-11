namespace _14.Döngü_Örnekleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Soru 1:  X  den y ye kadar olan çift sayıların toplamı bulan
             * bir program yazınız.
             * x ve ye tek ya da çift olabilir.
            // */
            //int x, y;
            //Console.WriteLine("Başlangıç Sayısını girin: ");
            //x = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Bitiş Sayısını Girin. ");
            //y = Convert.ToInt32(Console.ReadLine());
            //int toplam = 0 ;
            //for (int i = x; i <= y; i++)
            //{
            //    if(i % 2 == 0)
            //    {
            //        toplam += i;
            //    }
            //}
            //Console.WriteLine("Toplam : " + toplam);

            //Soru 2: Üst Hesaplayan Programı Yazınız.

            //int taban, ust;
            //Console.WriteLine("Lütfen taban sayısını giriniz: ");
            //taban = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Lütfen ust sayısını giriniz: ");
            //ust = Convert.ToInt32(Console.ReadLine());

            //int sonuc = taban;
            //for (int i = 1; i < ust; i++)
            //{
            //    sonuc *= taban;
            //}
            //Console.WriteLine("Sonuç : " + sonuc);
            //Console.ReadLine();

            //Soru 3:  Faktöriyel Hesaplayan Programı Yazınız.
            //5! - 5 x 4 x 3 x 2 x 1
            //Console.WriteLine("Faktöriyel Hesaplanacak sayıyı yazınız: ");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //int sonuc = 1;
            //for (int i  = 2; i <= sayi; i++)
            //{
            //    sonuc *= i;
            //}
            //Console.WriteLine(sonuc);
            //Console.ReadLine();

            //Soru 4: Tuttugum tahmin etmeye çalışan ve 3 hak veren programı yazınız.
            //Random rnd = new Random();
            //int tutulansayı = rnd.Next(1, 10);
            //int tahmin;
            //bool dogrubildi = false;
            //int i = 0;
            //for ( i = 0; i < 3; i++)
            //{
            //    Console.WriteLine("Tahmininizi Giriniz: ");
            //    tahmin = Convert.ToInt32(Console.ReadLine());
            //    if(tahmin == tutulansayı)
            //    {
            //        dogrubildi = true;
            //        break;
            //    }
            //}
            //if(dogrubildi)
            //{
            //    Console.WriteLine(i + "Dogru Bildiniz. ");
            //}
            //else
            //{
            //    Console.WriteLine("Dogru Bilemediniz. ");
            //}
            //Console.ReadLine();

            //Soru 5 : Girilen Bir Sayının 2 sayının karesi toplamı şeklinde yazılıp yazılamayacagını bulan programı yazınız.
            //8 = 2*2 + 2*2
            Console.WriteLine("Lütfen Bir sayı giriniz : ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            bool bulunduMu = false;
            for ( int i = 0; i < sayi; i++)
            {
                for(int x = 0; x < sayi; x++)
                {
                    if(i * i + x * x == sayi)
                    {
                        bulunduMu = true;
                        Console.WriteLine(i + "*" + i + "+" +  x + "*" + x + "Şeklinde Yazılabilir. ");
                    }
                }
            }
            if(!bulunduMu)
            {
                Console.WriteLine("Bu sayı iki sayının karesi şeklinde yazılamaz.");
            }
            Console.ReadLine();
        }
    }
}