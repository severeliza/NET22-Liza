using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOOP
{
    internal abstract class Car
    {
        int _gasoline;
        int _gasolinePerKm;
        public int _volume;

        protected Car(int strartGasoline, int volume, int gasolinePerKm) 
        {
            _gasoline = strartGasoline;
            _volume = volume;
            _gasolinePerKm = gasolinePerKm;
        }

        public void Drive(int distance)
        {
            if (_gasoline > distance * _gasolinePerKm)
            {
                Console.WriteLine("Движется");
            }
            else
            {
                Console.WriteLine("Стоит");
            }
        }

        public bool Refuel(int gasoline)
        {
            _gasoline = _volume;
            return true;
        }
    }
}
