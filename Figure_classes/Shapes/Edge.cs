namespace Figure_classes
{
    public sealed class Edge : Figure
    { 
        public Point FirstPoint { get; set; }
        public Point SecondPoint { get; set; }
        public new string FillColor { get; } = "чёрный";

        public Edge(int layer, string edgeColor, double edgeThickness, string fillColor, Point firstPoint, Point secondPoint) : base(layer, edgeColor, edgeThickness, fillColor)
        {
            FirstPoint = firstPoint;
            SecondPoint = secondPoint;
        }
    }
}