using System;
using System.Collections.Generic;

namespace Figure_classes
{
    public static class Utils
    {
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

        public static List<Circle> FindCircles(Figure[] figures)
        {
            List<Circle> circles = new List<Circle>();
            for (int i = 0; i < figures.Length; i++)
            {
                Circle isCircle = figures[i] as Circle;
                if (isCircle != null) circles.Add(isCircle);
            }
            return circles;
        }

        public static Polygon FindFirstTriangle(Figure[] figures) 
        {
            for (int i = 0; i < figures.Length; i++)
            {
                Polygon isPolygon = figures[i] as Polygon;
                if (isPolygon != null && isPolygon.Points.Count == 3) 
                {
                    return isPolygon;
                }

            }
            return null;
        }

        public static void RepaintEdges(Figure[] figures)
        {
            for (int i = 0; i < figures.Length; i++)
            {
                Edge isEdge = figures[i] as Edge;
                if (isEdge != null)
                {
                    isEdge.EdgeColor = "голубой";
                }

            }
        }

    }
}
