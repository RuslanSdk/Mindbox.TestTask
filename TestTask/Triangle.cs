using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask
{
    /// <summary>
	/// Треугольник
	/// </summary>
	public class Triangle : Figure
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public Triangle(double a, double b, double c)
        {
            if (a < 0 || b < 0 || c < 0)
                throw new ArgumentException("Длина не может быть отрицательной");

            if (!((a + b) > c &&
                (a + c) > b &&
                (b + c) > a))
                throw new ArgumentException("У треугольника сумма любых двух сторон " +
                    "должна быть больше третьей");

            SideA = a;
            SideB = b;
            SideC = c;
        }

        public override double GetArea()
        {
            //Полупериметр
            var halfP = (SideA + SideB + SideC) / 2;

            return Math.Sqrt(halfP *
                (halfP - SideA) *
                (halfP - SideB) *
                (halfP - SideC));
        }

        /// <summary>
        /// Является ли треугольник прямоугольным
        /// </summary>
        /// <returns></returns>
        public bool IsRectangular()
		{
            double[] sides = { SideA, SideB, SideC };

            Array.Sort(sides);
            Array.Reverse(sides);

            if (Math.Pow(sides[0], 2) == Math.Pow(sides[1], 2) + Math.Pow(sides[2], 2))
                return true;

            return false;
		}
    }
}
