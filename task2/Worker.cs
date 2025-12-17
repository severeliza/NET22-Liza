using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class Worker : IJob
    {
        public void PrintPosition()
        {
            System.Console.WriteLine("Position: Worker.");
        }
    }
}
