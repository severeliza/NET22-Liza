using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw8
{
    internal class Сircle : Figure
    {
        public Point Center { get; private set; }
        public double R { get; private set; }

        public Сircle(Point point, double r) : this (point)
        {
            if (r > 0)
            {
                R = r;
            }
        }

        public Сircle(Point point)
        {
            Center = point;
            R = 0;
        }

        public Сircle()
        {
            Center = new Point();
            R = 0;
        }


        public override double GetArea()
        {
            return Math.PI * R * R;

        }

        public override double GetPerimeter()
        {
            return Math.PI * R * 2; 
        }
    }
}
