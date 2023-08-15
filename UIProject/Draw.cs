using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Threading;
using System.ComponentModel;
using System.Data;

namespace UIProject
{
    internal class Draw
    {
        // Dùng để hiển thị hình ảnh đồ thị
        public PictureBox PicDraw;

        // Danh sách các đỉnh
        public Vertex[] Vertices;

        // Danh sách các cạnh
        public Edge[,] Edges;

        // Cạnh được chọn hiện tại
        public Edge EdgeSelected = null;

        // Đỉnh được chọn hiện tại
        public Vertex VertexSelected = null;

        // Danh sách các đỉnh đã bị xóa
        public List<Vertex> VerticesDeleted = new List<Vertex>();

        // Biến kiểm tra xem đã phân bố tọa độ (x, y) cho các đỉnh chưa
        bool _phanBoDinh = false;

        public Draw(Matrix matrix)
        {
            Vertices = new Vertex[matrix.Vertex];
            Edges = new Edge[matrix.Vertex, matrix.Vertex];
        }

        // Kiểm tra xem đỉnh có tồn tại trong danh sách đỉnh hay không
        public bool KiemTraDinhTonTai(int vertexOrder)
        {
            // Nếu số thự tự đỉnh vượt ra ngoài hoặc đỉnh đã bị xóa thì return false, ngược lại true.
            if (
                vertexOrder >= 0
                && vertexOrder <= Vertices.Length - 1
                && Vertices[vertexOrder].Hide == false
            )
            {
                return true;
            }
            return false;
        }

        // Thêm cạnh mới vào danh sách cạnh
        public void ThemCanh(int vertexOrder1, int vertexOrder2, int weighted)
        {
            Edges[vertexOrder1, vertexOrder2] = new Edge(
                Vertices[vertexOrder1],
                Vertices[vertexOrder2],
                weighted
            );
            Edges[vertexOrder2, vertexOrder1] = new Edge(
                Vertices[vertexOrder2],
                Vertices[vertexOrder1],
                weighted
            );
        }

        // Vẽ đỉnh
        public void VeDinh(Graphics graph, Vertex vertex)
        {
            // Kiểm tra đỉnh có bị xóa hay không?
            if (Vertices[vertex.PointOrder].Hide == false)
            {
                graph.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                // Vẽ vòng tròn viền quanh đỉnh
                graph.FillEllipse(
                    new SolidBrush(Constant.VertexColor1),
                    vertex.Point.X - Constant.Radius + 3,
                    vertex.Point.Y - Constant.Radius + 3,
                    Constant.Radius * 2 - 6,
                    Constant.Radius * 2 - 6
                );
                // Tô màu cho nền cho đỉnh
                graph.FillEllipse(
                    new SolidBrush(Constant.VertexColor2),
                    vertex.Point.X - Constant.Radius + 6,
                    vertex.Point.Y - Constant.Radius + 6,
                    Constant.Radius * 2 - 12,
                    Constant.Radius * 2 - 12
                );
                // Vẽ số thứ tự của đỉnh
                graph.DrawString(
                    vertex.PointOrder.ToString(),
                    new Font(
                        FontFamily.GenericSansSerif,
                        13,
                        FontStyle.Bold,
                        GraphicsUnit.Pixel,
                        8,
                        false
                    ),
                    Constant.PointOrderColor,
                    vertex.Point.X + 5f - 10,
                    vertex.Point.Y + 3f - 10
                );
            }
        }

        // Vẽ đỉnh khi thực thi thuật toán Prim
        public void VeDinhDuocChonPrim(Graphics graph, Vertex vertex)
        {
            // Kiểm tra đỉnh có bị xóa hay không?
            if (Vertices[vertex.PointOrder].Hide == false)
            {
                graph.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                // Vẽ viền ngoài cho đỉnh
                graph.DrawEllipse(
                    new Pen(Constant.VertexColor0, Constant.PenWidth),
                    vertex.Point.X - Constant.Radius,
                    vertex.Point.Y - Constant.Radius,
                    Constant.Radius * 2,
                    Constant.Radius * 2
                );
                // Vẽ viền trong
                graph.FillEllipse(
                    new SolidBrush(Constant.VertexColor1),
                    vertex.Point.X - Constant.Radius + 3,
                    vertex.Point.Y - Constant.Radius + 3,
                    Constant.Radius * 2 - 6,
                    Constant.Radius * 2 - 6
                );
                // Tô màu cho đỉnh
                graph.FillEllipse(
                    new SolidBrush(Constant.VertexColor2),
                    vertex.Point.X - Constant.Radius + 6,
                    vertex.Point.Y - Constant.Radius + 6,
                    Constant.Radius * 2 - 12,
                    Constant.Radius * 2 - 12
                );
                // Vẽ số thứ tự của đỉnh
                graph.DrawString(
                    vertex.PointOrder.ToString(),
                    new Font(
                        FontFamily.GenericSansSerif,
                        13,
                        FontStyle.Bold,
                        GraphicsUnit.Pixel,
                        8,
                        false
                    ),
                    Constant.PointOrderColor,
                    vertex.Point.X + 5f - 10,
                    vertex.Point.Y + 3f - 10
                );
            }
        }

        // Thêm đỉnh mới vào danh sách đỉnh
        public void AddVertex(Vertex vertex)
        {
            // Thực hiện chuyển các danh sách đỉnh cũ sang danh sách đỉnh mới
            Vertex[] newVertices = new Vertex[vertex.PointOrder + 1];
            for (int i = 0; i < vertex.PointOrder; i++)
            {
                newVertices[i] = Vertices[i];
            }
            // Thêm đỉnh mới vào danh sách đỉnh mới
            newVertices[vertex.PointOrder] = vertex;
            // Gán lại cho danh sách đỉnh
            Vertices = newVertices;

            //Sau khi thêm đỉnh, cần phải thêm cạnh mới vô.
            Edge[,] newEdges = new Edge[vertex.PointOrder + 1, vertex.PointOrder + 1];
            for (int i = 0; i < vertex.PointOrder; i++)
            {
                for (int j = 0; j < vertex.PointOrder; j++)
                {
                    newEdges[i, j] = Edges[i, j];
                }
            }
            Edges = newEdges;
        }

