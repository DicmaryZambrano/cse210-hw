using System;
using System.Collections.Generic;
using System.Text;

namespace Learning05
{
    public class Square : Shape
    {
        private double _side;

        public Square(string color, string name, float side) : base (color, name)
        {
            _side = side;
        }

        public override double GetArea()
        {
            double area = Math.Pow(_side,2);

            return area;
        }
    }
}