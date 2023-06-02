using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Triangle : Figure
    {
        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }

        private double HalfCirc;

        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
                throw new ArgumentException("Указанные стороны не являются положительными числа");

            else if (sideA + sideB < sideC || sideB + sideC < sideA || sideA + sideC < sideB)
                throw new ArgumentException("Из указанных сторон невозможно образовать треугольник");

            SideA = sideA;
            SideB = sideB;
            SideC = sideC;

            HalfCirc = (sideA + sideB + sideC) / 2;

        }

        public override double GetArea()
        {
            return Math.Sqrt(HalfCirc * (HalfCirc - SideA) * (HalfCirc - SideB) * (HalfCirc - SideC));
        }

        public bool IsRightAngled()
        {
            var sides = new double[3] { SideA, SideB, SideC };
            Array.Sort(sides);

            return (Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) - Math.Pow(sides[2], 2) == 0);
        }
    }
}