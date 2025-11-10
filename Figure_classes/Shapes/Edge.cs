namespace Figure_classes
{
    public sealed class Edge : Figure
    { 
        public Point FirstPoint { get; set; }
        public Point SecondPoint { get; set; }
        public new string FillColor { get; } = "чёрный";
    }
}