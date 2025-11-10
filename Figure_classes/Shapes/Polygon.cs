namespace Figure_classes
{
    public sealed class Polygon : Figure
    { 
        public List<Point> Points { get; set; }

        public Polygon(int layer, string edgeColor, double edgeThickness, string fillColor, List<Point> points) : base(layer, edgeColor, edgeThickness, fillColor)
        {
            Points = points;
        }
    }
}