using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;

/* Reference:
 * Original source code belongs to Dr. Araz Yusubov. 
 * Modifications are made to make the code work with my application.
 */

namespace DragonCurve
{
    struct Vertex3D
    {
        public float x, y, z;
        public Vertex3D(float x, float y, float z)
        {
            this.x = x; this.y = y; this.z = z;
        }
        public float Length()
        {
            return (float)Math.Sqrt(x * x + y * y + z * z);
        }
        public override string ToString()
        {
            return String.Format("{0}, {1}, {2}", x, y, z);
        }
    }

    struct Triangle3D
    {
        public int p1, p2, p3;
        public Triangle3D(int a, int b, int c)
        {
            this.p1 = a; this.p2 = b; this.p3 = c;
        }
        public override string ToString()
        {
            return String.Format("{0}, {1}, {2}", p1, p2, p3);
        }
    }

    class Object3D
    {
        public List<Vertex3D> Vertices;
        public List<Triangle3D> Triangles;
        private List<Vertex3D> transVertices = new List<Vertex3D>(); // Stores transformed vertices
        public float Scale;
        public float AngleX;
        public float AngleY;
        public float AngleZ;
        public Color BackgroundColor;
        public Color WireframeColor;

        public Object3D()
        {
            Scale = 5.0F;
            AngleX = 0.0F;
            AngleY = 0.0F;
            AngleZ = 0.0F;
            BackgroundColor = Color.FromArgb(255, 255, 255, 255);
            WireframeColor = Color.FromArgb(255, 0, 0, 0);
            Vertices = new List<Vertex3D>();
            Triangles = new List<Triangle3D>();
        }

        public void LoadFromFile(string filename)
        {
            TextReader reader = File.OpenText(filename);
            string line;
            int lineno = 0;
            Vertices.Clear();
            Triangles.Clear();
            while ((line = reader.ReadLine()) != null)
            {
                try
                {
                    lineno++;
                    char[] separators = { ' ' };
                    string[] parts = line.Split(separators);
                    switch (parts[0])
                    {
                        case "v":
                            parts = line.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                            float x = float.Parse(parts[1], System.Globalization.CultureInfo.InvariantCulture);
                            float y = float.Parse(parts[2], System.Globalization.CultureInfo.InvariantCulture);
                            float z = float.Parse(parts[3], System.Globalization.CultureInfo.InvariantCulture);
                            Vertices.Add(new Vertex3D(x, y, z));
                            break;
                        case "f":
                            parts = line.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                            int a = int.Parse(parts[1]);
                            int b = int.Parse(parts[2]);
                            int c = int.Parse(parts[3]);
                            Triangles.Add(new Triangle3D(a, b, c));
                            for (int i = 3; i < parts.Length; i++)
                            {
                                b = c; c = int.Parse(parts[i]);
                                Triangles.Add(new Triangle3D(a, b, c));
                            }
                            break;
                    }
                }
                catch
                {
                    throw new FileLoadException(string.Format("Error processing string no.{0}: {1}", lineno, line));
                }
            }
        }

        public void Draw(Graphics graph, bool clear)
        {
            if (clear) graph.Clear(BackgroundColor);
            Pen pen = new Pen(WireframeColor);
            float cx = graph.ClipBounds.Width / 2;
            float cy = graph.ClipBounds.Height / 2;
            transVertices.Clear();
            // Make all transformations and store transformed vertices
            foreach (Vertex3D vertex in Vertices)
            {
                Vertex3D v = vertex;
                float x = v.x;
                float y = v.y;
                float z = v.z;
                // Rotation around X-axis
                y = (float)(v.y * Math.Cos(AngleX) - v.z * Math.Sin(AngleX));
                z = (float)(v.y * Math.Sin(AngleX) + v.z * Math.Cos(AngleX));
                v.y = y; v.z = z;
                // Rotation around Y-axis
                x = (float)(v.x * Math.Cos(AngleY) - v.z * Math.Sin(AngleY));
                z = (float)(v.x * Math.Sin(AngleY) + v.z * Math.Cos(AngleY));
                v.x = x; v.z = z;
                // Rotation around Z-axis
                x = (float)(v.x * Math.Cos(AngleZ) - v.y * Math.Sin(AngleZ));
                y = (float)(v.x * Math.Sin(AngleZ) + v.y * Math.Cos(AngleZ));
                v.x = x; v.y = y;
                // Uniform scaling
                v.x *= Scale;
                v.y *= Scale;
                v.z *= Scale;
                // Moving to screen coordinates
                v.x = cx + v.x;
                v.y = cy - v.y;
                // Store transformed vertex
                transVertices.Add(v);
            }
            
            SolidBrush brush = new SolidBrush(BackgroundColor);
            List<Triangle3D> sortedTriangles = Triangles;
            // We sort triangles to draw the closest one last    
            sortedTriangles = Triangles.OrderBy(t => transVertices.ElementAt(t.p2 - 1).z).ToList();
                
            foreach (Triangle3D triangle in sortedTriangles)
            {
                PointF[] points = new PointF[3];
                points[0].X = transVertices[triangle.p1 - 1].x;
                points[0].Y = transVertices[triangle.p1 - 1].y;
                points[1].X = transVertices[triangle.p2 - 1].x;
                points[1].Y = transVertices[triangle.p2 - 1].y;
                points[2].X = transVertices[triangle.p3 - 1].x;
                points[2].Y = transVertices[triangle.p3 - 1].y;

                // We draw all the triangles as filled polygones
                graph.FillPolygon(brush, points);
                graph.DrawPolygon(pen, points);
            }
        }
    }
}
