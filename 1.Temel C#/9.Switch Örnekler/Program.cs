namespace _9.Switch_Örnekler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1) Kullanıcıdan haftanın gününü alıp hava tahmini gösteren programı yazınız.
             * pazartesi
             */
            //Console.WriteLine("Lütfen Gün Giriniz? ");
            //string gun = Console.ReadLine();
            //switch(gun)
            //{
            //    case "Pazartesi":
            //        Console.WriteLine("0 Derece");
            //        break;
            //    case "Salı":
            //        Console.WriteLine("1 Derece");
            //        break;
            //    case "Çarşamba":
            //        Console.WriteLine("2 Derece");
            //        break;
            //    case "Perşembe":
            //        Console.WriteLine("3 Derece");
            //        break;
            //    case "Cuma":
            //        Console.WriteLine("4 Derece");
            //        break;
            //    default:
            //        Console.WriteLine("Buğün İçin Tahmin Bulunmamaktadır.");
            //        break;

            /* 2)Switch Case ile bir hesap makinesi yapınız.
             * Kullanıcıdan 2 sayı alınacak
             * İşlem Sorulacak ve Sonuç gösterilecek
             */

            int sayi1, sayi2;
            Console.WriteLine("Sayı 1 Giriniz ? ");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sayı 2 Giriniz ? ");
            sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen İşlem işaretini giriniz. + - / *");
            string islem = Console.ReadLine();

            switch(islem)
            {
                case "+":
                    Console.WriteLine(sayi1 + sayi2);
                    break;
                case "-":
                    Console.WriteLine(sayi1 - sayi2);
                    break;
                case "*":
                    Console.WriteLine(sayi1 * sayi2);
                    break;
                case "/":
                    Console.WriteLine(sayi1 / sayi2);
                    break;

                default:
                    Console.WriteLine("Lütfen Doğru Giriniz.");
                    break;
            }
            Console.ReadLine();
         }
      }
   }