        // Vẽ cạnh
        public void VeCanh(Graphics graph, Edge edge)
        {
            Color color = Constant.EdgeColor;
            Pen pen = new Pen(color, Constant.PenWidth);
            graph.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            // Vẽ đường thẳng nối liền giữa 2 đỉnh đầu và cuối
            graph.DrawLine(pen, edge.StartVertex.Point, edge.EndVertex.Point);
            // Vẽ trọng số cho cạnh
            graph.DrawString(
                edge.Weighted.ToString(),
                new Font(
                    FontFamily.GenericMonospace,
                    16,
                    FontStyle.Bold,
                    GraphicsUnit.Pixel,
                    8,
                    true
                ),
                Constant.WeightedGraphColor,
                ((edge.StartVertex.Point.X + edge.EndVertex.Point.X) / 2 - 5f),
                ((edge.StartVertex.Point.Y + edge.EndVertex.Point.Y) / 2 - 5f)
            );
        }

        // Vẽ đồ thị
        public void VeDoThi(Matrix matrix, Graphics graph)
        {
            // Nếu chưa phân bố các tọa độ (x, y) cho đỉnh thì bắt đầu phân bố
            if (_phanBoDinh == false)
            {
                PhanBoDinh(matrix.Vertex);
            }
            // Vẽ cạnh
            for (int i = 0; i < matrix.Vertex; i++)
            {
                for (int j = 0; j < matrix.Vertex; j++)
                {
                    if (matrix.WeightedMatrix[i, j] != 0 && i != j)
                    {
                
                        Edges[i, j] = new Edge(
                            Vertices[i],
                            Vertices[j],
                            matrix.WeightedMatrix[i, j]
                        );
                        VeCanh(graph, Edges[i, j]);
                    }
                    else
                    {
                        Edges[i, j] = null;
                    }
                }
            }

            // Vẽ đỉnh
            for (int i = 0; i < matrix.Vertex; i++)
            {
                // Nếu đỉnh đã bị ẩn (xóa) thì không vẽ
                if (!Vertices[i].Hide)
                {
                    VeDinh(graph, Vertices[i]);
                }
            }
        }

        // Kéo và thả đỉnh
        public void DragAndDropVertex(MouseEventArgs mouse, Matrix classMaTran, Graphics graph)
        {
            // Nếu đang giữ chuột trái và click vào một đỉnh
            if ((mouse.Button == MouseButtons.Left) && VertexSelected != null)
            {
                // Thực hiện di chuyển tọa độ (x, y) theo tọa độ của chuột
                VertexSelected.Point.X = mouse.Location.X;
                VertexSelected.Point.Y = mouse.Location.Y;
                // Vẽ lại đồ thị
                graph.Clear(Constant.BackgroundColorGraph);
                VeDoThi(classMaTran, graph);
            }
        }

        // Vẽ lại cạnh khi cạnh được click
        public void VeCanhDuocChon(Graphics graph, Edge edge)
        {
            // Kiểm tra có tồn tại cạnh đó không
            if (edge != null)
            {
                Color color = Constant.EdgeColorSelected;
                Pen pen = new Pen(color, Constant.PenWidth);

                graph.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                graph.DrawLine(pen, edge.StartVertex.Point, edge.EndVertex.Point);
                graph.DrawString(
                    edge.Weighted.ToString(),
                    new Font(
                        FontFamily.GenericMonospace,
                        16,
                        FontStyle.Bold,
                        GraphicsUnit.Pixel,
                        8,
                        true
                    ),
                    Constant.WeightedGraphColor,
                    ((edge.StartVertex.Point.X + edge.EndVertex.Point.X) / 2 - 5f),
                    ((edge.StartVertex.Point.Y + edge.EndVertex.Point.Y) / 2 - 5f)
                );
            }
        }

        // Vẽ cạnh khi thực thi thuật toán Prim
        public void VeCanhDuocChonPrim(Graphics graph, int dau, int cuoi)
        {
            Edge edge = Edges[dau, cuoi];
            // Kiểm tra có tồn tại cạnh đó không
            if (edge != null)
            {
                Color color = Constant.EdgeColorSelectedPrim;
                Pen pen = new Pen(color, Constant.PenWidth * 2);
                graph.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                graph.DrawLine(pen, edge.StartVertex.Point, edge.EndVertex.Point);
                graph.DrawString(
                    edge.Weighted.ToString(),
                    new Font(
                        FontFamily.GenericMonospace,
                        16,
                        FontStyle.Bold,
                        GraphicsUnit.Pixel,
                        8,
                        true
                    ),
                    Constant.WeightedGraphColorPrim,
                    ((edge.StartVertex.Point.X + edge.EndVertex.Point.X) / 2 - 5f),
                    ((edge.StartVertex.Point.Y + edge.EndVertex.Point.Y) / 2 - 5f)
                );
            }
        }

        public void PhanBoDinh(int vertexNum)
        {
            Random random = new Random();

            for (int i = 0; i < vertexNum; i++)
            {    
                int x = random.Next(Constant.Radius, PicDraw.Width - Constant.Radius);
                int y = random.Next(Constant.Radius, PicDraw.Height - Constant.Radius);      
                Vertices[i] = new Vertex(x, y, i);
            }
            _phanBoDinh = true;
        }
    }
}
