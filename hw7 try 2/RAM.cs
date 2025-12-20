using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw7_try_2
{
    internal class RAM
    {
        private string name;
        private int capacity;

        public RAM(string name, int capacity)
        { 
            this.name = name;
            this.capacity = capacity;
        }

        public RAM()
        {
            this.name = "unknown";
            this.capacity = 0;
        }

        public void Info()
        {
            Console.WriteLine($"RAM: Name - {name}, capacity - {capacity}");
        }
    }
}
