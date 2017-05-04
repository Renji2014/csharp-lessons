using System;

namespace ExerciseSolution
{
    public class Polygon
    {
        public Point2D[] Vertices
        {
            get { return vertices; }
            set
            {
                vertices = value;
                Area = calculateArea();
            }
        }
        private Point2D[] vertices;
        
        public int VertexCount
        {
            get { return Vertices.Length; }
        }
        
        public float Area
        { get; private set; }

        
        public Polygon(int vertexCount)
        {
            vertices = new Point2D[vertexCount];
        }
        
        public Polygon(Point2D[] vertices)
        {
            Vertices = vertices;
        }

        
        private float calculateArea()
        {
            float area = 0;
            // Go through all vertices and calculate the area.
            for(int c = 0; c < Vertices.Length; c++)
            {
                // Add all point pairs.
                if(c < Vertices.Length - 1)
                    area += (Vertices[c].X - Vertices[c + 1].X) * (Vertices[c].Y + Vertices[c + 1].Y);
                // Don't forget the last pair (last and first point).
                else
                    area += (Vertices[c].X - Vertices[0].X) * (Vertices[c].Y + Vertices[0].Y);
            }
            // Take the absolute half value.
            return Math.Abs(area / 2);
        }
    }
}
