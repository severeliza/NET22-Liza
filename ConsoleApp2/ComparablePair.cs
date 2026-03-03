using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp2
{
    internal class ComparablePair<T, U> : IComparable<ComparablePair<T, U>>
        where T : IComparable<T>                                        
        where U : IComparable<U>
    {
        public T Item1 { get; }
        public U Item2 { get; }

        public ComparablePair(T Item1, U Item2)
        {
            this.Item1 = Item1;
            this.Item2 = Item2;
        }

        public int CompareTo(ComparablePair<T, U> pair)
        {
            return Item1.CompareTo(pair.Item1) == 0 ? Item2.CompareTo(pair.Item2) : -1;
        }

        public override string ToString()
        {
            return Item1 + " : " + Item2;
        }
    }
}
