namespace _15.Diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[10];
            //Deger Verme
            sayilar[0] = 45;
            sayilar[1] = 15;
            sayilar[9] = 55;

            //string[] isimler = new string[3];
            string[] isimler = { "Ayse", "Emre", "Emir" };
            Console.WriteLine(isimler.Length);
            //

            Console.WriteLine(sayilar[0]);
            Console.ReadLine();
        }
    }
}