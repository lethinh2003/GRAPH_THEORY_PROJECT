using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace UIProject
{
    internal class Matrix
    {
        // Mảng 2 chiều lưu trọng số ma trận
        public int[,] WeightedMatrix;

        // Số đỉnh
        public int Vertex;

        // Nhập dữ liệu ma trận từ file
        public void Nhap(string fileName)
        {
            try
            {
                FileStream f = new FileStream(fileName, FileMode.Open);
                StreamReader sr = new StreamReader(f);
                Vertex = int.Parse(sr.ReadLine());
                WeightedMatrix = new int[Vertex, Vertex];
                string getLineStr;
                string[] strSplit;
                for (int i = 0; i < Vertex; i++)
                {
                    getLineStr = sr.ReadLine();
                    strSplit = getLineStr.Split(' ');
                    for (int j = 0; j < Vertex; j++)
                    {
                        WeightedMatrix[i, j] = int.Parse(strSplit[j]);
                    }
                }
                sr.Dispose();
                f.Dispose();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Thêm đỉnh mới vào ma trận
        public void Add(int vertex)
        {
            // Tạo ma trận mới với số đỉnh mới
            int[,] newWeightedMatrix = new int[vertex, vertex];
            // Chuyển các trọng số của ma trận cũ vào ma trận mới
            for (int i = 0; i < Vertex; i++)
            {
                for (int j = 0; j < Vertex; j++)
                {
                    newWeightedMatrix[i, j] = WeightedMatrix[i, j];
                }
            }
            // Thêm trọng số của các cạnh liên qua đến đỉnh mới
            for (int i = 0; i < vertex; i++)
            {
                for (int j = Vertex; j < vertex; j++)
                {
                    newWeightedMatrix[i, j] = 0;
                    newWeightedMatrix[j, i] = 0;
                }
            }
          
            // Gán ma trận cũ cho ma trận mới
            WeightedMatrix = newWeightedMatrix;
            Vertex = vertex;
        }
    }
}
