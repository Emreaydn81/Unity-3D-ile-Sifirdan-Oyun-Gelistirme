namespace _7.Switch_Case_Koşul_Yapıları
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi = 2;
            switch(sayi)
            {
                case 1:
                    Console.WriteLine("Sayı 1 dir. ");
                    break;
                case 2:
                    Console.WriteLine("Sayı 2 dir. ");
                    goto case 3;
                    break;
                case 3:
                    Console.WriteLine("Sayı 3 dür. ");
                    break;
                default:
                    Console.WriteLine("Sayı 1 yada 2 değildir. ");
                    break;
            }
            Console.ReadLine();
        }
    }
}