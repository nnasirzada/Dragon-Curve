using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace DragonCurve
{
    public static class DragonCurve
    {
        // Auto-Implemented Properties with default values for trivial get and set
        public static int NumberOfSteps { get; set; } = 13;
        public static double Length { get; set; } = 1;
        public static double Height { get; set; } = 0.5;
        public static int Angle { get; set; } = 90;

        public static List<string> objectSource = new List<string>();

        // Move points, calculate coordinates of the rotated point, shift them back and return new list
        private static List<Point> Rotate(this List<Point> polygons, Point pivot)
        {
            List<Point> temp = new List<Point>();
            foreach (Point p in polygons)
            {
                double xShifted = p.X - pivot.X;
                double yShifted = p.Y - pivot.Y;
                double x = pivot.X + (xShifted * Utils.Cos(Angle) - yShifted * Utils.Sin(Angle));
                double y = pivot.Y + (xShifted * Utils.Sin(Angle) + yShifted * Utils.Cos(Angle));
                temp.Add(new Point { X = x, Y = y });
            }
            temp.Remove(temp.Last());
            temp.Reverse();
            return temp;
        }

        // Rotate current polygons and add them to the end of the list
        private static List<Point> Iterate(this List<Point> polygons)
        {
            polygons.AddRange(Rotate(polygons, polygons.Last()));
            return polygons;
        }
        // Create vertices and faces
        public static void CreateObject()
        {
            // Initialize vertices list
            List<Point> result = new List<Point>();
            result.Add(new Point { X = 0, Y = 0 });
            result.Add(new Point { X = 0, Y = Length });
            for (int i = 0; i < NumberOfSteps; i++)
            {
                result = Iterate(result);
            }
            foreach (var point in result)
            {
                objectSource.Add(String.Format("v {0} {1} 0.0", point.X, point.Y));
                objectSource.Add(String.Format("v {0} {1} {2}", point.X, point.Y, Height));
            }
            for (int i = 0; i < (result.Count - 1) * 2; i += 2)
            {
                objectSource.Add(String.Format("f {0} {1} {2}", i + 1, i + 2, i + 3));
                objectSource.Add(String.Format("f {0} {1} {2}", i + 2, i + 3, i + 4));
            }
        }
        // Save created fractal as an .obj file
        public static void SaveAsObject(string fileName)
        {
            using (var outStream = File.OpenWrite(fileName))
            {
                using (var streamWriter = new StreamWriter(outStream))
                {
                    foreach (string s in objectSource)
                    {
                        streamWriter.WriteLine(s);
                    }
                }
            }
        }
    }
}