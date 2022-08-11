namespace Tip_Dönüşümleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi = 5;
            long buyuksayi = 9;
            long sayi3 = sayi;
            int sayi5 = (int)buyuksayi;

            //String
            string a = "3";
            string b = "9";

            //Convert
            int toplam = Convert.ToInt32(a) + Convert.ToInt32(b);
            Console.WriteLine(a + b);
            Console.WriteLine(toplam);
            Console.ReadLine();
        }
    }
}