using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw6
{
    internal class Therapist : IDoctor
    {
        public void Treat()
        {
            Console.WriteLine("Therapist: вы здоровы, держите справку.");
        }
    }
}
