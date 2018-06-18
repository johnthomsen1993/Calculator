using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorWPF.Model.Shapes._2DShapes
{
    public class Circle : ITwoDShape
    {
        private double Radius;

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Area()
        {
            return Radius*Radius * Math.PI;
        }

        public double Perimeter()
        {
            return 2 * Radius * Math.PI;
        }
    }
}
