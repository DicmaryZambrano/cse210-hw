using System;
using System.Collections.Generic;
using System.Text;

namespace Learning05
{
    public class Shape
    {
        private string _name;
        private string _color;
        public Shape(string color, string name)
        {
            _color = color;
            _name = name;
        }

        public string GetColor()
        {
            return _color;
        }

        public void SetColor(string color)
        {
            _color = color;
        }

        public string GetName()
        {
            return _name;
        }

        public void SetName(string name)
        {
            _name = name;
        }

        public virtual double GetArea()
        {
            double area = 0.5;
            return area;
        }
    }
}
