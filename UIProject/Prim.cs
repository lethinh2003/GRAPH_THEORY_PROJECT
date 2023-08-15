

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace UIProject
{
    internal class Prim
    {
        // Ma trận trọng số
        Matrix _matrix;

        // Mảng lưu các đỉnh cha (trước) của đỉnh con (sau)
        int[] _parent;
        int[] _key;

        // Mảng đánh dấu các đỉnh đã thêm vào MST
        bool[] _mstSet;
        Draw _draw;
        Graphics _graph;

        // Đỉnh bắt đầu
        int _vertexStart;

        public Prim(Matrix matrix, Draw draw, Graphics graph, int vertexStart)
        {
            _matrix = matrix;
            _parent = new int[_matrix.Vertex];
            _key = new int[_matrix.Vertex];
            _mstSet = new bool[_matrix.Vertex];
            _draw = draw;
            _graph = graph;
            _vertexStart = vertexStart;
        }

        // Tìm đỉnh có key nhỏ nhất
        int FindIndexMinKey()
        {
            int min = int.MaxValue;
            int indexMin = -1;
            for (int i = 0; i < _matrix.Vertex; i++)
            {
                // Nếu đỉnh i chưa thêm vào tập đỉnh đã xét, và đỉnh i có key bé nhất thì chọn
                if (_mstSet[i] == false && _key[i] < min)
                {
                    min = _key[i];
                    indexMin = i;
                }
            }
            return indexMin;
        }

        // Khởi tạo thuật toán
        void Init()
        {
            for (int i = 0; i < _matrix.Vertex; i++)
            {
                // Key của các đỉnh được gán bằng vô cùng
                _key[i] = int.MaxValue;
                // Tập đỉnh chưa được thêm vào đỉnh nào
                _mstSet[i] = false;
            }
        }

        void SetKeyAndParentVertex(int minKeyVertex)
        {
            for (int i = 0; i < _matrix.Vertex; i++)
            {
                // Xét các cạnh kề với đỉnh minKeyVertex
                if (
                    _matrix.WeightedMatrix[minKeyVertex, i] != 0
                    && _mstSet[i] == false
                    && _matrix.WeightedMatrix[minKeyVertex, i] < _key[i]
                )
                {
                    // Set đỉnh cha cho đỉnh i
                    _parent[i] = minKeyVertex;
                    // Set key cho đỉnh i
                    _key[i] = _matrix.WeightedMatrix[minKeyVertex, i];
                }
            }
        }

        // Triển khai thuật toán Prim
        public void ImplementAlgorithm(Form1 f, Bitmap bm)
        {
            if (_matrix != null)
            {
                f.txtKetQua.Text = "QUÁ TRÌNH DUYỆT PRIM \r\n";
                f.txtKetQua.Text += "Cạnh \t Trọng số \r\n";
                // Tổng chi phí khởi tạo = 0;
                int cost = 0;
                // Khởi tạo
                Init();
                // Key của đỉnh bắt đầu gán bằng 0
                _key[_vertexStart] = 0;
                // Đỉnh cha của đỉnh bắt đầu bằng -1
                _parent[_vertexStart] = -1;
                // Vẽ đỉnh bắt đầu đầu tiên
                _draw.VeDinhDuocChonPrim(_graph, _draw.Vertices[_vertexStart]);
                f.picOutput.Image = bm;
                // Delay chương trình
                Thread.Sleep(Constant.TimeDelayPrim);
                Application.DoEvents();
                // Vòng lập chạy từ 0 đến (số đỉnh chưa bị xóa  - 1) 
                for (int v = 0; v < _matrix.Vertex - _draw.VerticesDeleted.Count; v++)
                {
                    // Tìm đỉnh có key bé nhất
                    int minKeyVertex = FindIndexMinKey();
                    // Thêm đỉnh minKeyVertex vào danh sách đỉnh
                    _mstSet[minKeyVertex] = true;
                    // Kiểm tra nếu đỉnh minKeyVertex không phải đỉnh bắt đầu
                    if (_parent[minKeyVertex] != -1)
                    {
                        // Tính cộng dồn chi phí
                        cost += _matrix.WeightedMatrix[_parent[minKeyVertex], minKeyVertex];
                        // Vẽ cạnh từ đỉnh cha của minKeyVertex đến đỉnh minKeyVertex
                        _draw.VeCanhDuocChonPrim(_graph, _parent[minKeyVertex], minKeyVertex);
                        // Vẽ đỉnh cha của minKeyVertex
                        _draw.VeDinhDuocChonPrim(_graph, _draw.Vertices[_parent[minKeyVertex]]);
                        // Vẽ đỉnh minKeyVertex
                        _draw.VeDinhDuocChonPrim(_graph, _draw.Vertices[minKeyVertex]);
                        // Thông báo kết quả duyệt ra màn hình
                        f.txtKetQua.Text +=
                            $"{_parent[minKeyVertex]} - {minKeyVertex} \t {_matrix.WeightedMatrix[_parent[minKeyVertex], minKeyVertex]} \r\n";
                        // Cập nhật hình ảnh đồ thị
                        f.picOutput.Image = bm;
                        // Delay chương trình
                        Thread.Sleep(Constant.TimeDelayPrim);
                        Application.DoEvents();
                    }
                    SetKeyAndParentVertex(minKeyVertex);
                }
                // Xuất kết quả ra màn hình
                f.txtKetQua.Text += $"TỔNG TRỌNG SỐ: {cost}";
            }
        }
    }
}

