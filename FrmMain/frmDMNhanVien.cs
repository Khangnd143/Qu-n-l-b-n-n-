using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmMain
{
    public partial class frmDMNhanVien : Form
    {
        public frmDMNhanVien()
        {
            InitializeComponent();
        }

        private void frmDMNhanVien_Load(object sender, EventArgs e)
        {
            LoadDTGV_Nhan_Vien();
            FisrtMode(); 
        }
        private void FisrtMode()
        {
            txtMaNhanVien.Enabled = false;
            txtTenNhanVien.Enabled = false;
            txtDiaChi.Enabled = false;
            txtDienThoai.Enabled = false;

            dtpNgaySinh.Enabled = false;
            rbtnNam.Enabled = false;
            rbtnNu.Enabled = false;

            btnThemNV.Enabled = true;
            btnSuaNV.Enabled = true;
            btnXoaNV.Enabled = true;
            btnBoQuaNV.Enabled = false;
            btnLuuNV.Enabled = false;
            rbtnNam.Checked = false;
            rbtnNu.Checked = false;
            rbtnNam.Enabled = false;
            rbtnNu.Enabled = false;
        }

        private void LoadDTGV_Nhan_Vien()
        {
            QLBanMonAnClassesDataContext db = new QLBanMonAnClassesDataContext();
            DTGV_Nhan_Vien.DataSource = db.NhanViens;
            
            DTGV_Nhan_Vien.Columns[0].HeaderText = "Mã nhân viên";
            DTGV_Nhan_Vien.Columns[1].HeaderText = "Tên nhân viên";
            DTGV_Nhan_Vien.Columns[2].HeaderText = "Giới tính";
            DTGV_Nhan_Vien.Columns[3].HeaderText = "Địa chỉ";
            DTGV_Nhan_Vien.Columns[4].HeaderText = "Số điện thoại";
            DTGV_Nhan_Vien.Columns[5].HeaderText = "Ngày Sinh";

            DTGV_Nhan_Vien.Columns[0].Width = 100;
            DTGV_Nhan_Vien.Columns[1].Width = 150;
            DTGV_Nhan_Vien.Columns[2].Width = 100;
            DTGV_Nhan_Vien.Columns[3].Width = 150;
            DTGV_Nhan_Vien.Columns[4].Width = 100;
            DTGV_Nhan_Vien.Columns[5].Width = 100;

        }
        string flag = "";
        private void ResetValue()
        {
            txtMaNhanVien.Text = "";
            txtTenNhanVien.Text = "";
            txtDienThoai.Text = "";
            txtDiaChi.Text = "";
            dtpNgaySinh.Value = DateTime.Now;
        }

        private void btnLuuCl_Click(object sender, EventArgs e)
        {
            
        }
        private void insertNV()
        {
            QLBanMonAnClassesDataContext db = new QLBanMonAnClassesDataContext();
            if (txtMaNhanVien.Text == "")
            {
                MessageBox.Show("Mời nhập Mã Nhân viên!");
                txtMaNhanVien.Focus();
                return ;
            }
            if (txtTenNhanVien.Text == "")
            {
                MessageBox.Show("Mời nhập Tên Nhân viên!");
                txtTenNhanVien.Focus();
                return;
            }
            if (txtDiaChi.Text == "")
            {
                MessageBox.Show("Mời nhập Địa chỉ Nhân viên!");
                txtDiaChi.Focus();
                return;
            }
            if (txtDienThoai.Text == "")
            {
                MessageBox.Show("Mời nhập Số điện thoại Nhân viên!");
                txtDienThoai.Focus();
                return;
            }
            if (rbtnNam.Checked == false && rbtnNu.Checked == false)
            {
                MessageBox.Show("Mời chọn giới tính Nhân viên!");
                return;
            }
            if (dtpNgaySinh.Value == DateTime.Now)
            {
                MessageBox.Show("Mời chọn ngày sinh Nhân viên!");
                dtpNgaySinh.Focus();
                return;
            }

            NhanVien nv1 = db.NhanViens.Where(p => p.MaNhanVien == txtMaNhanVien.Text).SingleOrDefault();
            if (nv1 != null)
            {
                MessageBox.Show("Mã Nhân viên này đã có ! Bạn phải nhập mã khác !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNhanVien.Focus();
                return;
            }
            else
            {
                NhanVien nv = new NhanVien();
                nv.MaNhanVien = txtMaNhanVien.Text;
                nv.TenNhanVien = txtTenNhanVien.Text;
                nv.DiaChi = txtDiaChi.Text;
                nv.DienThoai = txtDienThoai.Text;

                nv.NgaySinh = dtpNgaySinh.Value;
                if (rbtnNam.Checked == true) nv.GioiTinh = "Nam";
                else nv.GioiTinh = "Nữ";
                db.NhanViens.InsertOnSubmit(nv);
                db.SubmitChanges();
            }
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            btnSuaNV.Enabled = false;
            btnXoaNV.Enabled = false;
            btnBoQuaNV.Enabled = true;
            btnLuuNV.Enabled = true;

            txtMaNhanVien.Enabled = true;
            txtTenNhanVien.Enabled = true;
            txtDiaChi.Enabled = true;
            txtDienThoai.Enabled = true;
            dtpNgaySinh.Enabled = true;
            rbtnNam.Enabled = true;
            rbtnNu.Enabled = true;

            ResetValue();
            txtMaNhanVien.Focus();
            flag = "Them";
        }

        private void btnLuuNV_Click(object sender, EventArgs e)
        {
            if (flag == "Them")
            {
                insertNV();
                LoadDTGV_Nhan_Vien();
                FisrtMode();
                ResetValue();
            }
            else if (flag == "Sua")
            {
                EditNhanVien();
                LoadDTGV_Nhan_Vien();
                FisrtMode();
                ResetValue();
            }
        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            if (txtMaNhanVien.Text == "" || txtTenNhanVien.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn dữ liệu nào ! Mời bạn click lên dữ liệu bạn muốn xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            btnSuaNV.Enabled = false;
            btnXoaNV.Enabled = true;
            btnBoQuaNV.Enabled = false;
            btnLuuNV.Enabled = false;

            txtMaNhanVien.Enabled = false;
            txtTenNhanVien.Enabled = false;
            txtDiaChi.Enabled = false;
            txtDienThoai.Enabled = false;
            dtpNgaySinh.Enabled = false;
            rbtnNam.Enabled = false;
            rbtnNu.Enabled = false;

            if (DialogResult.Yes == MessageBox.Show("Bạn muốn xóa " + txtTenNhanVien.Text + " ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                DeleteNV();
                LoadDTGV_Nhan_Vien();
                ResetValue();
                FisrtMode();
            }
        }

        private void DTGV_Nhan_Vien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                MessageBox.Show("Không có dữ liệu !");
            }
            else if (DTGV_Nhan_Vien.Rows[e.RowIndex].Cells[0].Value.ToString() == null)
            {
                MessageBox.Show("Không có dữ liệu !");
            }
            else
            {
                int index = e.RowIndex;
                string manv = DTGV_Nhan_Vien.Rows[index].Cells[0].Value.ToString();
                QLBanMonAnClassesDataContext db = new QLBanMonAnClassesDataContext();
                NhanVien nv = db.NhanViens.Where(p => p.MaNhanVien == manv).SingleOrDefault();
                txtMaNhanVien.Text = nv.MaNhanVien;
                txtTenNhanVien.Text = nv.TenNhanVien;
                txtDiaChi.Text = nv.DiaChi;
                txtDienThoai.Text = nv.DienThoai;
                dtpNgaySinh.Value = nv.NgaySinh.Value;
                if (nv.GioiTinh == "Nam") rbtnNam.Checked = true;
                else rbtnNu.Checked = true;
            }
        }
        private void EditNhanVien()
        {
            QLBanMonAnClassesDataContext db = new QLBanMonAnClassesDataContext();
            NhanVien nv = db.NhanViens.Where(p => p.MaNhanVien == txtMaNhanVien.Text).SingleOrDefault();
            nv.TenNhanVien = txtTenNhanVien.Text;
            nv.DiaChi = txtDiaChi.Text;
            nv.DienThoai = txtDienThoai.Text;
            nv.NgaySinh = dtpNgaySinh.Value;
            if (rbtnNam.Checked == true) nv.GioiTinh = "Nam";
            if (rbtnNu.Checked == true) nv.GioiTinh = "Nữ";
            db.SubmitChanges();
            LoadDTGV_Nhan_Vien();
        }

        private void DeleteNV()
        {
            QLBanMonAnClassesDataContext db = new QLBanMonAnClassesDataContext();
            NhanVien nv = db.NhanViens.Where(p => p.MaNhanVien == txtMaNhanVien.Text).SingleOrDefault();
            db.NhanViens.DeleteOnSubmit(nv);
            db.SubmitChanges();
        }

        private void btnThoatNV_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBoQuaNV_Click(object sender, EventArgs e)
        {
            ResetValue();
            FisrtMode();
        }

        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            if (txtMaNhanVien.Text == "" || txtTenNhanVien.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn dữ liệu nào ! Mời bạn click lên dữ liệu bạn muốn sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtTenNhanVien.Enabled = true;
            txtDiaChi.Enabled = true;
            txtDienThoai.Enabled = true;
            dtpNgaySinh.Enabled = true;
            rbtnNam.Enabled = true;
            rbtnNu.Enabled = true;
            btnThemNV.Enabled = false;
            btnXoaNV.Enabled = false;
            btnLuuNV.Enabled = true;
            btnBoQuaNV.Enabled = true;

            flag = "Sua";
        }

    }
}
