using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.Kalıtım_İşlemleri_Inheritance_
{
    public class Cat : Animal
    {
        public int runSpeed;
        public string sound;
        
        public string GetProperties()
        {
            string animalProperties = base.GetProperties();
            string catProperties = String.Format("Run Speed: {0} Sound:{1}", runSpeed, sound);
            return animalProperties + catProperties ; 
        }
    }
}
