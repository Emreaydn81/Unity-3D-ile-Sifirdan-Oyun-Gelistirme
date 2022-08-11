namespace Uygulama1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ekrandan Kullanıcının girdisini alma
           // string girdi = Console.ReadLine();

            //int sayi;
            //Console.WriteLine("Merhaba !  Lütfen Bir Sayı Giriniz:");
            //string girdi = Console.ReadLine();
            //sayi = Convert.ToInt32(girdi);
            //Console.WriteLine(sayi + 2);
            //Console.ReadLine();
           
            
            //1.Kullanıcıdan Alınan Sayının Karesini Hesaplayan Uygulmayaı Yazın?

            //int sayi;
            //Console.WriteLine("Merhaba !  Lütfen Bir Sayı Giriniz:");
            //string girdi = Console.ReadLine();
            //sayi = Convert.ToInt32(girdi);
            //int kare = sayi * sayi;
            //Console.WriteLine("Sayının Karesi : " + kare);
            //Console.ReadLine();

            //2.Toplama Uygulaması
            //Ekrandan girilen 2 sayıyı toplayan uygulamayı yazınız?

            //int s1, s2;
            //Console.WriteLine("1 Sayıyı Giriniz.");
            //string giris1 = Console.ReadLine();
            //Console.WriteLine("2 Sayıyı Giriniz.");
            //string giris2 = Console.ReadLine();


            //int toplam = Convert.ToInt32(giris1) + Convert.ToInt32(giris2);
            //Console.WriteLine("Toplam : " + toplam);
            //Console.ReadLine();



            //3.Tasarruf Hesaplayıcı
            //Kaç Ampul? Kaç Saat?
            //Normal Ampul satte 2TL
            //Tasarruflu ise %20
            //Çıktı olarak Normal Ampul Faturası , Tasarruflu Fatura

            int ampulsayisi, saat;
            float fiyat = 2;

            Console.WriteLine("Tasarruf Hesaplama Programına Hosgeldiniz \n Lütfen Kaç Ampul Kullandıgınızı Yazınız?");
            ampulsayisi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kaç Saat Kullanıyorsunuz ? ");
            saat = Convert.ToInt32(Console.ReadLine());

            float faturatutarı = ampulsayisi * saat * fiyat;
            float tasarruflututar = faturatutarı * 80 / 100;
            Console.WriteLine("Normal Ampul Tutarı : " + faturatutarı);
            Console.WriteLine("Tasarruflu Tutar : " + tasarruflututar);
            Console.ReadLine();
        }
    }
}