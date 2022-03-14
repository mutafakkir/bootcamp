using System;
namespace lesson6
{
    public class Point
    {
        public int X { get; private set; }
        
        public int Y { get; private set; }
        
        public Point() : this(0, 0)  { }

        public Point(int x, int y)
        {
            Update(x, y);
        }

        public void Update(int x, int y)
        {
            X = x;
            Y = y;
        }

        public double DistanceTo(Point a) 
            => Math.Sqrt(Math.Pow(X - a.X, 2) + Math.Pow(Y - a.Y, 2));

        public static double Distance(Point a, Point b)
            => Math.Sqrt(Math.Pow(b.X - a.X, 2) + Math.Pow(b.Y - a.Y, 2));
    }
}