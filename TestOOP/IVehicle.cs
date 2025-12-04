using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOOP
{
    internal interface IVehicle
    {
        void Drive(int distance);
        bool Refuel(int gasoline);
    }
}
