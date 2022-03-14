namespace lesson6
{
    public class Circle
    {
        public double Radius { get; set; }
        
        public Point Center { get; set; }
        
        public Circle()
            : this(0, new Point()) { }

        public Circle(double radius, Point center)
        {   
            Radius = radius;
            Center = center;
        }

        public bool Contains(Point x)
        {
            var distanceToCenter = Point.Distance(Center, x);
            return distanceToCenter < Radius;
        }

        public static bool ContainsPoint(Circle c, Point x)
        {
            var distanceToCenter = Point.Distance(c.Center, x);
            return distanceToCenter < c.Radius;
        }
    }
}