using System;
using System.Collections.Generic;
using System.Text;

namespace Learning05
{
    public class Circle : Shape
    {
        private double _radious;

        public Circle(string color, string name, double radious) : base (color, name)
        {
            _radious = radious;
        }

        public override double GetArea()
        {
            double area =  Math.PI * (Math.Pow(_radious,2));

            return area;
        }
    }
}