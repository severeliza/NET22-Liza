using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw8
{
    internal class Triangle : Figure
    {
        public Triangle(double[] coordinates)
        {
            Points = new Point[3];

            if (coordinates.Length == 6)
            {
                Points[0] = new Point(coordinates[0], coordinates[1]);
                Points[1] = new Point(coordinates[2], coordinates[3]);
                Points[2] = new Point(coordinates[4], coordinates[5]);
            }
        }

        public Triangle(Point[] points)
        {
            if (points.Length == 3)
            {
                Points = points;
            }
            else
            {
                Points = new Point[3];
            }
        }

        public Triangle() 
        { 
            Points = new Point[3];
        }

        public override double GetArea()
        {
            return Math.Abs((Points[0].X * (Points[1].Y - Points[2].Y)
                + Points[1].X * (Points[2].Y - Points[0].Y)
                + Points[2].X * (Points[0].Y - Points[1].Y)) / 2);

        }

        public override double GetPerimeter()
        {
            return Point.Distance(Points[0], Points[1])
                + Point.Distance(Points[1], Points[2])
                + Point.Distance(Points[2], Points[0]);
        }
    }
}
