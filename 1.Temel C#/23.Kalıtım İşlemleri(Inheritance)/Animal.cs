using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.Kalıtım_İşlemleri_Inheritance_
{
    public class Animal
    {
        public int weight;
        public int length;
        public string name;

        public string GetProperties()
        {
            return String.Format("Name: {0} Length:{1} Weight:{2}", name, length, weight);
        }
    }
}
