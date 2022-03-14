using System;

namespace OOP
{
    public class Point
    {
        public int X { get; set; }

        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public Point() :
            this(0, 0)
        {
        }

        public double DistanceTo(Point b) =>
            Math.Sqrt(Math.Pow(X - b.X, 2) + Math.Pow(Y - b.Y, 2));
    }
}
