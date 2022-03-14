using System;

namespace OOP
{
    class Program
    {
        public static void Main()
        {
            Point a = new Point();
            Point b = new Point(2, 2);

            Console.WriteLine.($"{a.DistanceTo(b):0.00}");
        }
    }
}