namespace _8.İF_Örnekleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1)Tek çift bulan programı yazınız - veri kullanıcıdan alınıcak
            //Console.WriteLine("Lütfen bir sayı Giriniz? ");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //bool çiftmi;

            //// %
            //if (sayi % 2 == 0)
            //{
            //    çiftmi = true;
            //}
            //else
            //{
            //    çiftmi = false;
            //}

            //if (çiftmi == true)
            //{
            //    Console.WriteLine("Sayı Çifttir. ");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı Tektir. ");
            //}
            //Console.ReadLine();

            //2)İle Göre Gezi Rehberi Programı Yapınız
            //Lütfen Bir il Seçiniz a- Ankara b-İstanbul c- Erzurum , d- Kastamonu
            //Console.WriteLine("Merhaba ! Lütfen bi il seçiniz. \n  a- Ankara b-İstanbul c- Erzurum  d- Kastamonu");
            //string secim = Console.ReadLine();
            //if(secim == "a")
            //{
            //    Console.WriteLine("Atakuleyi Gezmeyi Unutmayın. ");
            //}
            //else if(secim == "b")
            //{
            //    Console.WriteLine("Adalara Gitmeyi Unutmayın.");
            //}
            //else if(secim == "c")
            //{
            //    Console.WriteLine("Erxurum Soğuk Olabilir.Kalın Giyinin.");
            //}
            //else if(secim == "d")
            //{
            //    Console.WriteLine("Etli Ekmek Yemeyi Unutmayınız.");
            //}
            //else
            //{
            //    Console.WriteLine("Lütfen Giriş Yapınız.");

            //}
            //Console.ReadLine();

            //3)Klavyeden Girilen 3 Sayının en Küçüğünü bulan programı yazınız?

            //int sayi1, sayi2, sayi3;
            //Console.WriteLine("Sayı 1: ");
            //sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Sayı 2: ");
            //sayi2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Sayı 3: ");
            //sayi3 = Convert.ToInt32(Console.ReadLine());

            //if(sayi1 <= sayi2 && sayi1 <= sayi3)
            //{
            //    Console.WriteLine("Sayı 1 En Küçüktür. ");
            //}
            //else if(sayi2 <= sayi1 && sayi2 <= sayi3)
            //{
            //    Console.WriteLine("Sayı 2 En Küçüktür. ");
            //}
            //else if(sayi3 <= sayi1 && sayi3 <= sayi2)
            //{
            //    Console.WriteLine("Sayı 3 En Küçüktür. ");
            //}
            //Console.ReadLine();

            /*4)Bir Üçgende, İki Kenarın toplam uzunluğu, üçüncü kenardan az olamaz.
             * Ayrıca iki kenarın birbirinden farkının mutlak degeri,
             * üçüncü kenardan büyük olmamalıdır.
             * Bu bilgileri kullanarak, verilen üç kenar uzunluğuna göre bir üçgen çizilip çizilemeyecegini
             * gösteren programı yazınız.
             * Not= Girilecek kenar uzunlukları tam sayı olacaktır.
              */

            // |b - c| < a < b + c

            //int a, b, c;
            //Console.WriteLine("A Kenarını Giriniz: ");
            //a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("B Kenarını Giriniz: ");
            //b = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("C Kenarını Giriniz: ");
            //c = Convert.ToInt32(Console.ReadLine());

            //int toplam = b + c, mutlakFark;
            //if(b-c < 0)
            //{
            //    mutlakFark = (b - c) * -1;
            //}
            //else
            //{
            //    mutlakFark = b - c;
            //}
            //if(mutlakFark < a && a < toplam)
            //{
            //    Console.WriteLine("Üçgen Çizilebilir. ");

            //}
            //else
            //{
            //    Console.WriteLine("Üçgen Çizilemez. ");
            //}
            //Console.ReadLine();

            //5) 10 dan Küçük sayıların tek çift oldugunu söyleyen.Olmayanların ise karesini söyleyen programı yazınız.
            Console.WriteLine("Bir Sayı Girin: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            if(sayi < 10)
            {
                if(sayi % 2 == 0)
                {
                    Console.WriteLine("Sayı 10 dan küçük ve çifttir. ");
                }
                else
                {
                    Console.WriteLine("Sayı 10 dan küçüktür ve tektir. ");
                }
            }
            else
            {
                Console.WriteLine("Sayının karesi:" + sayi * sayi);
            }
            Console.ReadLine();

        }
    }
}