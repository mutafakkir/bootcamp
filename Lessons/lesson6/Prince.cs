namespace lesson6
{
    public partial class Prince
    {
        public Point Start { get; set; }
        
        public Point End { get; set; }
        
        public Prince() : this(new Point(), new Point()) { }

        public Prince(Point start, Point end)
        {
            Start = start;
            End = end;
        }

        public bool Crosses(Circle planet)
        {
            var startIsIn = planet.Contains(Start);
            var endIsIn = planet.Contains(End);

            return startIsIn != endIsIn;
        }
    }
}