using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Enum.Poison;
using ReaLTaiizor.Forms;
using System.Diagnostics;
using System.IO;

namespace UIProject
{
    public partial class Form1 : PoisonForm
    {
        Matrix _matrix;
        Draw _draw;
        Graphics _graph;
        Bitmap _bitmap;
        Prim _prim;

        public Form1()
        {
            InitializeComponent();
            InitialComponents();
            _matrix = new Matrix();
            _bitmap = new Bitmap(picOutput.Width, picOutput.Height);
            _graph = Graphics.FromImage(_bitmap);
            picOutput.Image = _bitmap;
        }

        #region Các hàm hiển thị hệ thống



        // Khởi tạo: Ẩn các chức năng khi chưa nhập file ma trận
        void InitialComponents()
        {
            btnLuuFile.Enabled = false;
            btnLuuDoThi.Enabled = false;
            grpChinhSua.Enabled = false;
            grpChucNang.Enabled = false;
            grpGiaoDienDoHoa.Enabled = false;
            grpMaTranVaKetQua.Enabled = false;
            grpThemDinhCanh.Enabled = false;
        }

        // Hiển thị các chức năng khi đã nhập file ma trận
        void EnableComponents()
        {
            btnLuuFile.Enabled = true;
            btnLuuDoThi.Enabled = true;
            grpChinhSua.Enabled = true;
            grpChucNang.Enabled = true;
            grpGiaoDienDoHoa.Enabled = true;
            grpMaTranVaKetQua.Enabled = true;
            grpThemDinhCanh.Enabled = true;
        }

        // Ẩn các chức năng khi đang thực hiện thuật toán Prim
        void DisableComponentsOnPrim()
        {
            btnMoFile.Enabled = false;
            cboDinhBatDau.Enabled = false;
            btnThucHien.Enabled = false;
            btnThucHien.Text = "Đang thực hiện...";

            btnLuuFile.Enabled = false;
            btnLuuDoThi.Enabled = false;
            grpChinhSua.Enabled = false;
            grpGiaoDienDoHoa.Enabled = false;
            grpMaTranVaKetQua.Enabled = false;
            grpThemDinhCanh.Enabled = false;
        }

        // Hiển thị các chức năng khi đã thực hiện xong thuật toán Prim
        void EnableComponentsOnPrim()
        {
            btnMoFile.Enabled = true;
            cboDinhBatDau.Enabled = true;
            btnThucHien.Enabled = true;
            btnThucHien.Text = "Thực hiện";

            btnLuuFile.Enabled = true;
            btnLuuDoThi.Enabled = true;
            grpChinhSua.Enabled = true;
            grpGiaoDienDoHoa.Enabled = true;
            grpMaTranVaKetQua.Enabled = true;
            grpThemDinhCanh.Enabled = true;
        }

        // Cập nhật danh sách các đỉnh vào các combobox chỉnh sửa khi có sự kiện thêm, sửa xóa các đỉnh
        void ReloadDanhSachDinh()
        {
            cboDinhTruoc.Items.Clear();
            cboDinhSau.Items.Clear();
            cboDinhBatDau.Items.Clear();
            for (int i = 0; i < _matrix.Vertex; i++)
            {
                if (_draw.Vertices[i].Hide == false)
                {
                    cboDinhTruoc.Items.Add(i);
                    cboDinhSau.Items.Add(i);
                    cboDinhBatDau.Items.Add(i);
                }
            }
            if (_matrix.Vertex > 0)
            {
                cboDinhTruoc.SelectedIndex = 0;
                cboDinhSau.SelectedIndex = 0;
                cboDinhBatDau.SelectedIndex = 0;
            }
            txtTrongSoThemCanh.Text = 0.ToString();
        }

        // Hiển thị các thông số của một cạnh vào các textbox khi click vào cạnh đó trên đồ thị
        void DisplaySelectedEdge()
        {
            if (_draw != null)
            {
                if (_draw.EdgeSelected != null)
                {
                    txtDinhTruocEdit.Text = _draw.EdgeSelected.StartVertex.PointOrder.ToString();
                    txtDinhSauEdit.Text = _draw.EdgeSelected.EndVertex.PointOrder.ToString();
                    txtTrongSoEdit.Text = _draw.EdgeSelected.Weighted.ToString();
                }
            }
        }

        // Ẩn hiển thị các thông số của cạnh đã chọn khi click ra ngoài
        void ResetSelectedEdge()
        {
            if (_draw != null)
            {
                _draw.EdgeSelected = null;
                txtDinhTruocEdit.Text = null;
                txtDinhSauEdit.Text = null;
                txtTrongSoEdit.Text = null;
            }
        }

