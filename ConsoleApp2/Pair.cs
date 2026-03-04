using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Pair<S, T>
    {
        public S? Item1 { get; }
        public T? Item2 { get; }

        public Pair(S Item1, T Item2)
        {
            this.Item1 = Item1;
            this.Item2 = Item2;
        }

    }
}
