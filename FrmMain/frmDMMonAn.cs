using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace FrmMain
{
    public partial class frmDMMonAnHoa : Form
    {
        public frmDMMonAnHoa()
        {
            InitializeComponent();
        }
        string flag = "";
        private void frmDMMonAnHoa_Load(object sender, EventArgs e)
        {
            LoadDTGV_MonAn_Hoa();
            LoadCBB_Chat_Lieu();
            ResetValue();
            FisrtMode();
        }

        private void ResetValue()
        {
            txtAnhHH.Text = "";
            txtDonGiaBanHH.Text = "0";
            txtDonGiaNhapHH.Text = "0";
            txtGhiChuHH.Text = "";
            txtMaHH.Text = "";
            txtSoLuongHH.Text = "0";
            txtTenHH.Text = "";
            cbbTenNguyenLieuHH.Text = "";
            PbAnhHH.Image = null;
        }

        private void FisrtMode()
        {
            txtAnhHH.Enabled = false;
            txtDonGiaBanHH.Enabled = false;
            txtDonGiaNhapHH.Enabled = false;
            txtGhiChuHH.Enabled = false;
            txtMaHH.Enabled = false;
            txtSoLuongHH.Enabled = false;
            txtTenHH.Enabled = false;

            btnBoquaHH.Enabled = false;
            btnLuuHH.Enabled = false;
            btnSuaHH.Enabled = true;
            btnThemHH.Enabled = true;
            btnXoaHH.Enabled = true;
        }

        private void LoadCBB_Chat_Lieu()
        {
            QLBanMonAnClassesDataContext db = new QLBanMonAnClassesDataContext();
            cbbTenNguyenLieuHH.DataSource = db.NguyenLieus;
            cbbTenNguyenLieuHH.DisplayMember = "TenNguyenLieu";
            cbbTenNguyenLieuHH.ValueMember = "MaNguyenLieu";
        }

        private void LoadDTGV_MonAn_Hoa()
        {
            QLBanMonAnClassesDataContext db = new QLBanMonAnClassesDataContext();
            DTGV_MonAn_Hoa.DataSource = db.MonAns.OrderBy(p => p.MaMonAn)
                .Select(p => new {
                    p.MaMonAn,
                    p.TenMonAn,
                    NguyenLieu=p.NguyenLieu.TenNguyenLieu,
                    p.SoLuong,
                    p.DonGiaNhap,
                    p.DonGiaBan,
                    p.Anh,
                    p.GhiChu,
                });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                PbAnhHH.Image = new Bitmap(open.FileName);
                PbAnhHH.SizeMode = PictureBoxSizeMode.StretchImage;
                txtAnhHH.Text = open.FileName;
            }
        }

        private void btnThemHH_Click(object sender, EventArgs e)
        {
            txtAnhHH.Enabled = true;
            txtDonGiaBanHH.Enabled = true;
            txtDonGiaNhapHH.Enabled = true;
            txtGhiChuHH.Enabled = true;
            txtMaHH.Enabled = true;
            txtSoLuongHH.Enabled = true;
            txtTenHH.Enabled = true;

            btnBoquaHH.Enabled = true;
            btnLuuHH.Enabled = true;
            btnSuaHH.Enabled = false;
            btnThemHH.Enabled = true;
            btnXoaHH.Enabled = false;

            ResetValue();
            txtMaHH.Focus();
            flag = "Them";
        }
        private void insertHH()
        {
            QLBanMonAnClassesDataContext db = new QLBanMonAnClassesDataContext();
            if (txtMaHH.Text == "")
            {
                MessageBox.Show("Mời nhập Mã Hàng hóa!");
                txtMaHH.Focus();
                return;
            }
            if (txtTenHH.Text == "")
            {
                MessageBox.Show("Mời nhập Tên Hàng hóa!");
                txtTenHH.Focus();
                return;
            }
            if (txtAnhHH.Text == "")
            {
                MessageBox.Show("Mời nhập Ảnh hàng hóa!");
                txtAnhHH.Focus();
                return;
            }
            if (txtSoLuongHH.Text == "")
            {
                MessageBox.Show("Mời nhập Số lượng hàng!");
                txtSoLuongHH.Focus();
                return;
            }

            MonAn hh1 = db.MonAns.Where(p => p.MaMonAn == txtMaHH.Text).SingleOrDefault();
            if (hh1 != null)
            {
                MessageBox.Show("Mã Khách hàng này đã có ! Bạn phải nhập mã khác !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaHH.Focus();
                return;
            }
            MonAn hh = new MonAn();
            hh.MaMonAn = txtMaHH.Text;
            hh.TenMonAn = txtTenHH.Text;
            hh.GhiChu = txtGhiChuHH.Text;
            hh.MaNguyenLieu = cbbTenNguyenLieuHH.SelectedValue.ToString();
            hh.SoLuong = double.Parse(txtSoLuongHH.Text);
            hh.DonGiaBan = double.Parse(txtDonGiaBanHH.Text);
            hh.DonGiaNhap = double.Parse(txtDonGiaNhapHH.Text);
            hh.GhiChu = txtGhiChuHH.Text;
            hh.Anh = txtAnhHH.Text;

            db.MonAns.InsertOnSubmit(hh);
            db.SubmitChanges();
        }

        private void btnLuuHH_Click(object sender, EventArgs e)
        {
            if (flag == "Them")
            {
                insertHH();
                LoadDTGV_MonAn_Hoa();
                FisrtMode();
                ResetValue();
            }
            else if (flag == "Sua")
            {
                EditMonAnHoa();
                LoadDTGV_MonAn_Hoa();
                FisrtMode();
                ResetValue();
            }
        }
        private void EditMonAnHoa()
        {
            QLBanMonAnClassesDataContext db = new QLBanMonAnClassesDataContext();
            MonAn hh = db.MonAns.Where(p => p.MaMonAn == txtMaHH.Text).SingleOrDefault();

            hh.TenMonAn = txtTenHH.Text;
            hh.Anh = txtAnhHH.Text;
            hh.MaNguyenLieu = cbbTenNguyenLieuHH.SelectedValue.ToString();
            hh.SoLuong = double.Parse(txtSoLuongHH.Text);
            hh.DonGiaBan = double.Parse(txtDonGiaBanHH.Text);
            hh.DonGiaNhap = double.Parse(txtDonGiaNhapHH.Text);
            hh.GhiChu = txtGhiChuHH.Text;


            db.SubmitChanges();
            LoadDTGV_MonAn_Hoa();
        }

        private void btnSuaHH_Click(object sender, EventArgs e)
        {
            if (txtMaHH.Text == "" )
            {
                MessageBox.Show("Bạn chưa chọn dữ liệu nào ! Mời bạn click lên dữ liệu bạn muốn sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtAnhHH.Enabled = true;
            txtDonGiaBanHH.Enabled = true;
            txtDonGiaNhapHH.Enabled = true;
            txtGhiChuHH.Enabled = true;
            txtMaHH.Enabled = false;
            txtSoLuongHH.Enabled = true;
            txtTenHH.Enabled = true;

            btnBoquaHH.Enabled = true;
            btnLuuHH.Enabled = true;
            btnSuaHH.Enabled = true;
            btnThemHH.Enabled = false;
            btnXoaHH.Enabled = false;
            flag = "Sua";
        }

        private void DTGV_MonAn_Hoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                MessageBox.Show("Không có dữ liệu !");
            }
            
            else
            {
                int index = e.RowIndex;
                string mahh = DTGV_MonAn_Hoa.Rows[index].Cells[0].Value.ToString();
                QLBanMonAnClassesDataContext db = new QLBanMonAnClassesDataContext();
                MonAn hh = db.MonAns.Where(p => p.MaMonAn == mahh).SingleOrDefault();
                txtMaHH.Text = hh.MaMonAn;
                txtTenHH.Text = hh.TenMonAn;
                txtAnhHH.Text = hh.Anh;
                txtDonGiaBanHH.Text = hh.DonGiaBan.Value.ToString();
                txtDonGiaNhapHH.Text = hh.DonGiaNhap.Value.ToString();
                txtGhiChuHH.Text = hh.GhiChu;
                txtSoLuongHH.Text = hh.SoLuong.Value.ToString();
                cbbTenNguyenLieuHH.SelectedValue = hh.MaNguyenLieu;
                if (txtAnhHH.Text != "")
                {
                    OpenFileDialog open = new OpenFileDialog();
                    open.FileName = txtAnhHH.Text;
                    PbAnhHH.Image = new Bitmap(open.FileName);
                    PbAnhHH.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                return;
            }
            return;
        }

        private void btnXoaHH_Click(object sender, EventArgs e)
        {
            if (txtMaHH.Text == "" )
            {
                MessageBox.Show("Bạn chưa chọn dữ liệu nào ! Mời bạn click lên dữ liệu bạn muốn xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            btnSuaHH.Enabled = false;
            btnXoaHH.Enabled = true;
            btnBoquaHH.Enabled = false;
            btnLuuHH.Enabled = false;
            btnThemHH.Enabled = false;

            txtAnhHH.Enabled = false;
            txtDonGiaBanHH.Enabled = false;
            txtDonGiaNhapHH.Enabled = false;
            txtGhiChuHH.Enabled = false;
            txtMaHH.Enabled = false;
            txtSoLuongHH.Enabled =false;
            txtTenHH.Enabled = false;
            if (DialogResult.Yes == MessageBox.Show("Bạn muốn xóa " + txtTenHH.Text + " ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                DeleteKH();
                LoadDTGV_MonAn_Hoa();
                ResetValue();
                FisrtMode();
            }
        }
        private void DeleteKH()
        {
            QLBanMonAnClassesDataContext db = new QLBanMonAnClassesDataContext();
            MonAn hh = db.MonAns.Where(p => p.MaMonAn == txtMaHH.Text).SingleOrDefault();
            db.MonAns.DeleteOnSubmit(hh);
            db.SubmitChanges();
        }

        private void btnBoquaHH_Click(object sender, EventArgs e)
        {
            ResetValue();
            FisrtMode();
        }

        private void btnDongHH_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTimKiemHH_Click(object sender, EventArgs e)
        {
            QLBanMonAnClassesDataContext db = new QLBanMonAnClassesDataContext();

            txtAnhHH.Enabled = false;
            txtDonGiaBanHH.Enabled = true;
            txtDonGiaNhapHH.Enabled = true;
            txtGhiChuHH.Enabled = false;
            txtMaHH.Enabled = true;
            txtSoLuongHH.Enabled = true;
            txtTenHH.Enabled = true;
            cbbTenNguyenLieuHH.Enabled = true;

            ResetValue();
            if (cbbTenNguyenLieuHH.Text != "")
            {
                DTGV_MonAn_Hoa.DataSource = db.MonAns.Where(p => p.MaNguyenLieu == cbbTenNguyenLieuHH.ValueMember).SingleOrDefault();
            }
            if (txtMaHH.Text!="")
            {
                DTGV_MonAn_Hoa.DataSource = db.MonAns.Where(p => p.MaMonAn == txtMaHH.Text).SingleOrDefault();
            }
            if (txtTenHH.Text != "")
            {
                DTGV_MonAn_Hoa.DataSource = db.MonAns.Where(p => p.TenMonAn == txtTenHH.Text).SingleOrDefault();
            }
            if (txtSoLuongHH.Text != "0")
            {
                DTGV_MonAn_Hoa.DataSource = db.MonAns.Where(p => p.SoLuong == double.Parse(txtSoLuongHH.Text)).SingleOrDefault();
            }
            if (txtDonGiaBanHH.Text != "0")
            {
                DTGV_MonAn_Hoa.DataSource = db.MonAns.Where(p => p.DonGiaBan == double.Parse(txtDonGiaBanHH.Text)).SingleOrDefault();
            }
            if (txtDonGiaNhapHH.Text != "0")
            {
                DTGV_MonAn_Hoa.DataSource = db.MonAns.Where(p => p.DonGiaNhap == double.Parse(txtDonGiaNhapHH.Text)).SingleOrDefault();
            }
            ResetValue();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PbAnhHH_Click(object sender, EventArgs e)
        {

        }

        private void DTGV_MonAn_Hoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
