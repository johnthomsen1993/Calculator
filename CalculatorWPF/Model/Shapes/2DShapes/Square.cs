using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorWPF.Model.Shapes._2DShapes
{
    public class Square : ITwoDShape
    {
        private double Length;
        private double Heigth;

        public Square(double length, double heigth)
        {
            Length = length;
            Heigth = heigth;
        }

        public double Area()
        {
            return Length * Heigth;
        }

        public double Perimeter()
        {
            return Length + Length + Heigth + Heigth;
        }
    }
}
