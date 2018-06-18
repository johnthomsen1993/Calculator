using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorWPF.Model.Shapes._2DShapes
{
    public class Ellipse : ITwoDShape
    {
        private double RadiusA;
        private double RadiusB;

        public Ellipse(double radiusA, double radiusB)
        {
            RadiusA = radiusA;
            RadiusB = radiusB;
        }

        public double Area()
        {
                return RadiusA * RadiusB * Math.PI;
        }

        public double Perimeter()
        {
            var h = Math.Pow((RadiusA - RadiusB),2) / Math.Pow((RadiusA + RadiusB),2);
            return Math.PI * (RadiusA + RadiusB) * (1 + (3 * h) / (10 + Math.Sqrt(4 - 3 * h)));
        }
    }
}
