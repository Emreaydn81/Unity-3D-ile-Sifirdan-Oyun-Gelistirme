namespace _21.Classlar_ile_Çalışmak
{
    internal class Program
    {
        public class Animal
        {
            public int weight;
            public string name;
            //0 = F / 1 = M

            public int gender;

            public string GetAnimalProperties()
            {
                //return "Weight :" + weight + "Name : " + name + "Gender: " + gender;
                return String.Format("Weight: {0} Name:{1} Gender:{2} ", weight, name, gender);
            }

            static void Main(string[] args)
            {
                Animal cat = new Animal();
                cat.name = "Pisicik";
                cat.weight = 4;
                cat.gender = 1;
                Console.WriteLine(cat.GetAnimalProperties());
                Animal bird = new Animal();
                bird.name = "Kanarya";
                bird.weight = 1;
                bird.gender = 0;
                Console.WriteLine(bird.GetAnimalProperties());
                Console.ReadLine();
            }
        }
    }
}