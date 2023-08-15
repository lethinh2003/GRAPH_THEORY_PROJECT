namespace UIProject
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabMain = new ReaLTaiizor.Controls.PoisonTabControl();
            this.tpFile = new ReaLTaiizor.Controls.PoisonTabPage();
            this.btnLuuDoThi = new ReaLTaiizor.Controls.PoisonButton();
            this.btnLuuFile = new ReaLTaiizor.Controls.PoisonButton();
            this.btnMoFile = new ReaLTaiizor.Controls.PoisonButton();
            this.ribbonGroupBox1 = new ReaLTaiizor.Controls.RibbonGroupBox();
            this.tpAbout = new ReaLTaiizor.Controls.PoisonTabPage();
            this.btnAboutUs = new ReaLTaiizor.Controls.PoisonButton();
            this.tabMatrix = new ReaLTaiizor.Controls.AirTabPage();
            this.tpMatrix1 = new System.Windows.Forms.TabPage();
            this.lstInputWM = new ReaLTaiizor.Controls.PoisonListView();
            this.tpMatrix2 = new System.Windows.Forms.TabPage();
            this.lstInputAM = new ReaLTaiizor.Controls.PoisonListView();
            this.grpMaTranVaKetQua = new ReaLTaiizor.Controls.ParrotGroupBox();
            this.txtKetQua = new ReaLTaiizor.Controls.HopeRichTextBox();
            this.lblKetQua = new ReaLTaiizor.Controls.PoisonLabel();
            this.grpChinhSua = new ReaLTaiizor.Controls.ParrotGroupBox();
            this.btnXoaDinhEdit = new ReaLTaiizor.Controls.PoisonButton();
            this.lblEditVertex = new ReaLTaiizor.Controls.MetroLabel();
            this.lblEditEdge = new ReaLTaiizor.Controls.MetroLabel();
            this.btnXoaCanh = new ReaLTaiizor.Controls.PoisonButton();
            this.btnChinhSuaCanh = new ReaLTaiizor.Controls.PoisonButton();
            this.lblTrongSoEdit = new ReaLTaiizor.Controls.PoisonLabel();
            this.lblDinhEdit = new ReaLTaiizor.Controls.PoisonLabel();
            this.lblDinhTruocEdit = new ReaLTaiizor.Controls.PoisonLabel();
            this.lblDinhSauEdit = new ReaLTaiizor.Controls.PoisonLabel();
            this.txtDinhEdit = new ReaLTaiizor.Controls.PoisonTextBox();
            this.txtDinhTruocEdit = new ReaLTaiizor.Controls.PoisonTextBox();
            this.txtTrongSoEdit = new ReaLTaiizor.Controls.PoisonTextBox();
            this.txtDinhSauEdit = new ReaLTaiizor.Controls.PoisonTextBox();
            this.grpGiaoDienDoHoa = new ReaLTaiizor.Controls.ParrotGroupBox();
            this.picOutput = new System.Windows.Forms.PictureBox();
            this.grpChucNang = new ReaLTaiizor.Controls.ParrotGroupBox();
            this.lblPrimChucNang = new ReaLTaiizor.Controls.MetroLabel();
            this.cboDinhBatDau = new ReaLTaiizor.Controls.AloneComboBox();
            this.lblDinhBatDauChucNang = new ReaLTaiizor.Controls.PoisonLabel();
            this.btnThucHien = new ReaLTaiizor.Controls.PoisonButton();
            this.grpThemDinhCanh = new ReaLTaiizor.Controls.ParrotGroupBox();
            this.tabThemDinhCanh = new ReaLTaiizor.Controls.MaterialShowTabControl();
            this.tpAddVertex = new System.Windows.Forms.TabPage();
            this.btnThemDinh = new ReaLTaiizor.Controls.PoisonButton();
            this.tpAddEdge = new System.Windows.Forms.TabPage();
            this.cboDinhSau = new ReaLTaiizor.Controls.AloneComboBox();
            this.cboDinhTruoc = new ReaLTaiizor.Controls.AloneComboBox();
            this.btnThemCanh = new ReaLTaiizor.Controls.PoisonButton();
            this.lblTrongSoAdd = new ReaLTaiizor.Controls.PoisonLabel();
            this.lblDinhTruocAdd = new ReaLTaiizor.Controls.PoisonLabel();
            this.lblDinhSauAdd = new ReaLTaiizor.Controls.PoisonLabel();
            this.txtTrongSoThemCanh = new ReaLTaiizor.Controls.PoisonTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabMain.SuspendLayout();
            this.tpFile.SuspendLayout();
            this.tpAbout.SuspendLayout();
            this.tabMatrix.SuspendLayout();
            this.tpMatrix1.SuspendLayout();
            this.tpMatrix2.SuspendLayout();
            this.grpMaTranVaKetQua.SuspendLayout();
            this.grpChinhSua.SuspendLayout();
            this.grpGiaoDienDoHoa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picOutput)).BeginInit();
            this.grpChucNang.SuspendLayout();
            this.grpThemDinhCanh.SuspendLayout();
            this.tabThemDinhCanh.SuspendLayout();
            this.tpAddVertex.SuspendLayout();
            this.tpAddEdge.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tpFile);
            this.tabMain.Controls.Add(this.tpAbout);
            resources.ApplyResources(this.tabMain, "tabMain");
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            this.tabMain.UseSelectable = true;
            // 
            // tpFile
            // 
            this.tpFile.Controls.Add(this.btnLuuDoThi);
            this.tpFile.Controls.Add(this.btnLuuFile);
            this.tpFile.Controls.Add(this.btnMoFile);
            this.tpFile.Controls.Add(this.ribbonGroupBox1);
            this.tpFile.HorizontalScrollbarBarColor = true;
            this.tpFile.HorizontalScrollbarHighlightOnWheel = false;
            this.tpFile.HorizontalScrollbarSize = 10;
            resources.ApplyResources(this.tpFile, "tpFile");
            this.tpFile.Name = "tpFile";
            this.tpFile.VerticalScrollbarBarColor = true;
            this.tpFile.VerticalScrollbarHighlightOnWheel = false;
            this.tpFile.VerticalScrollbarSize = 10;
            // 
            // btnLuuDoThi
            // 
            this.btnLuuDoThi.Highlight = true;
            resources.ApplyResources(this.btnLuuDoThi, "btnLuuDoThi");
            this.btnLuuDoThi.Name = "btnLuuDoThi";
            this.btnLuuDoThi.UseSelectable = true;
            this.btnLuuDoThi.Click += new System.EventHandler(this.btnLuuDoThi_Click);
            // 
            // btnLuuFile
            // 
            this.btnLuuFile.Highlight = true;
            resources.ApplyResources(this.btnLuuFile, "btnLuuFile");
            this.btnLuuFile.Name = "btnLuuFile";
            this.btnLuuFile.UseSelectable = true;
            this.btnLuuFile.Click += new System.EventHandler(this.btnLuuFile_Click);
            // 
            // btnMoFile
            // 
            this.btnMoFile.Highlight = true;
            resources.ApplyResources(this.btnMoFile, "btnMoFile");
            this.btnMoFile.Name = "btnMoFile";
            this.btnMoFile.UseSelectable = true;
            this.btnMoFile.Click += new System.EventHandler(this.btnMoFile_Click);
            // 
            // ribbonGroupBox1
            // 
            this.ribbonGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.ribbonGroupBox1.BaseColor = System.Drawing.Color.Transparent;
            this.ribbonGroupBox1.BorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(143)))), ((int)(((byte)(143)))));
            this.ribbonGroupBox1.BorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(178)))), ((int)(((byte)(172)))));
            this.ribbonGroupBox1.BorderColorC = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(192)))), ((int)(((byte)(200)))));
            this.ribbonGroupBox1.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            resources.ApplyResources(this.ribbonGroupBox1, "ribbonGroupBox1");
            this.ribbonGroupBox1.ForeColor = System.Drawing.Color.Black;
            this.ribbonGroupBox1.LineColorA = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(126)))), ((int)(((byte)(126)))));
            this.ribbonGroupBox1.LineColorB = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(126)))), ((int)(((byte)(126)))));
            this.ribbonGroupBox1.Name = "ribbonGroupBox1";
            this.ribbonGroupBox1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            // 
            // tpAbout
            // 
            this.tpAbout.Controls.Add(this.btnAboutUs);
            this.tpAbout.HorizontalScrollbarBarColor = true;
            this.tpAbout.HorizontalScrollbarHighlightOnWheel = false;
            this.tpAbout.HorizontalScrollbarSize = 10;
            resources.ApplyResources(this.tpAbout, "tpAbout");
            this.tpAbout.Name = "tpAbout";
            this.tpAbout.VerticalScrollbarBarColor = true;
            this.tpAbout.VerticalScrollbarHighlightOnWheel = false;
            this.tpAbout.VerticalScrollbarSize = 10;
            // 
            // btnAboutUs
            // 
            this.btnAboutUs.Highlight = true;
            resources.ApplyResources(this.btnAboutUs, "btnAboutUs");
            this.btnAboutUs.Name = "btnAboutUs";
            this.btnAboutUs.UseSelectable = true;
            this.btnAboutUs.Click += new System.EventHandler(this.btnAboutUs_Click);
            // 
            // tabMatrix
            // 
            resources.ApplyResources(this.tabMatrix, "tabMatrix");
            this.tabMatrix.Controls.Add(this.tpMatrix1);
            this.tabMatrix.Controls.Add(this.tpMatrix2);
            this.tabMatrix.Multiline = true;
            this.tabMatrix.Name = "tabMatrix";
            this.tabMatrix.SelectedIndex = 0;
            this.tabMatrix.ShowOuterBorders = false;
            this.tabMatrix.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabMatrix.SquareColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(87)))), ((int)(((byte)(100)))));
            // 
            // tpMatrix1
            // 
            this.tpMatrix1.BackColor = System.Drawing.Color.White;
            this.tpMatrix1.Controls.Add(this.lstInputWM);
            resources.ApplyResources(this.tpMatrix1, "tpMatrix1");
            this.tpMatrix1.Name = "tpMatrix1";
            // 
            // lstInputWM
            // 
            resources.ApplyResources(this.lstInputWM, "lstInputWM");
            this.lstInputWM.FullRowSelect = true;
            this.lstInputWM.Name = "lstInputWM";
            this.lstInputWM.OwnerDraw = true;
            this.lstInputWM.UseCompatibleStateImageBehavior = false;
            this.lstInputWM.UseSelectable = true;
            // 
            // tpMatrix2
            // 
            this.tpMatrix2.BackColor = System.Drawing.Color.White;
            this.tpMatrix2.Controls.Add(this.lstInputAM);
            resources.ApplyResources(this.tpMatrix2, "tpMatrix2");
            this.tpMatrix2.Name = "tpMatrix2";
            // 
            // lstInputAM
            // 
            resources.ApplyResources(this.lstInputAM, "lstInputAM");
            this.lstInputAM.FullRowSelect = true;
            this.lstInputAM.Name = "lstInputAM";
            this.lstInputAM.OwnerDraw = true;
            this.lstInputAM.UseCompatibleStateImageBehavior = false;
            this.lstInputAM.UseSelectable = true;
            // 
            // grpMaTranVaKetQua
            // 
            this.grpMaTranVaKetQua.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(187)))), ((int)(((byte)(225)))));
            this.grpMaTranVaKetQua.BorderWidth = 2;
            this.grpMaTranVaKetQua.Controls.Add(this.txtKetQua);
            this.grpMaTranVaKetQua.Controls.Add(this.lblKetQua);
            this.grpMaTranVaKetQua.Controls.Add(this.tabMatrix);
            this.grpMaTranVaKetQua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            resources.ApplyResources(this.grpMaTranVaKetQua, "grpMaTranVaKetQua");
            this.grpMaTranVaKetQua.Name = "grpMaTranVaKetQua";
            this.grpMaTranVaKetQua.ShowText = true;
            this.grpMaTranVaKetQua.TabStop = false;
            this.grpMaTranVaKetQua.TextColor = System.Drawing.Color.DodgerBlue;
            // 
            // txtKetQua
            // 
            this.txtKetQua.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            resources.ApplyResources(this.txtKetQua, "txtKetQua");
            this.txtKetQua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.txtKetQua.Hint = "";
            this.txtKetQua.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.txtKetQua.MaxLength = 32767;
            this.txtKetQua.Multiline = true;
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.PasswordChar = '\0';
            this.txtKetQua.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtKetQua.SelectedText = "";
            this.txtKetQua.SelectionLength = 0;
            this.txtKetQua.SelectionStart = 0;
            this.txtKetQua.TabStop = false;
            this.txtKetQua.UseSystemPasswordChar = false;
            // 
            // lblKetQua
            // 
            resources.ApplyResources(this.lblKetQua, "lblKetQua");
            this.lblKetQua.Name = "lblKetQua";
            // 
            // grpChinhSua
            // 
            this.grpChinhSua.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(187)))), ((int)(((byte)(225)))));
            this.grpChinhSua.BorderWidth = 2;
            this.grpChinhSua.Controls.Add(this.btnXoaDinhEdit);
            this.grpChinhSua.Controls.Add(this.lblEditVertex);
            this.grpChinhSua.Controls.Add(this.lblEditEdge);
            this.grpChinhSua.Controls.Add(this.btnXoaCanh);
            this.grpChinhSua.Controls.Add(this.btnChinhSuaCanh);
            this.grpChinhSua.Controls.Add(this.lblTrongSoEdit);
            this.grpChinhSua.Controls.Add(this.lblDinhEdit);
            this.grpChinhSua.Controls.Add(this.lblDinhTruocEdit);
            this.grpChinhSua.Controls.Add(this.lblDinhSauEdit);
            this.grpChinhSua.Controls.Add(this.txtDinhEdit);
            this.grpChinhSua.Controls.Add(this.txtDinhTruocEdit);
            this.grpChinhSua.Controls.Add(this.txtTrongSoEdit);
            this.grpChinhSua.Controls.Add(this.txtDinhSauEdit);
            resources.ApplyResources(this.grpChinhSua, "grpChinhSua");
            this.grpChinhSua.Name = "grpChinhSua";
            this.grpChinhSua.ShowText = true;
            this.grpChinhSua.TabStop = false;
            this.grpChinhSua.TextColor = System.Drawing.Color.DodgerBlue;
            // 
            // btnXoaDinhEdit
            // 
            this.btnXoaDinhEdit.Highlight = true;
            resources.ApplyResources(this.btnXoaDinhEdit, "btnXoaDinhEdit");
            this.btnXoaDinhEdit.Name = "btnXoaDinhEdit";
            this.btnXoaDinhEdit.UseSelectable = true;
            this.btnXoaDinhEdit.Click += new System.EventHandler(this.btnXoaDinhEdit_Click);
            // 
            // lblEditVertex
            // 
            resources.ApplyResources(this.lblEditVertex, "lblEditVertex");
            this.lblEditVertex.IsDerivedStyle = true;
            this.lblEditVertex.Name = "lblEditVertex";
            this.lblEditVertex.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.lblEditVertex.StyleManager = null;
            this.lblEditVertex.ThemeAuthor = "Taiizor";
            this.lblEditVertex.ThemeName = "MetroLight";
            // 
            // lblEditEdge
            // 
            resources.ApplyResources(this.lblEditEdge, "lblEditEdge");
            this.lblEditEdge.IsDerivedStyle = true;
            this.lblEditEdge.Name = "lblEditEdge";
            this.lblEditEdge.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.lblEditEdge.StyleManager = null;
            this.lblEditEdge.ThemeAuthor = "Taiizor";
            this.lblEditEdge.ThemeName = "MetroLight";
            // 
            // btnXoaCanh
            // 
            this.btnXoaCanh.Highlight = true;
            resources.ApplyResources(this.btnXoaCanh, "btnXoaCanh");
            this.btnXoaCanh.Name = "btnXoaCanh";
            this.btnXoaCanh.UseSelectable = true;
            this.btnXoaCanh.Click += new System.EventHandler(this.btnXoaCanh_Click);
            // 
            // btnChinhSuaCanh
            // 
            this.btnChinhSuaCanh.Highlight = true;
            resources.ApplyResources(this.btnChinhSuaCanh, "btnChinhSuaCanh");
            this.btnChinhSuaCanh.Name = "btnChinhSuaCanh";
            this.btnChinhSuaCanh.UseSelectable = true;
            this.btnChinhSuaCanh.Click += new System.EventHandler(this.btnChinhSuaCanh_Click);
            // 
            // lblTrongSoEdit
            // 
            resources.ApplyResources(this.lblTrongSoEdit, "lblTrongSoEdit");
            this.lblTrongSoEdit.Name = "lblTrongSoEdit";
            // 
            // lblDinhEdit
            // 
            resources.ApplyResources(this.lblDinhEdit, "lblDinhEdit");
            this.lblDinhEdit.Name = "lblDinhEdit";
            // 
            // lblDinhTruocEdit
            // 
            resources.ApplyResources(this.lblDinhTruocEdit, "lblDinhTruocEdit");
            this.lblDinhTruocEdit.Name = "lblDinhTruocEdit";
            // 
            // lblDinhSauEdit
            // 
            resources.ApplyResources(this.lblDinhSauEdit, "lblDinhSauEdit");
            this.lblDinhSauEdit.Name = "lblDinhSauEdit";
            // 
            // txtDinhEdit
            // 
            // 
            // 
            // 
            this.txtDinhEdit.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.txtDinhEdit.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode")));
            this.txtDinhEdit.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location")));
            this.txtDinhEdit.CustomButton.Name = "";
            this.txtDinhEdit.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size")));
            this.txtDinhEdit.CustomButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            this.txtDinhEdit.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex")));
            this.txtDinhEdit.CustomButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            this.txtDinhEdit.CustomButton.UseSelectable = true;
            this.txtDinhEdit.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible")));
            resources.ApplyResources(this.txtDinhEdit, "txtDinhEdit");
            this.txtDinhEdit.Lines = new string[0];
            this.txtDinhEdit.MaxLength = 32767;
            this.txtDinhEdit.Multiline = true;
            this.txtDinhEdit.Name = "txtDinhEdit";
            this.txtDinhEdit.PasswordChar = '\0';
            this.txtDinhEdit.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDinhEdit.SelectedText = "";
            this.txtDinhEdit.SelectionLength = 0;
            this.txtDinhEdit.SelectionStart = 0;
            this.txtDinhEdit.ShortcutsEnabled = true;
            this.txtDinhEdit.UseSelectable = true;
            this.txtDinhEdit.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDinhEdit.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtDinhTruocEdit
            // 
            // 
            // 
            // 
            this.txtDinhTruocEdit.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.txtDinhTruocEdit.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode1")));
            this.txtDinhTruocEdit.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location1")));
            this.txtDinhTruocEdit.CustomButton.Name = "";
            this.txtDinhTruocEdit.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size1")));
            this.txtDinhTruocEdit.CustomButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            this.txtDinhTruocEdit.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex1")));
            this.txtDinhTruocEdit.CustomButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            this.txtDinhTruocEdit.CustomButton.UseSelectable = true;
            this.txtDinhTruocEdit.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible1")));
            resources.ApplyResources(this.txtDinhTruocEdit, "txtDinhTruocEdit");
            this.txtDinhTruocEdit.Lines = new string[0];
            this.txtDinhTruocEdit.MaxLength = 32767;
            this.txtDinhTruocEdit.Multiline = true;
            this.txtDinhTruocEdit.Name = "txtDinhTruocEdit";
            this.txtDinhTruocEdit.PasswordChar = '\0';
            this.txtDinhTruocEdit.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDinhTruocEdit.SelectedText = "";
            this.txtDinhTruocEdit.SelectionLength = 0;
            this.txtDinhTruocEdit.SelectionStart = 0;
            this.txtDinhTruocEdit.ShortcutsEnabled = true;
            this.txtDinhTruocEdit.UseSelectable = true;
            this.txtDinhTruocEdit.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDinhTruocEdit.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtTrongSoEdit
            // 
            // 
            // 
            // 
            this.txtTrongSoEdit.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.txtTrongSoEdit.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode2")));
            this.txtTrongSoEdit.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location2")));
            this.txtTrongSoEdit.CustomButton.Name = "";
            this.txtTrongSoEdit.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size2")));
            this.txtTrongSoEdit.CustomButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            this.txtTrongSoEdit.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex2")));
            this.txtTrongSoEdit.CustomButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            this.txtTrongSoEdit.CustomButton.UseSelectable = true;
            this.txtTrongSoEdit.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible2")));
            this.txtTrongSoEdit.Lines = new string[0];
            resources.ApplyResources(this.txtTrongSoEdit, "txtTrongSoEdit");
            this.txtTrongSoEdit.MaxLength = 32767;
            this.txtTrongSoEdit.Multiline = true;
            this.txtTrongSoEdit.Name = "txtTrongSoEdit";
            this.txtTrongSoEdit.PasswordChar = '\0';
            this.txtTrongSoEdit.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTrongSoEdit.SelectedText = "";
            this.txtTrongSoEdit.SelectionLength = 0;
            this.txtTrongSoEdit.SelectionStart = 0;
            this.txtTrongSoEdit.ShortcutsEnabled = true;
            this.txtTrongSoEdit.UseSelectable = true;
            this.txtTrongSoEdit.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTrongSoEdit.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtTrongSoEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTrongSoEdit_KeyPress);
            // 
            // txtDinhSauEdit
            // 
            // 
            // 
            // 
            this.txtDinhSauEdit.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            this.txtDinhSauEdit.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode3")));
            this.txtDinhSauEdit.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location3")));
            this.txtDinhSauEdit.CustomButton.Name = "";
            this.txtDinhSauEdit.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size3")));
            this.txtDinhSauEdit.CustomButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            this.txtDinhSauEdit.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex3")));
            this.txtDinhSauEdit.CustomButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            this.txtDinhSauEdit.CustomButton.UseSelectable = true;
            this.txtDinhSauEdit.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible3")));
            resources.ApplyResources(this.txtDinhSauEdit, "txtDinhSauEdit");
            this.txtDinhSauEdit.Lines = new string[0];
            this.txtDinhSauEdit.MaxLength = 32767;
            this.txtDinhSauEdit.Multiline = true;
            this.txtDinhSauEdit.Name = "txtDinhSauEdit";
            this.txtDinhSauEdit.PasswordChar = '\0';
            this.txtDinhSauEdit.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDinhSauEdit.SelectedText = "";
            this.txtDinhSauEdit.SelectionLength = 0;
            this.txtDinhSauEdit.SelectionStart = 0;
            this.txtDinhSauEdit.ShortcutsEnabled = true;
            this.txtDinhSauEdit.UseSelectable = true;
            this.txtDinhSauEdit.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDinhSauEdit.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // grpGiaoDienDoHoa
            // 
            this.grpGiaoDienDoHoa.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(187)))), ((int)(((byte)(225)))));
            this.grpGiaoDienDoHoa.BorderWidth = 2;
            this.grpGiaoDienDoHoa.Controls.Add(this.picOutput);
            resources.ApplyResources(this.grpGiaoDienDoHoa, "grpGiaoDienDoHoa");
            this.grpGiaoDienDoHoa.Name = "grpGiaoDienDoHoa";
            this.grpGiaoDienDoHoa.ShowText = true;
            this.grpGiaoDienDoHoa.TabStop = false;
            this.grpGiaoDienDoHoa.TextColor = System.Drawing.Color.DodgerBlue;
            // 
            // picOutput
            // 
            resources.ApplyResources(this.picOutput, "picOutput");
            this.picOutput.Name = "picOutput";
            this.picOutput.TabStop = false;
            this.picOutput.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picOutput_MouseClick);
            this.picOutput.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picOutput_MouseMove);
            // 
            // grpChucNang
            // 
            this.grpChucNang.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(187)))), ((int)(((byte)(225)))));
            this.grpChucNang.BorderWidth = 2;
            this.grpChucNang.Controls.Add(this.lblPrimChucNang);
            this.grpChucNang.Controls.Add(this.cboDinhBatDau);
            this.grpChucNang.Controls.Add(this.lblDinhBatDauChucNang);
            this.grpChucNang.Controls.Add(this.btnThucHien);
            resources.ApplyResources(this.grpChucNang, "grpChucNang");
            this.grpChucNang.Name = "grpChucNang";
            this.grpChucNang.ShowText = true;
            this.grpChucNang.TabStop = false;
            this.grpChucNang.TextColor = System.Drawing.Color.DodgerBlue;
            // 
            // lblPrimChucNang
            // 
            resources.ApplyResources(this.lblPrimChucNang, "lblPrimChucNang");
            this.lblPrimChucNang.IsDerivedStyle = true;
            this.lblPrimChucNang.Name = "lblPrimChucNang";
            this.lblPrimChucNang.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.lblPrimChucNang.StyleManager = null;
            this.lblPrimChucNang.ThemeAuthor = "Taiizor";
            this.lblPrimChucNang.ThemeName = "MetroLight";
            // 
            // cboDinhBatDau
            // 
            this.cboDinhBatDau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboDinhBatDau.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboDinhBatDau.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDinhBatDau.EnabledCalc = true;
            this.cboDinhBatDau.FormattingEnabled = true;
            resources.ApplyResources(this.cboDinhBatDau, "cboDinhBatDau");
            this.cboDinhBatDau.Name = "cboDinhBatDau";
            // 
            // lblDinhBatDauChucNang
            // 
            resources.ApplyResources(this.lblDinhBatDauChucNang, "lblDinhBatDauChucNang");
            this.lblDinhBatDauChucNang.Name = "lblDinhBatDauChucNang";
            this.lblDinhBatDauChucNang.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            // 
            // btnThucHien
            // 
            this.btnThucHien.Highlight = true;
            resources.ApplyResources(this.btnThucHien, "btnThucHien");
            this.btnThucHien.Name = "btnThucHien";
            this.btnThucHien.UseSelectable = true;
            this.btnThucHien.Click += new System.EventHandler(this.btnThucHien_Click);
            // 
            // grpThemDinhCanh
            // 
            this.grpThemDinhCanh.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(187)))), ((int)(((byte)(225)))));
            this.grpThemDinhCanh.BorderWidth = 2;
            this.grpThemDinhCanh.Controls.Add(this.tabThemDinhCanh);
            resources.ApplyResources(this.grpThemDinhCanh, "grpThemDinhCanh");
            this.grpThemDinhCanh.Name = "grpThemDinhCanh";
            this.grpThemDinhCanh.ShowText = true;
            this.grpThemDinhCanh.TabStop = false;
            this.grpThemDinhCanh.TextColor = System.Drawing.Color.DodgerBlue;
            // 
            // tabThemDinhCanh
            // 
            this.tabThemDinhCanh.Controls.Add(this.tpAddVertex);
            this.tabThemDinhCanh.Controls.Add(this.tpAddEdge);
            this.tabThemDinhCanh.Depth = 0;
            resources.ApplyResources(this.tabThemDinhCanh, "tabThemDinhCanh");
            this.tabThemDinhCanh.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.tabThemDinhCanh.Multiline = true;
            this.tabThemDinhCanh.Name = "tabThemDinhCanh";
            this.tabThemDinhCanh.SelectedIndex = 0;
            // 
            // tpAddVertex
            // 
            this.tpAddVertex.Controls.Add(this.btnThemDinh);
            resources.ApplyResources(this.tpAddVertex, "tpAddVertex");
            this.tpAddVertex.Name = "tpAddVertex";
            this.tpAddVertex.UseVisualStyleBackColor = true;
            // 
            // btnThemDinh
            // 
            this.btnThemDinh.Highlight = true;
            resources.ApplyResources(this.btnThemDinh, "btnThemDinh");
            this.btnThemDinh.Name = "btnThemDinh";
            this.btnThemDinh.UseSelectable = true;
            this.btnThemDinh.Click += new System.EventHandler(this.btnThemDinh_Click);
            // 
            // tpAddEdge
            // 
            this.tpAddEdge.Controls.Add(this.cboDinhSau);
            this.tpAddEdge.Controls.Add(this.cboDinhTruoc);
            this.tpAddEdge.Controls.Add(this.btnThemCanh);
            this.tpAddEdge.Controls.Add(this.lblTrongSoAdd);
            this.tpAddEdge.Controls.Add(this.lblDinhTruocAdd);
            this.tpAddEdge.Controls.Add(this.lblDinhSauAdd);
            this.tpAddEdge.Controls.Add(this.txtTrongSoThemCanh);
            resources.ApplyResources(this.tpAddEdge, "tpAddEdge");
            this.tpAddEdge.Name = "tpAddEdge";
            this.tpAddEdge.UseVisualStyleBackColor = true;
            // 
            // cboDinhSau
            // 
            this.cboDinhSau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboDinhSau.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboDinhSau.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDinhSau.EnabledCalc = true;
            this.cboDinhSau.FormattingEnabled = true;
            resources.ApplyResources(this.cboDinhSau, "cboDinhSau");
            this.cboDinhSau.Name = "cboDinhSau";
            // 
            // cboDinhTruoc
            // 
            this.cboDinhTruoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboDinhTruoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboDinhTruoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDinhTruoc.EnabledCalc = true;
            resources.ApplyResources(this.cboDinhTruoc, "cboDinhTruoc");
            this.cboDinhTruoc.FormattingEnabled = true;
            this.cboDinhTruoc.Name = "cboDinhTruoc";
            // 
            // btnThemCanh
            // 
            this.btnThemCanh.Highlight = true;
            resources.ApplyResources(this.btnThemCanh, "btnThemCanh");
            this.btnThemCanh.Name = "btnThemCanh";
            this.btnThemCanh.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            this.btnThemCanh.UseSelectable = true;
            this.btnThemCanh.Click += new System.EventHandler(this.btnThemCanh_Click);
            // 
            // lblTrongSoAdd
            // 
            resources.ApplyResources(this.lblTrongSoAdd, "lblTrongSoAdd");
            this.lblTrongSoAdd.Name = "lblTrongSoAdd";
            this.lblTrongSoAdd.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            // 
            // lblDinhTruocAdd
            // 
            resources.ApplyResources(this.lblDinhTruocAdd, "lblDinhTruocAdd");
            this.lblDinhTruocAdd.Name = "lblDinhTruocAdd";
            this.lblDinhTruocAdd.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            // 
            // lblDinhSauAdd
            // 
            resources.ApplyResources(this.lblDinhSauAdd, "lblDinhSauAdd");
            this.lblDinhSauAdd.Name = "lblDinhSauAdd";
            this.lblDinhSauAdd.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            // 
            // txtTrongSoThemCanh
            // 
            // 
            // 
            // 
            this.txtTrongSoThemCanh.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image4")));
            this.txtTrongSoThemCanh.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode4")));
            this.txtTrongSoThemCanh.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location4")));
            this.txtTrongSoThemCanh.CustomButton.Name = "";
            this.txtTrongSoThemCanh.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size4")));
            this.txtTrongSoThemCanh.CustomButton.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Blue;
            this.txtTrongSoThemCanh.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex4")));
            this.txtTrongSoThemCanh.CustomButton.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            this.txtTrongSoThemCanh.CustomButton.UseSelectable = true;
            this.txtTrongSoThemCanh.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible4")));
            this.txtTrongSoThemCanh.Lines = new string[0];
            resources.ApplyResources(this.txtTrongSoThemCanh, "txtTrongSoThemCanh");
            this.txtTrongSoThemCanh.MaxLength = 32767;
            this.txtTrongSoThemCanh.Multiline = true;
            this.txtTrongSoThemCanh.Name = "txtTrongSoThemCanh";
            this.txtTrongSoThemCanh.PasswordChar = '\0';
            this.txtTrongSoThemCanh.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTrongSoThemCanh.SelectedText = "";
            this.txtTrongSoThemCanh.SelectionLength = 0;
            this.txtTrongSoThemCanh.SelectionStart = 0;
            this.txtTrongSoThemCanh.ShortcutsEnabled = true;
            this.txtTrongSoThemCanh.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Light;
            this.txtTrongSoThemCanh.UseSelectable = true;
            this.txtTrongSoThemCanh.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTrongSoThemCanh.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtTrongSoThemCanh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTrongSoThemCanh_KeyPress);
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.grpChinhSua);
            this.panel1.Controls.Add(this.grpGiaoDienDoHoa);
            this.panel1.Controls.Add(this.grpThemDinhCanh);
            this.panel1.Controls.Add(this.grpMaTranVaKetQua);
            this.panel1.Controls.Add(this.grpChucNang);
            this.panel1.Name = "panel1";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabMain);
            this.Name = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.tabMain.ResumeLayout(false);
            this.tpFile.ResumeLayout(false);
            this.tpAbout.ResumeLayout(false);
            this.tabMatrix.ResumeLayout(false);
            this.tpMatrix1.ResumeLayout(false);
            this.tpMatrix2.ResumeLayout(false);
            this.grpMaTranVaKetQua.ResumeLayout(false);
            this.grpMaTranVaKetQua.PerformLayout();
            this.grpChinhSua.ResumeLayout(false);
            this.grpChinhSua.PerformLayout();
            this.grpGiaoDienDoHoa.ResumeLayout(false);
            this.grpGiaoDienDoHoa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picOutput)).EndInit();
            this.grpChucNang.ResumeLayout(false);
            this.grpChucNang.PerformLayout();
            this.grpThemDinhCanh.ResumeLayout(false);
            this.grpThemDinhCanh.PerformLayout();
            this.tabThemDinhCanh.ResumeLayout(false);
            this.tpAddVertex.ResumeLayout(false);
            this.tpAddEdge.ResumeLayout(false);
            this.tpAddEdge.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ReaLTaiizor.Controls.PoisonTabControl tabMain;
        private ReaLTaiizor.Controls.PoisonTabPage tpFile;
        private ReaLTaiizor.Controls.PoisonTabPage tpAbout;
        private ReaLTaiizor.Controls.AirTabPage tabMatrix;
        private System.Windows.Forms.TabPage tpMatrix1;
        private System.Windows.Forms.TabPage tpMatrix2;
        private ReaLTaiizor.Controls.RibbonGroupBox ribbonGroupBox1;
        private ReaLTaiizor.Controls.ParrotGroupBox grpMaTranVaKetQua;
        private ReaLTaiizor.Controls.PoisonLabel lblKetQua;
        private ReaLTaiizor.Controls.ParrotGroupBox grpChinhSua;
        private ReaLTaiizor.Controls.PoisonButton btnChinhSuaCanh;
        private ReaLTaiizor.Controls.PoisonLabel lblTrongSoEdit;
        private ReaLTaiizor.Controls.PoisonLabel lblDinhSauEdit;
        private ReaLTaiizor.Controls.PoisonTextBox txtTrongSoEdit;
        private ReaLTaiizor.Controls.PoisonTextBox txtDinhSauEdit;
        private ReaLTaiizor.Controls.ParrotGroupBox grpGiaoDienDoHoa;
        private ReaLTaiizor.Controls.ParrotGroupBox grpChucNang;
        private ReaLTaiizor.Controls.PoisonButton btnThucHien;
        private ReaLTaiizor.Controls.PoisonButton btnMoFile;
        private ReaLTaiizor.Controls.PoisonLabel lblDinhTruocEdit;
        private ReaLTaiizor.Controls.PoisonTextBox txtDinhTruocEdit;
        public ReaLTaiizor.Controls.PoisonListView lstInputWM;
        private ReaLTaiizor.Controls.ParrotGroupBox grpThemDinhCanh;
        private ReaLTaiizor.Controls.MaterialShowTabControl tabThemDinhCanh;
        private System.Windows.Forms.TabPage tpAddVertex;
        private System.Windows.Forms.TabPage tpAddEdge;
        private ReaLTaiizor.Controls.PoisonButton btnThemCanh;
        private ReaLTaiizor.Controls.PoisonLabel lblTrongSoAdd;
        private ReaLTaiizor.Controls.PoisonLabel lblDinhSauAdd;
        public ReaLTaiizor.Controls.PoisonListView lstInputAM;
        public System.Windows.Forms.PictureBox picOutput;
        private ReaLTaiizor.Controls.PoisonButton btnThemDinh;
        private ReaLTaiizor.Controls.AloneComboBox cboDinhTruoc;
        private ReaLTaiizor.Controls.AloneComboBox cboDinhSau;
        private ReaLTaiizor.Controls.PoisonTextBox txtTrongSoThemCanh;
        private ReaLTaiizor.Controls.PoisonButton btnXoaCanh;
        private ReaLTaiizor.Controls.MetroLabel lblEditEdge;
        private ReaLTaiizor.Controls.MetroLabel lblEditVertex;
        private ReaLTaiizor.Controls.PoisonButton btnXoaDinhEdit;
        private ReaLTaiizor.Controls.PoisonLabel lblDinhEdit;
        private ReaLTaiizor.Controls.PoisonTextBox txtDinhEdit;
        private ReaLTaiizor.Controls.AloneComboBox cboDinhBatDau;
        private ReaLTaiizor.Controls.PoisonLabel lblDinhBatDauChucNang;
        public ReaLTaiizor.Controls.HopeRichTextBox txtKetQua;
        private ReaLTaiizor.Controls.PoisonButton btnLuuFile;
        private ReaLTaiizor.Controls.PoisonButton btnLuuDoThi;
        private ReaLTaiizor.Controls.PoisonButton btnAboutUs;
        private ReaLTaiizor.Controls.MetroLabel lblPrimChucNang;
        private ReaLTaiizor.Controls.PoisonLabel lblDinhTruocAdd;
        private System.Windows.Forms.Panel panel1;
    }
}

