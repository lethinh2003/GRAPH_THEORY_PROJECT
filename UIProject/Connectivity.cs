using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIProject
{
    internal class Connectivity
    {
        // Ma trận
        Matrix _matrix;

        // Danh sách đỉnh
        Vertex[] _vertices;

        // Stack dùng để duyệt DFS
        Stack<int> _stack = new Stack<int>();

        // Đánh dấu danh sách đỉnh đã thăm
        bool[] _vertexVisit;

        // Lưu số thứ tự thành phần liên thông cho các đỉnh
        int[] _vertexConnect;

        // Số thành phần liên thông
        int _connect = 0;

        public Connectivity(Matrix matrix, Vertex[] vertices)
        {
            _matrix = matrix;
            _vertexVisit = new bool[_matrix.Vertex];
            _vertexConnect = new int[_matrix.Vertex];
            _vertices = vertices;
        }

        // Khởi tạo ban đầu với không có đỉnh nào được thăm
        void Init()
        {
            for (int i = 0; i < _matrix.Vertex; i++)
            {
                _vertexVisit[i] = false;
            }
        }

        // Kiểm tra có phải là đồ thị liên thông hay không
        public bool CheckConnect()
        {
            // Khởi tạo đỉnh thăm = {false}
            Init();
            // Duyệt từng đỉnh
            for (int i = 0; i < _matrix.Vertex; i++)
            {
                // Nếu đỉnh nào chưa thăm thì tiến hành thăm đỉnh đó
                if (_vertexVisit[i] == false && _vertices[i].Hide == false)
                {
                    _connect++;
                    _vertexConnect[i] = _connect;
                    // Thêm vào stack để chuẩn bị thực hiện DFS
                    _stack.Push(i);
                    // Đỉnh i đã được thăm
                    _vertexVisit[i] = true;
                    DFS();
                }
            }
            // Nếu có 1 thành phần liên thông thì là đồ thị liên thông, ngược lại không phải
            if (_connect == 1)
            {
                return true;
            }
            return false;
        }

        // Thuật toán DeapFirstSearch
        void DFS()
        {
            // Trong khi stack vẫn còn đỉnh để xét
            while (_stack.Count > 0)
            {
                // Lấy đỉnh top ra để xét
                int vertexTop = _stack.Pop();
                _vertexVisit[vertexTop] = true;
                _vertexConnect[vertexTop] = _connect;
                // Duyệt từng đỉnh để tìm ra cạnh kề với đỉnh top
                for (int i = 0; i < _matrix.Vertex; i++)
                {
                    // Nếu là cạnh kề với đỉnh top, đồng thời đỉnh i chưa được xét và đỉnh i chưa bị xóa
                    if (
                        _matrix.WeightedMatrix[vertexTop, i] != 0
                        && _vertexVisit[i] == false
                        && _vertices[i].Hide == false
                    )
                    {
                        // Thêm vào stack để chuẩn bị xét.
                        _stack.Push(i);
                    }
                }
            }
        }
    }
}
