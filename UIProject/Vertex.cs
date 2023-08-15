using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace UIProject
{
    internal class Vertex
    {
        // Tọa độ đỉnh: (x, y)
        public Point Point;

        // Số thứ tự của đỉnh
        public int PointOrder;

        // Check xem đỉnh ẩn hay hiển thị
        public bool Hide;

        public Vertex()
        {
            PointOrder = 0;
            Hide = false;
        }

        public Vertex(int x, int y, int order)
        {
            Point = new Point(x, y);
            PointOrder = order;
            Hide = false;
        }

        // Kiểm tra xem chuột có nằm trong phạm vi của đỉnh
        public bool IsMouseOn(Point point)
        {
            // Constant.Radius là bán kính của một đỉnh
            if (
                Math.Abs(Point.X - point.X) <= Constant.Radius
                && Math.Abs(Point.Y - point.Y) <= Constant.Radius
            )
            {
                return true;
            }
            return false;
        }
    }
}
