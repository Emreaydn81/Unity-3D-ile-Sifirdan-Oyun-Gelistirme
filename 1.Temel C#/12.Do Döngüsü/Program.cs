namespace _12.Do_Döngüsü
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1)
            //int sayi = 9;
            //while(sayi > 5)
            //{
            //    Console.WriteLine("Sayı 5 Ten Büyüktür. ");
            //}

            //Console.ReadLine();

            //2)
            //int sayi = 9;
            //while (sayi > 5)
            //{
            //    Console.WriteLine("Sayı 5 Ten Büyüktür. ");
            //    sayi--;
            //}

            //Console.ReadLine();

            //Soru1: 1-X Arasındaki Sayıları Ekrana Yazdırın.

            //Console.WriteLine("Bir Sayı Griniz: ");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //int sayac = 1;
            //while(sayac <= sayi)
            //{
            //    Console.WriteLine(sayac);
            //    sayac++;
            //}
            //Console.ReadLine();

            //Soru 2: 10000 - X arasındaki sayıları yazdırınız.
            //Console.WriteLine("Lütfen Bir Sayı Giriniz: ");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //int sayac = 10000;
            //while(sayac >= sayi)
            //{
            //    Console.WriteLine(sayac);
            //    sayac--;
            //}
            //Console.ReadLine();

            //Soru 3) 1 den 1000 e kadar olan tek sayıların karelerini yazdırınız.
            int sayac = 1;
            while(sayac < 1000)
            {
                if(sayac % 2 == 1 )
                {
                    Console.WriteLine(sayac * sayac);
                }
                sayac++;
            }
            Console.ReadLine();
        }
      
    }
        
  }
