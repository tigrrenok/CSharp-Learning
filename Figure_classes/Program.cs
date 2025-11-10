using System;
using System.Globalization;
using System.Net.Sockets;
using System.Runtime.ConstrainedExecution;
using System.Xml.Linq;
using System.Collections.Generic;


namespace Figure_classes
{
    class Program
    {
        public static void Main()
        {
            Circle circle = new Circle(2, "red", 1, "white", new Point(3, 5), 4);
            Edge edge = new Edge(0, "black", 5.6, "black", new Point(1, 2), new Point(5, -4));
            Polygon polygon = new Polygon(3, "blue", 6.7, "green", new List<Point> { new Point(2, 3), new Point(5, 6), new Point(4, 5) });
            Edge edge2 = new Edge(1, "black", 7.8, "black", new Point(2, 3), new Point(4, -6));
            Circle circle2 = new Circle(9, "yellow", 3, "black", new Point(1, 7), 6);

            Figure nearestFigure = FindNearestFigure(new Figure[] { circle, edge, polygon, edge2, circle2 });

            Console.WriteLine($"Слой:{nearestFigure.Layer}, Цвет границ:{nearestFigure.EdgeColor}, Толщина границ:{nearestFigure.EdgeThickness}, Цвет заливки:{nearestFigure.FillColor}");
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

        public static Figure FindNearestFigure(Figure[] figures)
        { 
            Figure maxi = figures[0];
            for (int i = 1; i < figures.Length; i++)
            {
                if (figures[i].Layer > maxi.Layer) maxi = figures[i];
            }
            return maxi;
        }
    }
}