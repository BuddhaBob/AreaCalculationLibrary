using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculationLibrary.Classes
{
    public class Triangle : Shape
    {
        private double SideA;

        private double SideB;

        private double SideC;


        /// <summary>
        /// Метод для инициализации сторон треугольника
        /// </summary>
        /// <param name="sideA">Сторона А</param>
        /// <param name="sideB">Сторона В</param>
        /// <param name="sideC">Сторона С</param>
        public Triangle(double sideA, double sideB, double sideC)
        {
            this.SideA = sideA;
            this.SideB = sideB;
            this.SideC = sideC;
        }

        public bool IsRightTriangle()
        {
            double greatesSide = Math.Max(SideA, Math.Max(SideB, SideC));

            if (greatesSide == SideA)
            {
                return (SideA == Math.Sqrt(Math.Pow(SideB, 2) + Math.Pow(SideC, 2)) ? true : false);
            }
            else if (greatesSide == SideB)
            {
                return (SideB == Math.Sqrt(Math.Pow(SideA, 2) + Math.Pow(SideC, 2)) ? true : false);
            }
            else if (greatesSide == SideC)
            {
                return (SideC == Math.Sqrt(Math.Pow(SideB, 2) + Math.Pow(SideA, 2)) ? true : false);
            }

            return false;
        }

        public override double GetArea()
        {
            double halfPerimeter = GetPerimeter() / 2;
            
            return Math.Sqrt(halfPerimeter * (halfPerimeter - SideA) * (halfPerimeter - SideB) * (halfPerimeter - SideC));
        }

        public override double GetPerimeter()
        {
            return SideA + SideB + SideC;
        }
    }
}
