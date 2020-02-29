using System;
using System.Drawing;
using System.Linq;

namespace ShapesDemoExample.Objects
{
    public class Triangle : IShape
    {
        public Point Point1 { get; }
        public Point Point2 { get; }
        public Point Point3 { get; }

        public double Side1 { get; }
        public double Side2 { get; }
        public double Side3 { get; }

        public Triangle(Point point1, Point point2, Point point3)
        {
            Point1 = point1;
            Point2 = point2;
            Point3 = point3;

            var sides = GetSides(point1, point2, point3);

            Side1 = sides[0];
            Side2 = sides[1];
            Side3 = sides[2];
        }

        public double GetShapeArea()
        {
            return GetShapeArea(Side1, Side2, Side3);
        }

        public static double GetShapeArea(Point point1, Point point2, Point point3)
        {
            var sides = GetSides(point1, point2, point3);

            return GetShapeArea(sides[0], sides[1], sides[2]);
        }

        public static double GetShapeArea(double side1, double side2, double side3)
        {
            if (!IsTriangleExist(side1, side2, side3))
                return 0;

            var p = GetPerimeter(side1, side2, side3) / 2;

            return Math.Sqrt(p * (p - side1) * (p - side2) * (p - side3));
        }

        public double GetPerimeter()
        {
            return GetPerimeter(Side1, Side2, Side3);
        }

        public static double GetPerimeter(Point point1, Point point2, Point point3)
        {
            var sides = GetSides(point1, point2, point3);

            return GetPerimeter(sides[0], sides[1], sides[2]);
        }

        public static double GetPerimeter(double side1, double side2, double side3)
        {
            if (!IsTriangleExist(side1, side2, side3))
                return 0;

            return side1 + side2 + side3;
        }

        public bool IsTriangleExist()
        {
            return IsTriangleExist(Side1, Side2, Side3);
        }

        public static bool IsTriangleExist(Point point1, Point point2, Point point3)
        {
            var sides = GetSides(point1, point2, point3);

            return IsTriangleExist(sides[0], sides[1], sides[2]);
        }

        public static bool IsTriangleExist(double side1, double side2, double side3)
        {
            var sides = new double[] { side1, side2, side3 }.OrderByDescending(x => x).ToArray();

            return sides[0] < sides[1] + sides[2];
        }

        public bool IsRightTriangle()
        {
            return IsRightTriangle(Side1, Side2, Side3);
        }

        public static bool IsRightTriangle(Point point1, Point point2, Point point3)
        {
            var sides = GetSides(point1, point2, point3);

            return IsRightTriangle(sides[0], sides[1], sides[2]);
        }

        public static bool IsRightTriangle(double side1, double side2, double side3)
        {
            if (!IsTriangleExist(side1, side2, side3))
                return false;

            var sides = new double[] { side1, side2, side3 }.OrderByDescending(x => x).ToArray();

            return Math.Round(Math.Pow(sides[0], 2), 2) == Math.Round(Math.Pow(sides[1], 2), 2) + Math.Round(Math.Pow(sides[2], 2), 2);
        }

        public static double[] GetSides(Point point1, Point point2, Point point3)
        {
            var side1 = Math.Sqrt(Math.Pow(point2.X - point1.X, 2) + Math.Pow(point2.Y - point1.Y, 2));
            var side2 = Math.Sqrt(Math.Pow(point3.X - point2.X, 2) + Math.Pow(point3.Y - point2.Y, 2));
            var side3 = Math.Sqrt(Math.Pow(point3.X - point1.X, 2) + Math.Pow(point3.Y - point1.Y, 2));

            return new[] { side1, side2, side3 };
        }
    }
}