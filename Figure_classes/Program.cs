using System;
using System.Globalization;
using System.Net.Sockets;
using System.Runtime.ConstrainedExecution;
using System.Xml.Linq;

namespace Figure_classes
{
    class Program
    {
        public static void Main()
        {
            Polygon polygon = new Polygon();

            polygon.Layer = 0;
            polygon.EdgeThickness = 2.4;
            polygon.EdgeColor = "красный";
            polygon.FillColor = "белый";

            polygon.Points = new List<Point>() {
        new Point() {
            X_Position = 5.6,
            Y_Position = 3.4
        }, new Point(){
            X_Position = 6.7,
            Y_Position = 2.4
        }, new Point() {
            X_Position = 5.1,
            Y_Position = 2.4
        },new Point() {
            X_Position = 2.2,
            Y_Position = 7.1
        }
    };
            foreach (Point p in polygon.Points)
            {
                Console.WriteLine($"X:{p.X_Position} Y:{p.Y_Position}");
            }
            Console.WriteLine($"Слой:{polygon.Layer}, Цвет границ:{polygon.EdgeColor}, Толщина границ: { polygon.EdgeThickness}, Цвет заливки:{ polygon.FillColor}");
        }

        public static void ShowVerticalEdges(Edge[] lines)
        {
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].FirstPoint.X_Position == lines[i].SecondPoint.X_Position)
                {
                    Console.WriteLine($"{lines[i].FirstPoint.X_Position} {lines[i].FirstPoint.Y_Position} {lines[i].SecondPoint.X_Position} {lines[i].SecondPoint.Y_Position}");
                }
            }
        }
    }
}