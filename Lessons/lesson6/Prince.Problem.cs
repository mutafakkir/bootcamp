using System;
using System.Linq;

namespace lesson6
{
    public partial class Prince
    {
        public int Travel()
        {
            int count = 0;
            var points = getIntArray();

            Start = new Point(points[0], points[1]);
            End = new Point(points[2], points[3]);

            var planets = int.Parse(Console.ReadLine());
            while(planets-->0)
            {
                var p = getIntArray();
                var planet = new Circle(p[2], new Point(p[0], p[1]));

                if(Crosses(planet))
                {
                    count++;
                }
            }

            return count;
        }

        private int[] getIntArray() 
            =>  Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(p => int.Parse(p))
                .ToArray();
    }
}