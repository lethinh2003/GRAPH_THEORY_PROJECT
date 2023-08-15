using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
namespace UIProject
{
    internal class Edge
    {
        // Đỉnh đầu, đỉnh cuối
        public Vertex StartVertex, EndVertex;
        // Trọng số
        public int Weighted;  
        public Edge()
        {
            Weighted = 0;
        }
        public Edge(Vertex startVertex, Vertex endVertex, int weighted)
        {
            StartVertex = startVertex;
            EndVertex = endVertex;
            Weighted = weighted;
        }

        // Kiểm tra xem chuột có nằm trong phạm vi của cạnh
        public bool IsMouseOn(int x, int y)
        { 
            double kc = Math.Sqrt((double)(Math.Pow(EndVertex.Point.X - StartVertex.Point.X, 2) + Math.Pow(EndVertex.Point.Y - StartVertex.Point.Y, 2)));
            double kc1 = Math.Sqrt((double)(Math.Pow(StartVertex.Point.X - x, 2) + Math.Pow(StartVertex.Point.Y - y, 2)));
            double kc2 = Math.Sqrt((double)(Math.Pow(EndVertex.Point.X - x, 2) + Math.Pow(EndVertex.Point.Y - y, 2)));
            return (kc + 0.1f >= kc1 + kc2);

        }
    }
}