        // Hiển thị các thông số của một đỉnh vào các textbox khi click vào đỉnh đó trên đồ thị
        void DisplaySelectedVertex()
        {
            if (_draw != null)
            {
                if (_draw.VertexSelected != null)
                {
                    txtDinhEdit.Text = _draw.VertexSelected.PointOrder.ToString();
                }
            }
        }

        // Ẩn hiển thị các thông số của đỉnh đã chọn khi click ra ngoài
        void ResetSelectedVertex()
        {
            if (_draw != null)
            {
                _draw.VertexSelected = null;
                txtDinhEdit.Text = null;
            }
        }

        // Xuất ma trận theo 2 dạng: trọng số và kề lên listview
        void PrintMatrix()
        {
            try
            {
                lstInputWM.Clear();
                lstInputAM.Clear();
                lstInputWM.Columns.Add("", 50, HorizontalAlignment.Center);
                lstInputAM.Columns.Add("", 50, HorizontalAlignment.Center);
                lstInputWM.View = View.Details;
                lstInputAM.View = View.Details;
                for (int i = 0; i < _matrix.Vertex; i++)
                {
                    if (!_draw.Vertices[i].Hide)
                    {
                        lstInputWM.Columns.Add(i.ToString(), 50, HorizontalAlignment.Center);
                        lstInputAM.Columns.Add(i.ToString(), 50, HorizontalAlignment.Center);

                        ListViewItem item = new ListViewItem(i.ToString());
                        ListViewItem itemAM = new ListViewItem(i.ToString());

                        for (int j = 0; j < _matrix.Vertex; j++)
                        {
                            if (!_draw.Vertices[j].Hide)
                            {
                                // Print Adjacency Matrix
                                if (_matrix.WeightedMatrix[i, j] != 0)
                                {
                                    itemAM.SubItems.Add(1.ToString());
                                }
                                else
                                {
                                    itemAM.SubItems.Add(_matrix.WeightedMatrix[i, j].ToString());
                                }
                                // Print Weighted Matrix
                                if (i != j && _matrix.WeightedMatrix[i, j] == 0)
                                {
                                    item.SubItems.Add("∞");
                                }
                                else
                                {
                                    item.SubItems.Add(_matrix.WeightedMatrix[i, j].ToString());
                                }
                            }
                        }
                        lstInputWM.Items.Add(item);
                        lstInputAM.Items.Add(itemAM);
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Kiểm tra đồ thị vô hướng và liên thông
        // Kiểm tra input Ma trận đầu vào có phải là ma trận của đơn đồ thị vô hướng (không có cạnh song song và khuyên) không?
        bool CheckMatrix()
        {
            for (int i = 0; i < _matrix.Vertex; i++)
            {
                for (int j = 0; j < _matrix.Vertex; j++)
                {
                    if (_matrix.WeightedMatrix[i, j] != _matrix.WeightedMatrix[j, i])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        // Kiểm tra tính liên thông của đồ thị
        bool KiemTraLienThong()
        {
            try
            {
                Connectivity connectivity = new Connectivity(_matrix, _draw.Vertices);
                return connectivity.CheckConnect();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        #endregion

        #region Nhập file, xuất file, lưu đồ thị
        private void btnMoFile_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog OD = new OpenFileDialog();
                OD.InitialDirectory = Application.StartupPath;
                OD.Filter = "Text File|*.txt";
                OD.Title = "Chọn file";
                if (OD.ShowDialog() == DialogResult.OK && OD.FileName != "")
                {
                    _matrix.Nhap(OD.FileName);
                    // Kiểm tra đồ thị phải là đơn đồ thị vô hướng (không có khuyên và cạnh song song)
                    if (!CheckMatrix())
                    {
                        throw new Exception("Ma trận không hợp lệ!");
                    }
                    // Tô màu nền ảnh đồ thị
                    _graph.Clear(Constant.BackgroundColorGraph);
                    _draw = new Draw(_matrix);
                    _draw.PicDraw = picOutput;
                    // Tiến hành vẽ đồ thị
                    _draw.VeDoThi(_matrix, _graph);
                    ReloadDanhSachDinh();
                    EnableComponents();
                    picOutput.Image = _bitmap;
                    PrintMatrix();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLuuFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (_draw == null)
                {
                    throw new Exception("Vui lòng mở file trước khi lưu");
                }
                // Đếm số đỉnh bị ẩn/xóa
                int dinhBiXoa = 0;
                foreach (var item in _draw.Vertices)
                {
                    if (item.Hide)
                    {
                        dinhBiXoa++;
                    }
                }
                SaveFileDialog svg = new SaveFileDialog();
                svg.Filter = "Text files | *.txt";
                if (svg.ShowDialog() == DialogResult.OK)
                {
                    string fileName;
                    fileName = svg.FileName;
                    StreamWriter sw = File.CreateText(fileName);
                    sw.WriteLine(_matrix.Vertex - dinhBiXoa);
                    for (int i = 0; i < _matrix.Vertex; i++)
                    {
                        if (!_draw.Vertices[i].Hide)
                        {
                            for (int j = 0; j < _matrix.Vertex; j++)
                            {
                                if (!_draw.Vertices[j].Hide)
                                {
                                    sw.Write(_matrix.WeightedMatrix[i, j]);
                                    if (j != _matrix.Vertex - 1)
                                    {
                                        sw.Write(" ");
                                    }
                                }
                            }
                            if (i != _matrix.Vertex - 1)
                            {
                                sw.WriteLine();
                            }
                        }
                    }
                    sw.Close();
                    MessageBox.Show(
                        "Save success",
                        "Info",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLuuDoThi_Click(object sender, EventArgs e)
        {
            try
            {
                if (_draw == null)
                {
                    throw new Exception("Vui lòng mở file trước khi lưu đồ thị");
                }
                SaveFileDialog svg = new SaveFileDialog();
                svg.Filter = "Image files | *.jpg";
                if (svg.ShowDialog() == DialogResult.OK)
                {
                    string fileName;
                    fileName = svg.FileName;

                    _bitmap.Save(fileName);

                    MessageBox.Show(
                        "Save success",
                        "Info",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Chỉnh sửa và xóa đỉnh, cạnh
        // Chỉnh sửa cạnh
        private void btnChinhSuaCanh_Click(object sender, EventArgs e)
        {
            try
            {
                if (_draw.EdgeSelected == null)
                {
                    throw new Exception("Vui lòng chọn cạnh muốn chỉnh sửa");
                }
                if (string.IsNullOrEmpty(txtTrongSoEdit.Text))
                {
                    throw new Exception("Vui lòng nhập trọng số hợp lệ");
                }
                int startVertex = int.Parse(txtDinhTruocEdit.Text);
                int endVertex = int.Parse(txtDinhSauEdit.Text);
                int weighted = int.Parse(txtTrongSoEdit.Text);
                // Cập nhật lại trọng số trong ma trận
                _matrix.WeightedMatrix[startVertex, endVertex] = weighted;
                _matrix.WeightedMatrix[endVertex, startVertex] = weighted;
                // Vẽ lại đồ thị
                _graph.Clear(Constant.BackgroundColorGraph);
                _draw.VeDoThi(_matrix, _graph);
                picOutput.Image = _bitmap;
                // Reset lại không còn cạnh nào đang được chọn
                ResetSelectedEdge();
                // Xuất ra ma trận lên listview
                PrintMatrix();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Xóa cạnh
        private void btnXoaCanh_Click(object sender, EventArgs e)
        {
            try
            {
                if (_draw.EdgeSelected == null)
                {
                    throw new Exception("Vui lòng chọn cạnh muốn xóa");
                }
                int startVertex = int.Parse(txtDinhTruocEdit.Text);
                int endVertex = int.Parse(txtDinhSauEdit.Text);
                int weighted = 0;
                // Cập nhật lại trọng số trong ma trận
                _matrix.WeightedMatrix[startVertex, endVertex] = weighted;
                _matrix.WeightedMatrix[endVertex, startVertex] = weighted;
                // Vẽ lại đồ thị
                _graph.Clear(Constant.BackgroundColorGraph);
                _draw.VeDoThi(_matrix, _graph);
                picOutput.Image = _bitmap;
                // Reset lại không còn cạnh nào đang được chọn
                ResetSelectedEdge();
                // Xuất ra ma trận lên listview
                PrintMatrix();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Xóa đỉnh
        private void btnXoaDinhEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtDinhEdit.Text))
                {
                    throw new Exception("Vui lòng chọn đỉnh cần xóa");
                }
                int vertexOrder = int.Parse(txtDinhEdit.Text);
                if (!_draw.KiemTraDinhTonTai(vertexOrder))
                {
                    throw new Exception("Vui lòng chọn đỉnh hợp lệ");
                }
                // Ẩn đỉnh được chọn để xóa đi
                _draw.Vertices[vertexOrder].Hide = true;
                // Thêm vào danh sách đỉnh đã xóa
                _draw.VerticesDeleted.Add(_draw.Vertices[vertexOrder]);
                // Cập nhật lại trọng số = 0 đối với các cạnh có liên quan đỉnh bị xóa
                for (int i = 0; i < _matrix.Vertex; i++)
                {
                    _matrix.WeightedMatrix[i, vertexOrder] = 0;
                    _matrix.WeightedMatrix[vertexOrder, i] = 0;
                }
                // Vẽ lại đồ thị
                _graph.Clear(Constant.BackgroundColorGraph);
                _draw.VeDoThi(_matrix, _graph);
                picOutput.Image = _bitmap;
                // Cập nhật danh sách đỉnh ở các combobox
                ReloadDanhSachDinh();
                // Reset lại không còn đỉnh nào đang được chọn
                ResetSelectedVertex();
                // Xuất ra ma trận lên listview
                PrintMatrix();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Thêm đỉnh, cạnh mới
        // Thêm đỉnh mới vào đồ thị
        private void btnThemDinh_Click(object sender, EventArgs e)
        {
            try
            {
                if (_draw == null)
                {
                    throw new Exception("Vui lòng nhập file ma trận");
                }
                // Random tạo độ x, y cho đỉnh mới
                Random random = new Random();
                int x = random.Next(Constant.Radius, 558 - Constant.Radius);
                int y = random.Next(Constant.Radius, 554 - Constant.Radius);
                Vertex vertex = new Vertex(x, y, _matrix.Vertex);
                // Thêm đỉnh mới vào ma trận
                _matrix.Add(_matrix.Vertex + 1);
                // Thêm đỉnh mới vào đối tượng draw
                _draw.AddVertex(vertex);
                // Tiến hình vẽ lại tất cả các đỉnh
                _draw.VeDinh(_graph, vertex);
                picOutput.Image = _bitmap;
                // Làm mới danh sách đỉnh ở các combobox
                ReloadDanhSachDinh();
                // Xuất ra ma trận lên listview
                PrintMatrix();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Thêm cạnh mới vào đồ thị
        private void btnThemCanh_Click(object sender, EventArgs e)
        {
            try
            {
                int vertexOrder1 = int.Parse(cboDinhTruoc.SelectedItem.ToString());
                int vertexOrder2 = int.Parse(cboDinhSau.SelectedItem.ToString());
                if (
                    !_draw.KiemTraDinhTonTai(vertexOrder1) || !_draw.KiemTraDinhTonTai(vertexOrder2)
                )
                {
                    throw new Exception("Vui lòng chọn các đỉnh hợp lệ");
                }
                if (vertexOrder1 == vertexOrder2)
                {
                    throw new Exception("Vui lòng chọn các đỉnh hợp lệ");
                }

                int weighted;
                if (!int.TryParse(txtTrongSoThemCanh.Text, out weighted))
                {
                    throw new Exception("Vui lòng nhập trọng số hợp lệ");
                }
                if (weighted == 0)
                {
                    throw new Exception("Vui lòng nhập trọng số hợp lệ");
                }
                if (_matrix.WeightedMatrix[vertexOrder1, vertexOrder2] != 0)
                {
                    throw new Exception("Cạnh này đã được thêm");
                }
                // Thêm cạnh mới vào đối tượng draw
                _draw.ThemCanh(vertexOrder1, vertexOrder2, weighted);
                _draw.ThemCanh(vertexOrder2, vertexOrder1, weighted);
                // Thêm trọng số của cạnh đó vào ma trận
                _matrix.WeightedMatrix[vertexOrder1, vertexOrder2] = weighted;
                _matrix.WeightedMatrix[vertexOrder2, vertexOrder1] = weighted;
                // Vẽ lại đồ thị
                _graph.Clear(Constant.BackgroundColorGraph);
                _draw.VeDoThi(_matrix, _graph);
                picOutput.Image = _bitmap;
                // Xuất ra ma trận lên listview
                PrintMatrix();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion


        // Sự kiện click vào đồ thị
        private void picOutput_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (_draw == null)
                {
                    return;
                }

                // Duyệt từng đỉnh
                foreach (Vertex dinh in _draw.Vertices)
                {
                    // Kiểm tra nếu người dùng click vào một đỉnh
                    if (dinh.IsMouseOn(e.Location))
                    {
                        _draw.VertexSelected = dinh;
                        // Hiển thị thông tin đỉnh đó vào textbox
                        DisplaySelectedVertex();
                        // Nếu có cạnh đang chọn thì reset thông tin cạnh đó
                        ResetSelectedEdge();
                        return;
                    }
                }
                // Duyệt từng cạnh
                for (int i = 0; i < _matrix.Vertex; i++)
                {
                    for (int j = 0; j < _matrix.Vertex; j++)
                    {
                        // Kiểm tra có tồn tại cạnh ij hay không
                        if (_draw.Edges[i, j] != null)
                        {
                            // Kiểm tra khi người dùng click chuột trên cạnh ij (không tính 2 đỉnh i và j)
                            if (
                                _draw.Edges[i, j].IsMouseOn(e.X, e.Y)
                                && !_draw.Edges[i, j].StartVertex.IsMouseOn(e.Location)
                                && !_draw.Edges[i, j].EndVertex.IsMouseOn(e.Location)
                            )
                            {
                                // Vẽ lại đồ thị
                                _graph.Clear(Constant.BackgroundColorGraph);
                                _draw.VeDoThi(_matrix, _graph);
                                picOutput.Image = _bitmap;
                                _draw.EdgeSelected = _draw.Edges[i, j];
                                // Hiển thị thông tin cạnh đó vào textbox
                                DisplaySelectedEdge();
                                // Nếu có đỉnh đang chọn thì reset thông tin đỉnh đó
                                ResetSelectedVertex();
                                // Vẽ đè lên cạnh được chọn
                                _draw.VeCanhDuocChon(_graph, _draw.Edges[i, j]);
                                // Vẽ lại 2 đỉnh sau khi vẽ cạnh được chọn
                                _draw.VeDinh(_graph, _draw.Edges[i, j].StartVertex);
                                _draw.VeDinh(_graph, _draw.Edges[i, j].EndVertex);
                                picOutput.Image = _bitmap;
                                return;
                            }
                        }
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Sự kiện di chuyển chuột trong đồ thị
        private void picOutput_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                if (_draw != null)
                {
                    if (e.Button == MouseButtons.None)
                    {
                        _draw.VertexSelected = null;
                    }
                    else
                    // Kiểm tra người dùng nếu vừa di chuyển vừa click chuột vào đồ thị
                    if (
                        e.Button == MouseButtons.Left
                        && e.X >= 0 + Constant.Radius
                        && e.Y >= 0 + Constant.Radius
                        && (e.X <= picOutput.Width - Constant.Radius)
                        && (e.Y <= picOutput.Height - Constant.Radius)
                    )
                    {
                        // Duyệt từng đỉnh
                        foreach (Vertex dinh in _draw.Vertices)
                        {
                            // Kiểm tra nếu người dùng click vào một đỉnh
                            if (dinh.IsMouseOn(e.Location))
                            {
                                _draw.VertexSelected = dinh;
                                // Hiển thị thông tin đỉnh đó vào textbox
                                DisplaySelectedVertex();
                                // Nếu có cạnh đang chọn thì reset thông tin cạnh đó
                                ResetSelectedEdge();
                                break;
                            }
                        }

                        _draw.DragAndDropVertex(e, _matrix, _graph);
                        picOutput.Image = _bitmap;
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Thực hiện thuật toán Prim
        private void btnThucHien_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra tính liên thông
                if (KiemTraLienThong() == false)
                {
                    throw new Exception("Đồ thị không liên thông, không thể thực hiện");
                }
                int dinhSelected = int.Parse(cboDinhBatDau.SelectedItem.ToString());
                if (!_draw.KiemTraDinhTonTai(dinhSelected))
                {
                    throw new Exception("Vui lòng chọn đỉnh bắt đầu");
                }
                // Ẩn các chức năng khác trong khi thực hiện Prim
                DisableComponentsOnPrim();
                // Vẽ lại đồ thị
                _graph.Clear(Constant.BackgroundColorGraph);
                _draw.VeDoThi(_matrix, _graph);
                picOutput.Image = _bitmap;
                picOutput.Show();
                txtKetQua.Text = null;
                // Tạo mới đối tượng prim
                _prim = new Prim(_matrix, _draw, _graph, dinhSelected);
                // Triển khai thuật toán Prim
                _prim.ImplementAlgorithm(this, _bitmap);
                // Sau khi triển khai thì hiển thị lại các chức năng khác
                EnableComponentsOnPrim();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Giới thiệu đồ án, thành viên
        private void btnAboutUs_Click(object sender, EventArgs e)
        {
            try
            {
                AboutUs aboutUs = new AboutUs();
                aboutUs.Show();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Chỉ cho phép nhập số nguyên dương cho trọng số
        private void txtTrongSoEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // Chỉ cho phép nhập số nguyên dương cho trọng số
        private void txtTrongSoThemCanh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // Cảnh báo thoát chương trình
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show(
                "Bạn có muốn thoát chương trình?",
                "Cảnh báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information
            );
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
