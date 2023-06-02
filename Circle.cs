using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Circle : Figure
    {
        public double r { get; }

        public Circle(double radius)
        {
            if (radius <= 0.0)
                throw new ArgumentException("Указаный радиус не является положительным числом");
            r = radius;
        }

        public override double GetArea()
        {
            return Math.PI * Math.Pow(r, 2);
        }
    }
}
