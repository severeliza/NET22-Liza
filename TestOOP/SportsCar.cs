using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TestOOP
{
    internal class SportsCar : Car
    {
        public SportsCar(int strartGasoline) : base(strartGasoline, 10, 5)
        {
        }
    }
}
