namespace _13.Do_While_Döngüsü
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //    string kullanıcıAdı = "admin";
        //    string giris = "";
        //    do
        //    {
        //        Console.Clear();
        //        Console.WriteLine("Kullanıcı Adını Giriniz:");
        //        giris = Console.ReadLine();

        //    } while (giris != kullanıcıAdı);
        //    Console.WriteLine("Giriş Başarılı");
        //    Console.ReadLine();

        //Soru : Kullanıcı Klavyeden -1 yazana kadar sayı al ve ortalaması göster.
            int toplam = 0, ortalama = 0, sayac = 0, giris = 0;
            do
            {
                Console.WriteLine("Sayı giriniz ya da çıkmak için -1 e basınız.");
                giris = Convert.ToInt32(Console.ReadLine());
                if(giris != -1)
                 {
                    toplam += giris;
                    sayac++;
            
                 }
            }while (giris != -1);
             
             ortalama = toplam / sayac;
               Console.WriteLine("Ortalamanız: " + ortalama);

                 Console.ReadLine();
        }
    }
}