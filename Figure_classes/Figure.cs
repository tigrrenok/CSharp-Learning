namespace Figure_classes
{
    public class Figure
    {
        public string EdgeColor { get; set; } = "чёрный";
        public int Layer { get; set; }
        public double EdgeThickness { get; set; } = 1;
        public string FillColor { get; set; } = "белый";

        public Figure(int layer, string edgeColor, double edgeThickness, string fillColor)
        {
            Layer = layer;
            EdgeColor = edgeColor;
            EdgeThickness = edgeThickness;
            FillColor = fillColor;
        }

        public virtual void Draw()
        {
            Console.WriteLine($"Отрисовка фигуры... Слой:{Layer}, Цвет границ:{EdgeColor}, Толщина границ:{EdgeThickness}, Цвет заливки:{FillColor}");
        }
    }
}