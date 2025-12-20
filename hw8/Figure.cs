using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw8
{
    internal abstract class Figure
    {
        protected Point[] Points { get; set; }

        public abstract double GetArea();
        public abstract double GetPerimeter();
    }

}
