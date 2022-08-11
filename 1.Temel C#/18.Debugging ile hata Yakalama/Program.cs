namespace _18.Debugging_ile_hata_Yakalama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 3;
            i++;
            int x = 5;
            x++;
            int toplam = i + x;
            int toplam2 = 0;
            for(int y = 0; y < 1000; y++)
            {
                toplam2 += y;
                Console.Write(y);
            }
            Console.WriteLine(toplam);
            Console.ReadLine();
        }
    }
}