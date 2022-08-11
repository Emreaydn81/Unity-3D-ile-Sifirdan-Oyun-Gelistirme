namespace _19.Metodlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ToplamaYap(5,9));
            Console.WriteLine(ToplamaYap(88, 22));
            Console.WriteLine(KareAl(5));
            int sayiKare = 9;
            Console.WriteLine(KareAl(sayiKare));
            Console.WriteLine(KupAl(ref sayiKare));
            Console.ReadLine();

        }

        //Methodun Tanımı
        //MEtodun Gövdesi

        static int ToplamaYap(int sayi1,int sayi2)
        {
            return sayi1 + sayi2;
        }
        static int KareAl(int sayı)
        {
            return sayı * sayı;
        }
        static int KupAl(ref int sayi)
        {
           return sayi = sayi * sayi * sayi;
        }
        
            //ref

        int sayi = 5;
        int sayi2 = 9;
        string metin = "Ahmet Mehmet";
    }
}