using System;

namespace ShapesDemoExample.Objects
{
    public class Circle : IShape
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double GetShapeArea()
        {
            return GetShapeArea(Radius);
        }

        public static double GetShapeArea(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public double GetPerimeter()
        {
            return GetPerimeter(Radius);
        }

        public static double GetPerimeter(double radius)
        {
            return 2 * Math.PI * radius;
        }
    }
}