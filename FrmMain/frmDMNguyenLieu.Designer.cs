namespace FrmMain
{
    partial class frmDMNguyenLieu
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
            this.txtMaNguyenLieu = new System.Windows.Forms.TextBox();
            this.txtTenNguyenLieu = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThoatCL = new System.Windows.Forms.Button();
            this.btnBoQuaCL = new System.Windows.Forms.Button();
            this.btnLuuCl = new System.Windows.Forms.Button();
            this.btnSuaCL = new System.Windows.Forms.Button();
            this.btnXoaCL = new System.Windows.Forms.Button();
            this.btnThemCL = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(79, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH MỤC NGUYÊN LIỆU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Nguyên Liệu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 53);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên Nguyên  Liệu";
            // 
            // txtMaNguyenLieu
            // 
            this.txtMaNguyenLieu.Location = new System.Drawing.Point(151, 17);
            this.txtMaNguyenLieu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaNguyenLieu.Name = "txtMaNguyenLieu";
            this.txtMaNguyenLieu.Size = new System.Drawing.Size(189, 20);
            this.txtMaNguyenLieu.TabIndex = 3;
            this.txtMaNguyenLieu.TextChanged += new System.EventHandler(this.txtMaNguyenLieu_TextChanged);
            // 
            // txtTenNguyenLieu
            // 
            this.txtTenNguyenLieu.Location = new System.Drawing.Point(151, 52);
            this.txtTenNguyenLieu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTenNguyenLieu.Name = "txtTenNguyenLieu";
            this.txtTenNguyenLieu.Size = new System.Drawing.Size(189, 20);
            this.txtTenNguyenLieu.TabIndex = 3;
            this.txtTenNguyenLieu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTenNguyenLieu_KeyDown);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 133);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(507, 109);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMaNguyenLieu);
            this.groupBox1.Controls.Add(this.txtTenNguyenLieu);
            this.groupBox1.Location = new System.Drawing.Point(8, 50);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(507, 79);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // btnThoatCL
            // 
            this.btnThoatCL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoatCL.Image = global::FrmMain.Properties.Resources._211650_32;
            this.btnThoatCL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoatCL.Location = new System.Drawing.Point(435, 265);
            this.btnThoatCL.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThoatCL.Name = "btnThoatCL";
            this.btnThoatCL.Size = new System.Drawing.Size(82, 36);
            this.btnThoatCL.TabIndex = 11;
            this.btnThoatCL.Text = "&Thoát";
            this.btnThoatCL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoatCL.UseVisualStyleBackColor = true;
            this.btnThoatCL.Click += new System.EventHandler(this.btnThoatCL_Click);
            // 
            // btnBoQuaCL
            // 
            this.btnBoQuaCL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoQuaCL.Image = global::FrmMain.Properties.Resources._211889_32;
            this.btnBoQuaCL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBoQuaCL.Location = new System.Drawing.Point(345, 265);
            this.btnBoQuaCL.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBoQuaCL.Name = "btnBoQuaCL";
            this.btnBoQuaCL.Size = new System.Drawing.Size(87, 36);
            this.btnBoQuaCL.TabIndex = 10;
            this.btnBoQuaCL.Text = "&Bỏ qua";
            this.btnBoQuaCL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBoQuaCL.UseVisualStyleBackColor = true;
            this.btnBoQuaCL.Click += new System.EventHandler(this.btnBoQuaCL_Click);
            // 
            // btnLuuCl
            // 
            this.btnLuuCl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuCl.Image = global::FrmMain.Properties.Resources._352084_32;
            this.btnLuuCl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuuCl.Location = new System.Drawing.Point(261, 265);
            this.btnLuuCl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLuuCl.Name = "btnLuuCl";
            this.btnLuuCl.Size = new System.Drawing.Size(75, 36);
            this.btnLuuCl.TabIndex = 9;
            this.btnLuuCl.Text = "&Lưu";
            this.btnLuuCl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuuCl.UseVisualStyleBackColor = true;
            this.btnLuuCl.Click += new System.EventHandler(this.btnLuuCl_Click);
            this.btnLuuCl.Enter += new System.EventHandler(this.btnLuuCl_Click);
            // 
            // btnSuaCL
            // 
            this.btnSuaCL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaCL.Image = global::FrmMain.Properties.Resources._126582_241;
            this.btnSuaCL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaCL.Location = new System.Drawing.Point(176, 265);
            this.btnSuaCL.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSuaCL.Name = "btnSuaCL";
            this.btnSuaCL.Size = new System.Drawing.Size(75, 36);
            this.btnSuaCL.TabIndex = 8;
            this.btnSuaCL.Text = "&Sửa";
            this.btnSuaCL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuaCL.UseVisualStyleBackColor = true;
            this.btnSuaCL.Click += new System.EventHandler(this.btnSuaCL_Click);
            // 
            // btnXoaCL
            // 
            this.btnXoaCL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaCL.Image = global::FrmMain.Properties.Resources._5416293_32;
            this.btnXoaCL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaCL.Location = new System.Drawing.Point(85, 265);
            this.btnXoaCL.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXoaCL.Name = "btnXoaCL";
            this.btnXoaCL.Size = new System.Drawing.Size(80, 36);
            this.btnXoaCL.TabIndex = 7;
            this.btnXoaCL.Text = "&Xóa";
            this.btnXoaCL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaCL.UseVisualStyleBackColor = true;
            this.btnXoaCL.Click += new System.EventHandler(this.btnXoaCL_Click);
            // 
            // btnThemCL
            // 
            this.btnThemCL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemCL.Image = global::FrmMain.Properties.Resources._126583_24__2_;
            this.btnThemCL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemCL.Location = new System.Drawing.Point(5, 265);
            this.btnThemCL.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThemCL.Name = "btnThemCL";
            this.btnThemCL.Size = new System.Drawing.Size(75, 36);
            this.btnThemCL.TabIndex = 5;
            this.btnThemCL.Text = "&Thêm";
            this.btnThemCL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemCL.UseVisualStyleBackColor = true;
            this.btnThemCL.Click += new System.EventHandler(this.btnThemCL_Click);
            // 
            // frmDMNguyenLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 342);
            this.Controls.Add(this.btnThoatCL);
            this.Controls.Add(this.btnBoQuaCL);
            this.Controls.Add(this.btnLuuCl);
            this.Controls.Add(this.btnSuaCL);
            this.Controls.Add(this.btnXoaCL);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnThemCL);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmDMNguyenLieu";
            this.Text = "DANH MỤC NGUYÊN LIỆU";
            this.Load += new System.EventHandler(this.frmDMNguyenLieu_Load);
            this.Enter += new System.EventHandler(this.btnLuuCl_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaNguyenLieu;
        private System.Windows.Forms.TextBox txtTenNguyenLieu;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnThemCL;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnXoaCL;
        private System.Windows.Forms.Button btnSuaCL;
        private System.Windows.Forms.Button btnLuuCl;
        private System.Windows.Forms.Button btnBoQuaCL;
        private System.Windows.Forms.Button btnThoatCL;
    }
}