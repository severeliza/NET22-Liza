using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw6
{
    internal class Dentist : IDoctor
    {
        public void Treat()
        {
            Console.WriteLine("Dentist: вы здоровы, с вас 10000000000 денег.");
        }
    }
}
