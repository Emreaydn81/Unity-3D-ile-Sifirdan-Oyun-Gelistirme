namespace _16.List_Kullanımı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> sayilar = new List<int>();
            sayilar.Add(3);
            sayilar.Add(5);
            sayilar.Add(7);
            sayilar.Add(2);
            sayilar.Add(1);

            sayilar.Remove(3);
            sayilar.RemoveAt(0);
            int uzunluk = sayilar.Count;
         
            if(sayilar.Contains(1))
            {
                Console.WriteLine("Dizim 1 içeriyor. ");
            }
            Console.WriteLine(sayilar[1]);
            sayilar.Clear();
            Console.ReadLine();
        }
    }
}