using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25.Interface
{
    internal interface IVehicle
    {
        void Run();
        void Stop();
        void Move(int speed);
        void Brake();
        int Gaslevel();
    }
}
