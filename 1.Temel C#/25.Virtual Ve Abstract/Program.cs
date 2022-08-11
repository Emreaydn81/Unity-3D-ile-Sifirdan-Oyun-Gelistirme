namespace Virtual_Ve_Abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat() { weight = 3, length = 5, name = "Pisi" };
            cat.length = 9;
            cat.runSpeed = 20;
            cat.sound = "Miyav !";
            Console.WriteLine(cat.GetProperties());

            Bird bird = new Bird() { length = 3, weight = 1, flyDistance = 2, flySpeed = 10, name = "Minik Kuş" };
            Console.WriteLine(bird.GetProperties());
            Console.ReadLine();
        }
    }
}