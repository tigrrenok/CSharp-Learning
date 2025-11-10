namespace Figure_classes
{
    public sealed class Circle : Figure
    {
        public double Radius { get; set; }
        public Point Center { get; set; }


        public Circle(int layer, string edgeColor, double edgeThickness, string fillColor, Point center, double radius) : base (layer, edgeColor, edgeThickness, fillColor)
        {
            Radius = radius;
            Center = center;
        }
    }
}