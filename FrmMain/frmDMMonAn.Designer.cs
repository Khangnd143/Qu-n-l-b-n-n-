namespace FrmMain
{
    partial class frmDMMonAnHoa
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMaHH = new System.Windows.Forms.TextBox();
            this.txtTenHH = new System.Windows.Forms.TextBox();
            this.txtSoLuongHH = new System.Windows.Forms.TextBox();
            this.txtDonGiaNhapHH = new System.Windows.Forms.TextBox();
            this.txtDonGiaBanHH = new System.Windows.Forms.TextBox();
            this.txtAnhHH = new System.Windows.Forms.TextBox();
            this.txtGhiChuHH = new System.Windows.Forms.TextBox();
            this.DTGV_MonAn_Hoa = new System.Windows.Forms.DataGridView();
            this.MaMonAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMonAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNguyenLieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGiaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Anh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMo = new System.Windows.Forms.Button();
            this.cbbTenNguyenLieuHH = new System.Windows.Forms.ComboBox();
            this.PbAnhHH = new System.Windows.Forms.PictureBox();
            this.btnTimKiemHH = new System.Windows.Forms.Button();
            this.btnDongHH = new System.Windows.Forms.Button();
            this.btnBoquaHH = new System.Windows.Forms.Button();
            this.btnLuuHH = new System.Windows.Forms.Button();
            this.btnSuaHH = new System.Windows.Forms.Button();
            this.btnXoaHH = new System.Windows.Forms.Button();
            this.btnThemHH = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DTGV_MonAn_Hoa)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbAnhHH)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(245, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH MỤC MÓN ĂN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(6, 187);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Đơn giá bán";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(6, 35);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã Món";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(6, 62);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên món";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(6, 90);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tên nguyên liệu chính";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(323, 129);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ghi chú";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(331, 40);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Ảnh";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(6, 151);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(170, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Đơn giá nhập nguyên liệu";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(6, 120);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Số lượng";
            // 
            // txtMaHH
            // 
            this.txtMaHH.Location = new System.Drawing.Point(97, 31);
            this.txtMaHH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaHH.Name = "txtMaHH";
            this.txtMaHH.Size = new System.Drawing.Size(222, 23);
            this.txtMaHH.TabIndex = 1;
            // 
            // txtTenHH
            // 
            this.txtTenHH.Location = new System.Drawing.Point(97, 62);
            this.txtTenHH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTenHH.Name = "txtTenHH";
            this.txtTenHH.Size = new System.Drawing.Size(222, 23);
            this.txtTenHH.TabIndex = 1;
            // 
            // txtSoLuongHH
            // 
            this.txtSoLuongHH.Location = new System.Drawing.Point(97, 120);
            this.txtSoLuongHH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSoLuongHH.Name = "txtSoLuongHH";
            this.txtSoLuongHH.Size = new System.Drawing.Size(222, 23);
            this.txtSoLuongHH.TabIndex = 1;
            // 
            // txtDonGiaNhapHH
            // 
            this.txtDonGiaNhapHH.Location = new System.Drawing.Point(180, 151);
            this.txtDonGiaNhapHH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDonGiaNhapHH.Name = "txtDonGiaNhapHH";
            this.txtDonGiaNhapHH.Size = new System.Drawing.Size(139, 23);
            this.txtDonGiaNhapHH.TabIndex = 1;
            // 
            // txtDonGiaBanHH
            // 
            this.txtDonGiaBanHH.Location = new System.Drawing.Point(97, 185);
            this.txtDonGiaBanHH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDonGiaBanHH.Name = "txtDonGiaBanHH";
            this.txtDonGiaBanHH.Size = new System.Drawing.Size(222, 23);
            this.txtDonGiaBanHH.TabIndex = 1;
            // 
            // txtAnhHH
            // 
            this.txtAnhHH.Location = new System.Drawing.Point(384, 29);
            this.txtAnhHH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAnhHH.Multiline = true;
            this.txtAnhHH.Name = "txtAnhHH";
            this.txtAnhHH.Size = new System.Drawing.Size(161, 51);
            this.txtAnhHH.TabIndex = 1;
            // 
            // txtGhiChuHH
            // 
            this.txtGhiChuHH.Location = new System.Drawing.Point(384, 94);
            this.txtGhiChuHH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtGhiChuHH.Multiline = true;
            this.txtGhiChuHH.Name = "txtGhiChuHH";
            this.txtGhiChuHH.Size = new System.Drawing.Size(241, 108);
            this.txtGhiChuHH.TabIndex = 3;
            // 
            // DTGV_MonAn_Hoa
            // 
            this.DTGV_MonAn_Hoa.AllowUserToAddRows = false;
            this.DTGV_MonAn_Hoa.AllowUserToDeleteRows = false;
            this.DTGV_MonAn_Hoa.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DTGV_MonAn_Hoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGV_MonAn_Hoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaMonAn,
            this.TenMonAn,
            this.MaNguyenLieu,
            this.SoLuong,
            this.DonGiaNhap,
            this.DonGiaBan,
            this.Anh,
            this.GhiChu});
            this.DTGV_MonAn_Hoa.Location = new System.Drawing.Point(16, 286);
            this.DTGV_MonAn_Hoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DTGV_MonAn_Hoa.Name = "DTGV_MonAn_Hoa";
            this.DTGV_MonAn_Hoa.ReadOnly = true;
            this.DTGV_MonAn_Hoa.RowTemplate.Height = 28;
            this.DTGV_MonAn_Hoa.Size = new System.Drawing.Size(939, 120);
            this.DTGV_MonAn_Hoa.TabIndex = 4;
            this.DTGV_MonAn_Hoa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DTGV_MonAn_Hoa_CellClick);
            this.DTGV_MonAn_Hoa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DTGV_MonAn_Hoa_CellContentClick);
            // 
            // MaMonAn
            // 
            this.MaMonAn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MaMonAn.DataPropertyName = "MaMonAn";
            this.MaMonAn.HeaderText = "Mã Hàng";
            this.MaMonAn.Name = "MaMonAn";
            this.MaMonAn.ReadOnly = true;
            this.MaMonAn.Width = 76;
            // 
            // TenMonAn
            // 
            this.TenMonAn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TenMonAn.DataPropertyName = "TenMonAn";
            this.TenMonAn.HeaderText = "Tên Hàng";
            this.TenMonAn.Name = "TenMonAn";
            this.TenMonAn.ReadOnly = true;
            this.TenMonAn.Width = 80;
            // 
            // MaNguyenLieu
            // 
            this.MaNguyenLieu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MaNguyenLieu.DataPropertyName = "NguyenLieu";
            this.MaNguyenLieu.HeaderText = "Chất Liệu";
            this.MaNguyenLieu.Name = "MaNguyenLieu";
            this.MaNguyenLieu.ReadOnly = true;
            this.MaNguyenLieu.Width = 77;
            // 
            // SoLuong
            // 
            this.SoLuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            this.SoLuong.Width = 78;
            // 
            // DonGiaNhap
            // 
            this.DonGiaNhap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DonGiaNhap.DataPropertyName = "DonGiaNhap";
            this.DonGiaNhap.HeaderText = "Đơn giá nhập";
            this.DonGiaNhap.Name = "DonGiaNhap";
            this.DonGiaNhap.ReadOnly = true;
            this.DonGiaNhap.Width = 96;
            // 
            // DonGiaBan
            // 
            this.DonGiaBan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DonGiaBan.DataPropertyName = "DonGiaBan";
            this.DonGiaBan.HeaderText = "Đơn giá bán";
            this.DonGiaBan.Name = "DonGiaBan";
            this.DonGiaBan.ReadOnly = true;
            this.DonGiaBan.Width = 90;
            // 
            // Anh
            // 
            this.Anh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Anh.DataPropertyName = "Anh";
            this.Anh.HeaderText = "Ảnh";
            this.Anh.Name = "Anh";
            this.Anh.ReadOnly = true;
            this.Anh.Width = 51;
            // 
            // GhiChu
            // 
            this.GhiChu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GhiChu.DataPropertyName = "GhiChu";
            this.GhiChu.HeaderText = "Ghi chú";
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMo);
            this.groupBox1.Controls.Add(this.cbbTenNguyenLieuHH);
            this.groupBox1.Controls.Add(this.PbAnhHH);
            this.groupBox1.Controls.Add(this.txtAnhHH);
            this.groupBox1.Controls.Add(this.txtDonGiaBanHH);
            this.groupBox1.Controls.Add(this.txtGhiChuHH);
            this.groupBox1.Controls.Add(this.txtDonGiaNhapHH);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSoLuongHH);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTenHH);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtMaHH);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.ForestGreen;
            this.groupBox1.Location = new System.Drawing.Point(15, 61);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(939, 225);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "THÔNG TIN CHI TIẾT";
            // 
            // btnMo
            // 
            this.btnMo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMo.Image = global::FrmMain.Properties.Resources._1493293_32;
            this.btnMo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMo.Location = new System.Drawing.Point(548, 35);
            this.btnMo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMo.Name = "btnMo";
            this.btnMo.Size = new System.Drawing.Size(70, 37);
            this.btnMo.TabIndex = 5;
            this.btnMo.Text = "Mở";
            this.btnMo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMo.UseVisualStyleBackColor = true;
            this.btnMo.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbbTenNguyenLieuHH
            // 
            this.cbbTenNguyenLieuHH.FormattingEnabled = true;
            this.cbbTenNguyenLieuHH.Location = new System.Drawing.Point(158, 88);
            this.cbbTenNguyenLieuHH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbbTenNguyenLieuHH.Name = "cbbTenNguyenLieuHH";
            this.cbbTenNguyenLieuHH.Size = new System.Drawing.Size(161, 24);
            this.cbbTenNguyenLieuHH.TabIndex = 4;
            // 
            // PbAnhHH
            // 
            this.PbAnhHH.Location = new System.Drawing.Point(629, 16);
            this.PbAnhHH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PbAnhHH.Name = "PbAnhHH";
            this.PbAnhHH.Size = new System.Drawing.Size(292, 191);
            this.PbAnhHH.TabIndex = 2;
            this.PbAnhHH.TabStop = false;
            this.PbAnhHH.Click += new System.EventHandler(this.PbAnhHH_Click);
            // 
            // btnTimKiemHH
            // 
            this.btnTimKiemHH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemHH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiemHH.Location = new System.Drawing.Point(693, 411);
            this.btnTimKiemHH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTimKiemHH.Name = "btnTimKiemHH";
            this.btnTimKiemHH.Size = new System.Drawing.Size(107, 36);
            this.btnTimKiemHH.TabIndex = 6;
            this.btnTimKiemHH.Text = "&Tìm kiếm";
            this.btnTimKiemHH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiemHH.UseVisualStyleBackColor = true;
            this.btnTimKiemHH.Click += new System.EventHandler(this.btnTimKiemHH_Click);
            // 
            // btnDongHH
            // 
            this.btnDongHH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDongHH.Image = global::FrmMain.Properties.Resources._211650_32;
            this.btnDongHH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDongHH.Location = new System.Drawing.Point(837, 411);
            this.btnDongHH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDongHH.Name = "btnDongHH";
            this.btnDongHH.Size = new System.Drawing.Size(96, 36);
            this.btnDongHH.TabIndex = 6;
            this.btnDongHH.Text = "&Đóng";
            this.btnDongHH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDongHH.UseVisualStyleBackColor = true;
            this.btnDongHH.Click += new System.EventHandler(this.btnDongHH_Click);
            // 
            // btnBoquaHH
            // 
            this.btnBoquaHH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoquaHH.Image = global::FrmMain.Properties.Resources._211889_32;
            this.btnBoquaHH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBoquaHH.Location = new System.Drawing.Point(560, 411);
            this.btnBoquaHH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBoquaHH.Name = "btnBoquaHH";
            this.btnBoquaHH.Size = new System.Drawing.Size(96, 36);
            this.btnBoquaHH.TabIndex = 6;
            this.btnBoquaHH.Text = "&Bỏ qua";
            this.btnBoquaHH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBoquaHH.UseVisualStyleBackColor = true;
            this.btnBoquaHH.Click += new System.EventHandler(this.btnBoquaHH_Click);
            // 
            // btnLuuHH
            // 
            this.btnLuuHH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuHH.Image = global::FrmMain.Properties.Resources._352084_24;
            this.btnLuuHH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuuHH.Location = new System.Drawing.Point(437, 411);
            this.btnLuuHH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLuuHH.Name = "btnLuuHH";
            this.btnLuuHH.Size = new System.Drawing.Size(91, 36);
            this.btnLuuHH.TabIndex = 6;
            this.btnLuuHH.Text = "&Lưu";
            this.btnLuuHH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuuHH.UseVisualStyleBackColor = true;
            this.btnLuuHH.Click += new System.EventHandler(this.btnLuuHH_Click);
            // 
            // btnSuaHH
            // 
            this.btnSuaHH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaHH.Image = global::FrmMain.Properties.Resources._126582_241;
            this.btnSuaHH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaHH.Location = new System.Drawing.Point(309, 411);
            this.btnSuaHH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSuaHH.Name = "btnSuaHH";
            this.btnSuaHH.Size = new System.Drawing.Size(96, 36);
            this.btnSuaHH.TabIndex = 6;
            this.btnSuaHH.Text = "&Sửa";
            this.btnSuaHH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuaHH.UseVisualStyleBackColor = true;
            this.btnSuaHH.Click += new System.EventHandler(this.btnSuaHH_Click);
            // 
            // btnXoaHH
            // 
            this.btnXoaHH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaHH.Image = global::FrmMain.Properties.Resources._5416293_32;
            this.btnXoaHH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaHH.Location = new System.Drawing.Point(192, 411);
            this.btnXoaHH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXoaHH.Name = "btnXoaHH";
            this.btnXoaHH.Size = new System.Drawing.Size(96, 36);
            this.btnXoaHH.TabIndex = 6;
            this.btnXoaHH.Text = "&Xóa";
            this.btnXoaHH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaHH.UseVisualStyleBackColor = true;
            this.btnXoaHH.Click += new System.EventHandler(this.btnXoaHH_Click);
            // 
            // btnThemHH
            // 
            this.btnThemHH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemHH.Image = global::FrmMain.Properties.Resources._126583_24__2_;
            this.btnThemHH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemHH.Location = new System.Drawing.Point(59, 411);
            this.btnThemHH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThemHH.Name = "btnThemHH";
            this.btnThemHH.Size = new System.Drawing.Size(91, 36);
            this.btnThemHH.TabIndex = 6;
            this.btnThemHH.Text = "&Thêm";
            this.btnThemHH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemHH.UseVisualStyleBackColor = true;
            this.btnThemHH.Click += new System.EventHandler(this.btnThemHH_Click);
            // 
            // frmDMMonAnHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(913, 471);
            this.Controls.Add(this.btnDongHH);
            this.Controls.Add(this.btnTimKiemHH);
            this.Controls.Add(this.btnBoquaHH);
            this.Controls.Add(this.btnLuuHH);
            this.Controls.Add(this.btnSuaHH);
            this.Controls.Add(this.btnXoaHH);
            this.Controls.Add(this.btnThemHH);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DTGV_MonAn_Hoa);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmDMMonAnHoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DANH MỤC MÓN ĂN";
            this.Load += new System.EventHandler(this.frmDMMonAnHoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DTGV_MonAn_Hoa)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbAnhHH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMaHH;
        private System.Windows.Forms.TextBox txtTenHH;
        private System.Windows.Forms.TextBox txtSoLuongHH;
        private System.Windows.Forms.TextBox txtDonGiaNhapHH;
        private System.Windows.Forms.TextBox txtDonGiaBanHH;
        private System.Windows.Forms.TextBox txtAnhHH;
        private System.Windows.Forms.PictureBox PbAnhHH;
        private System.Windows.Forms.TextBox txtGhiChuHH;
        private System.Windows.Forms.DataGridView DTGV_MonAn_Hoa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbbTenNguyenLieuHH;
        private System.Windows.Forms.Button btnMo;
        private System.Windows.Forms.Button btnThemHH;
        private System.Windows.Forms.Button btnXoaHH;
        private System.Windows.Forms.Button btnSuaHH;
        private System.Windows.Forms.Button btnLuuHH;
        private System.Windows.Forms.Button btnBoquaHH;
        private System.Windows.Forms.Button btnTimKiemHH;
        private System.Windows.Forms.Button btnDongHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMonAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMonAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNguyenLieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGiaNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Anh;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
    }
}