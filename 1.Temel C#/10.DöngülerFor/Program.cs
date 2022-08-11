namespace _10.DöngülerFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //baslangıç - koşul - arttırma yada azaltma işlemi
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.ReadLine();

            //Soru 1) 1 - x arasındaki sayıları ekrana yazdırın. x kullanıcıdan alınacak
            //Console.WriteLine("Lütfen Bir Sayı Giriniz? ");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //for (int i = 1; i <= sayi; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.ReadLine();

            //Soru 2) 1000-1 arasındaki sayıları yazın.

            //for(int i =  1000; i >= 1; i--)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.ReadLine();

            //Soru 3) 1 ile 1000 Arası 3 e Bölünen Sayıları Yazdırınız.
            //for (int i = 1; i <= 1000; i++)
            //{
            //    if(i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.ReadLine();

            //Soru 4) 1 ile 1000 Arasında 5 e bölünen 11.Sayı
            int sayac = 0;
        for(int i = 1; i < 1000; i++)
            {
                if(i % 5 == 0)
                {
                    sayac++;
                    if(sayac == 11)
                    {
                        Console.WriteLine(i);
                        break;
                    }
                }

            }

            Console.ReadLine();
        }
    }
}