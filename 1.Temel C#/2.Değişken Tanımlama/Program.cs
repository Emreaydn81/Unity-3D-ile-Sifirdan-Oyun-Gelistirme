namespace Değişken_Tanımlama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int - tam sayılar
              long -tam sayılar
              float - Kayan nokta sayıları
              double - virgüllü sayılar
               decimal - para tipleri
               char - tek bir karakter için
               bool - var yada yok
               DateTime - Zaman
               String - Metin
            */

            int sayi = 3;
            long sayi2 = 95;
            float virgullu = 3.5f;
            double virgullu2 =  5.24;
            decimal para = 2.222M;
            char karakter = 'a';
            bool sayivarmi = false;
            DateTime tarih = DateTime.Now;
            String metin = "Merhaba Dünya!";
            string metin2;
            metin2 = "Merhaba Düzce ! ";
            int s1 = 3, s2 = 4, s3 = 2, s4 = 7;

            Console.WriteLine(metin);
            Console.WriteLine(karakter);
            Console.WriteLine(virgullu);
            Console.WriteLine(s1);
            Console.ReadLine();
        }
    }
}