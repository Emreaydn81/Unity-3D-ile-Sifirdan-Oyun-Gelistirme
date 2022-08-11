namespace Operatörler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // + - * /
            // ++ --
            // "emre" + "emir"
            // = -= += ...

            int sayi = 5;
            int sayi2 = 11;
            int toplam = sayi + sayi2;
            int fark = sayi - sayi2;
            int bolum = sayi / sayi2;
            int çarp = sayi * sayi2;
            float s1 = 18;
            float s2 = 5;
            float sonuc = s1 / s2;
            Console.WriteLine("toplam : " + toplam);
            Console.WriteLine("fark :" + fark);
            Console.WriteLine("bolum:" + bolum);
            Console.WriteLine("çarp :" + çarp);
            Console.WriteLine("sonuc : " + sonuc);

            int yenisayi = 1;
            // ++
            yenisayi++;
            ++yenisayi;
            Console.WriteLine(yenisayi);
            int azaltmasayısı = 5;
            azaltmasayısı--;
            azaltmasayısı--;
            Console.WriteLine(--azaltmasayısı);

            int sayi9 = 10;
            sayi9 += 10;
            //sayi9 = sayi9 + 10;
            Console.WriteLine("Sayi 9:" + sayi9);
            int sayii9 = 10;
            sayii9 -= 10;
            //sayi9 = sayi9 - 10;
            Console.WriteLine("Sayii 9:" + sayii9);

            string a = "Merhaba";
            string b = "Dünya";
            string metin = a + b;
            Console.WriteLine(metin);
            Console.ReadLine();

        }
    }
}