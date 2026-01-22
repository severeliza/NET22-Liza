using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    internal interface IDocument
    {
        public int DocumentNumber { get; }
        public DateOnly DocumentDate { get; }

        public void PrintDocument();
    }
}
