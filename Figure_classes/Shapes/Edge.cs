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
        public override void Draw()
        {
            base.Draw();
            Console.WriteLine($"Прямая от точки (x, y) = ({FirstPoint.X_Position}, {FirstPoint.Y_Position}) до точки (x, y) = ({SecondPoint.X_Position}, {SecondPoint.Y_Position}).");
        }
    }
}