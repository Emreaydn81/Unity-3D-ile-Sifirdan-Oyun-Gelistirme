namespace _22.Encapsulation
{
    internal class Program
    {
        public class Rectange
        {
           
            private int _a;

            private int _b;
            public int a 
            {
                get { return _a; } 
                set
                {
                    if (value < 0)
                    {
                        _a = 0;
                    }
                    else
                    {
                        _a = value;
                    }
                }
             }
            public int b 
            {
                get { return _b; }
                set
                {
                    if(value < 0)
                    {
                        _b = 0;
                    }
                    else
                    {
                        _b = value;
                    }
                }
            }
           
            public int CalculateArea()
            {
                return _a * _b;
            }

            static void Main(string[] args)
            {
                Rectange rectange = new Rectange();
                rectange.a = -1;
                rectange.b = 55;
                Console.WriteLine(rectange.CalculateArea());
                Console.ReadLine();

            }
        }
    }
}