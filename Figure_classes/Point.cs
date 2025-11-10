namespace Figure_classes
{
    public class Point
    {
        public double X_Position { get; set; }
        public double Y_Position { get; set; }

        public Point(double x, double y)
        {
            this.X_Position = x;
            this.Y_Position = y;
        }

        public Point()
        {

        }
    }
}