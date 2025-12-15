using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw6
{
    internal class Surgeon : IDoctor
    {
        public void Treat()
        {
            Console.WriteLine("Surgeon: вы успешно прооперированны.");
        }
    }
}
