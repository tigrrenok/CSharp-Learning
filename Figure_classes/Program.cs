using System;
using System.Globalization;
using System.Net.Sockets;
using System.Runtime.ConstrainedExecution;
using System.Xml.Linq;
using System.Collections.Generic;
using static Figure_classes.Utils;

namespace Figure_classes
{
    class Program
    {
        public static void Main()
        {
            Figure figure = new Figure(3, "красный", 6.3, "серый");
            figure.Draw();
            Figure circle = new Circle(5, "голубой", -1, "чёрный", new Point(3, 5), 4);
            circle.Draw();
            Figure polygon = new Polygon(5, "голубой", -1, "чёрный", new List<Point>() { new Point(2, 3), new Point(0, 0), new Point(3, 2) });
            polygon.Draw();
            Figure edge = new Edge(10, "синий", 1, "малиновый", new Point(1, 1), new Point(10, 10));
            edge.Draw();
        }

    }
}