using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculationLibrary.Classes
{
    public class Circle : Shape
    {
        private const double PI = Math.PI;

        private double Radius;

        /// <summary>
        /// Метод для инициализации радиуса круга
        /// </summary>
        /// <param name="radius">Радиус</param>
        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public override double GetArea()
        {
            return PI * Math.Pow(Radius, 2);
        }

        public override double GetPerimeter()
        {
            return 2 * PI * Radius;
        }
    }
}
