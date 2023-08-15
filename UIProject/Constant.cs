using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace UIProject
{
    internal class Constant
    {
        // Bán kính của đỉnh
        public static int Radius = 25;

        // Màu viền của đỉnh được chọn khi thực hiện thuật toán Prim
        public static Brush VertexColor0 = Brushes.Red;
        // Màu viền bình thường của đỉnh
        public static Color VertexColor1 = Color.Black;
        // Màu nền bên trong đỉnh
        public static Color VertexColor2 = Color.LightBlue;
        // Màu của số thứ tự đỉnh
        public static Brush PointOrderColor = Brushes.Black;

        // Kích thước nét vẽ đồ thị
        public static float PenWidth = 1f;
        // Màu chữ của trọng số
        public static Brush WeightedGraphColor = Brushes.Black;
        // Màu của cạnh
        public static Color EdgeColor = Color.Black;
        // Màu của cạnh khi được người dùng chọn (click)
        public static Color EdgeColorSelected = Color.Red;
        // Màu của cạnh khi thực thi thuật toán Prim
        public static Color EdgeColorSelectedPrim = Color.Red;
        // Màu chữ trọng số khi thực thi thuật toán Prim
        public static Brush WeightedGraphColorPrim = Brushes.MidnightBlue;

        // Thời gian delay mỗi khi vẽ đỉnh và cạnh của thuật toán Prim
        public static int TimeDelayPrim = 500;
        // Background của đồ thị
        public static Color BackgroundColorGraph = Color.White;
    }
}
