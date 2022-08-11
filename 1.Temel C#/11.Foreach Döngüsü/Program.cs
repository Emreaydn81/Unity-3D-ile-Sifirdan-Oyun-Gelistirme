namespace _11.Foreach_Döngüsü
{
    internal class Program
    {
        static void Main(string[] args)
        {;
            int[] sayilar = new int[] { 1, 2, 3, 4, 5, 9, 11, 15, 12, 2, 4, 5, 11, 2 };
            foreach (int sayi in sayilar)
            {
                Console.WriteLine(sayi);
            }
            Console.ReadLine();
        }
    }
}