using System;
using Learning05;

class Program
{
    static void Main(string[] args)
    {
        Circle circle = new Circle("Blue", "Circle", 5.2);
        Square square = new Square("Pink", "Square", 12);
        Rectangle rectangle = new Rectangle("Green", "Rectangle", 15, 10);

        Shape[] shapes = {circle,square, rectangle};

        foreach (Shape shape in shapes)
        {
            double area = shape.GetArea();
            string color = shape.GetColor();
            string name = shape.GetName();

            Console.WriteLine($"the area of the {color} {name} is: {area}.");
        }
    }
}