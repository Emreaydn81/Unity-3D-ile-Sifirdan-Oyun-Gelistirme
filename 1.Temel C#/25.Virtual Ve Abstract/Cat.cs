using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_Ve_Abstract
{
    public class Cat : Animal
    {
        public int runSpeed;
        public string sound;

        public string GetProperties()
        {
            string animalProperties = base.GetProperties();
            string catProperties = String.Format("Run Speed: {0} Sound:{1}", runSpeed, sound);
            return animalProperties + catProperties;
        }

        public override void Move()
        {
            throw new NotImplementedException();
        }
        public virtual void Sleep()
        {
            energy += 2;
        }
    }
}
