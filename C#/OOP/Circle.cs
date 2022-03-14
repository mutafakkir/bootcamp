using System;

namespace OOP
{
    public class Circle
    {
        public Point Center { get; set; }

        public int Radius { get; set; }

        public Circle() :
            this(new Point(), 0)
        {
        }

        public Circle(Point center, int radius)
        {
            Center = center;
            Radius = radius;
        }
    }
}
