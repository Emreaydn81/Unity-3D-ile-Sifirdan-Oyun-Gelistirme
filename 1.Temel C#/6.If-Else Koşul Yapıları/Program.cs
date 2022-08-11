namespace If_Else_Koşul_Yapıları
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen Bir Sayı Giriniz? ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            if(sayi > 10)
            {
                Console.WriteLine("Sayı Ondan Büyüktür. ");
            }
            else if(sayi == 5)
            {
                Console.WriteLine("Sayı 5 e Eşittir");
            }
            else
            {
                Console.WriteLine("Sayı Ondan Küçük yada Eşittir.");
            }

           
            Console.ReadLine();
        }
    }
}