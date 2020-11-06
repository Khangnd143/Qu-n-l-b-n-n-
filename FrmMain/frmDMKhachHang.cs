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
    public partial class frmDMKhachMonAn : Form
    {
        public frmDMKhachMonAn()
        {
            InitializeComponent();
        }
        private void FisrtMode()
        {
            txtMaKH.Enabled = false;
            txtTenKH.Enabled = false;
            txtDiaChi.Enabled = false;
            txtDienThoai.Enabled = false;
            
            btnThemKH.Enabled = true;
            btnSuaKH.Enabled = true;
            btnXoaKH.Enabled = true;
            btnBoquaKH.Enabled = false;
            btnLuuKH.Enabled = false;
        }

        private void LoadDTGV_Khach_MonAn()
        {
            QLBanMonAnClassesDataContext db = new QLBanMonAnClassesDataContext();
            DTGV_Khach_MonAn.DataSource = db.Khaches;

            DTGV_Khach_MonAn.Columns[0].HeaderText = "Mã Khách hàng";
            DTGV_Khach_MonAn.Columns[1].HeaderText = "Tên Khách hàng";
            DTGV_Khach_MonAn.Columns[2].HeaderText = "Địa chỉ Khách hàng";
            DTGV_Khach_MonAn.Columns[3].HeaderText = "Điện thoại Khách hàng";

        }
        string flag = "";
        private void ResetValue()
        {
            txtMaKH.Text = "";
            txtTenKH.Text = "";
            txtDienThoai.Text = "";
            txtDiaChi.Text = "";
        }

        private void insertKH()
        {
            QLBanMonAnClassesDataContext db = new QLBanMonAnClassesDataContext();
            if (txtMaKH.Text == "")
            {
                MessageBox.Show("Mời nhập Mã Khách hàng!");
                txtMaKH.Focus();
                return;
            }
            if (txtTenKH.Text == "")
            {
                MessageBox.Show("Mời nhập Tên Khách hàng!");
                txtTenKH.Focus();
                return;
            }
            if (txtDiaChi.Text == "")
            {
                MessageBox.Show("Mời nhập Địa chỉ Khách hàng!");
                txtDiaChi.Focus();
                return;
            }
            if (txtDienThoai.Text == "")
            {
                MessageBox.Show("Mời nhập Số điện thoại Khách hàng!");
                txtDienThoai.Focus();
                return;
            }

            Khach kh1 = db.Khaches.Where(p => p.MaKhach == txtMaKH.Text).SingleOrDefault();
            if (kh1 != null)
            {
                MessageBox.Show("Mã Khách hàng này đã có ! Bạn phải nhập mã khác !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaKH.Focus();
                return;
            }
            Khach kh = new Khach();
            kh.MaKhach = txtMaKH.Text;
            kh.TenKhach = txtTenKH.Text;
            kh.DiaChiKH = txtDiaChi.Text;
            kh.DienThoaiKH = txtDienThoai.Text;
            db.Khaches.InsertOnSubmit(kh);
            db.SubmitChanges();
        }
        private void EditNhanVien()
        {
            QLBanMonAnClassesDataContext db = new QLBanMonAnClassesDataContext();
            Khach kh = db.Khaches.Where(p => p.MaKhach == txtMaKH.Text).SingleOrDefault();
            kh.TenKhach = txtTenKH.Text;
            kh.DiaChiKH = txtDiaChi.Text;
            kh.DienThoaiKH = txtDienThoai.Text;
            db.SubmitChanges();
            LoadDTGV_Khach_MonAn();
        }
        private void DeleteKH()
        {
            QLBanMonAnClassesDataContext db = new QLBanMonAnClassesDataContext();
            Khach kh = db.Khaches.Where(p => p.MaKhach == txtMaKH.Text).SingleOrDefault();
            db.Khaches.DeleteOnSubmit(kh);
            //using (QLBanMonAnClassesDataContext db = new QLBanMonAnClassesDataContext())
            //{
            //    QLBanMonAnClassesDataContext
            //}
            db.SubmitChanges();
        }
        private void btnLuuKh_Click(object sender, EventArgs e)
        {
            if (flag == "Them")
            {
                insertKH();
                LoadDTGV_Khach_MonAn();
                FisrtMode();
                ResetValue();
            }
            else if (flag == "Sua")
            {
                EditNhanVien();
                LoadDTGV_Khach_MonAn();
                FisrtMode();
                ResetValue();
            }
        }
        private void frmDMKhachMonAn_Load(object sender, EventArgs e)
        {
            LoadDTGV_Khach_MonAn();
            FisrtMode();
        }
        private void btnThemKH_Click(object sender, EventArgs e)
        {
            btnSuaKH.Enabled = false;
            btnXoaKH.Enabled = false;
            btnBoquaKH.Enabled = true;
            btnLuuKH.Enabled = true;

            txtMaKH.Enabled = true;
            txtTenKH.Enabled = true;
            txtDiaChi.Enabled = true;
            txtDienThoai.Enabled = true;

            ResetValue();
            txtMaKH.Focus();
            flag = "Them";
        }
        private void btnXoaKH_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text == "" || txtTenKH.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn dữ liệu nào ! Mời bạn click lên dữ liệu bạn muốn xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            btnSuaKH.Enabled = false;
            btnXoaKH.Enabled = true;
            btnBoquaKH.Enabled = false;
            btnLuuKH.Enabled = false;

            txtMaKH.Enabled = false;
            txtTenKH.Enabled = false;
            txtDiaChi.Enabled = false;
            txtDienThoai.Enabled = false;
            if (DialogResult.Yes == MessageBox.Show("Bạn muốn xóa " + txtTenKH.Text + " ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                DeleteKH();
                LoadDTGV_Khach_MonAn();
                ResetValue();
                FisrtMode();
            }
        }
        private void DTGV_Khach_MonAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                MessageBox.Show("Không có dữ liệu !");
            }
            else if (DTGV_Khach_MonAn.Rows[e.RowIndex].Cells[0].Value.ToString() == null)
            {
                MessageBox.Show("Không có dữ liệu !");
            }
            else
            {
                int index = e.RowIndex;
                string makh = DTGV_Khach_MonAn.Rows[index].Cells[0].Value.ToString();
                QLBanMonAnClassesDataContext db = new QLBanMonAnClassesDataContext();
                Khach kh = db.Khaches.Where(p => p.MaKhach == makh).SingleOrDefault();
                txtMaKH.Text = kh.MaKhach;
                txtTenKH.Text = kh.TenKhach;
                txtDiaChi.Text = kh.DiaChiKH;
                txtDienThoai.Text = kh.DienThoaiKH;
            }
        }

        private void btnSuaKH_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text == "" || txtTenKH.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn dữ liệu nào ! Mời bạn click lên dữ liệu bạn muốn sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtTenKH.Enabled = true;
            txtDiaChi.Enabled = true;
            txtDienThoai.Enabled = true;
            btnThemKH.Enabled = false;
            btnXoaKH.Enabled = false;
            btnLuuKH.Enabled = true;
            btnBoquaKH.Enabled = true;
            flag = "Sua";
        }
        private void btnBoquaKH_Click(object sender, EventArgs e)
        {
            ResetValue();
            FisrtMode();
        }
        private void btnDongKH_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
