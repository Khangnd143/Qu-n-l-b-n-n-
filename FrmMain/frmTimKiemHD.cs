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
    public partial class frmTimKiemHD : Form
    {
        public frmTimKiemHD()
        {
            InitializeComponent();
        }
        QLBanMonAnClassesDataContext db = new QLBanMonAnClassesDataContext();
        private void loaddgv()
        {

            dgvHDBan.DataSource = db.HoaDonBans.OrderBy(p => p.MaHDBan).Select(p => new { p.MaHDBan, p.MaNhanVien, p.NgayBan, p.MaKhach, p.TongTien });
            dgvHDBan.Columns[0].HeaderText = "Mã HĐB";
            dgvHDBan.Columns[1].HeaderText = "Mã nhân viên";
            dgvHDBan.Columns[2].HeaderText = "Ngày bán";
            dgvHDBan.Columns[3].HeaderText = "Mã khách";
            dgvHDBan.Columns[4].HeaderText = "Tổng tiền";

        }
       
        private void cleartext()
        {
            txtMaHoadon.Text = "";
            txtMakhach.Text = "";
            txtManhanvien.Text = "";
            txtNam.Text = "";
            txtThang.Text = "";
            txtTongtien.Text = "";
        }
       
        private void btnTimkiem_Click(object sender, EventArgs e)
        {

            if ((txtMaHoadon.Text == "") && (txtThang.Text == "") && (txtNam.Text == "") &&
              (txtManhanvien.Text == "") && (txtMakhach.Text == "") &&
              (txtTongtien.Text == ""))
            {
                MessageBox.Show("Hãy nhập một điều kiện tìm kiếm!!!", "Yêu cầu ...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if ((txtMaHoadon.Text != "") && (txtThang.Text != "") && (txtNam.Text != "") &&
              (txtManhanvien.Text != "") && (txtMakhach.Text != "") &&
              (txtTongtien.Text != ""))
                    cleartext();
                else
                {

                    var tk = from a in db.HoaDonBans
                             where a.NgayBan.GetValueOrDefault().Month.ToString().Contains(txtThang.Text) && a.NgayBan.GetValueOrDefault().Year.ToString().Contains(txtNam.Text) && a.MaHDBan.Contains(txtMaHoadon.Text) && a.MaKhach.Contains(txtMakhach.Text) && a.MaNhanVien.Contains(txtManhanvien.Text)
                             select new
                             {

                                 MaHDBan = a.MaHDBan,
                                 MaNhanvien = a.MaNhanVien,
                                 Ngayban = a.NgayBan,
                                 Makhach = a.MaKhach,
                                 Tongtien = a.TongTien

                             };
                    dgvHDBan.DataSource = tk;

                    if (dgvHDBan.Rows.Count == 0)
                    {
                        MessageBox.Show("Không có bản ghi thỏa mãn điều kiện!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Có " + dgvHDBan.Rows.Count + " bản ghi thỏa mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    dgvHDBan.Columns[0].HeaderText = "Mã HĐB";
                    dgvHDBan.Columns[1].HeaderText = "Mã nhân viên";
                    dgvHDBan.Columns[2].HeaderText = "Ngày bán";
                    dgvHDBan.Columns[3].HeaderText = "Mã khách";
                    dgvHDBan.Columns[4].HeaderText = "Tổng tiền";
                }
            }
        }
        
        private void btnDong_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTimKiemHD_Load(object sender, EventArgs e)
        {
            loaddgv();
        }

        private void btnTimlai_Click_1(object sender, EventArgs e)
        {

            cleartext();
            loaddgv();
        }

        private void dgvHDBan_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            frmReportHD frm = new frmReportHD();
            frm.ShowDialog();
        }

        private void dgvHDBan_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int indexrow = e.RowIndex;
            if (indexrow > -1)
            {
                string mahd = dgvHDBan.Rows[indexrow].Cells[0].Value.ToString();
                QLBanMonAnClassesDataContext db = new QLBanMonAnClassesDataContext();
                HoaDonBan hd = db.HoaDonBans.Where(p => p.MaHDBan == mahd).SingleOrDefault();
                if (hd != null)
                {
                    txtMaHoadon.Text = hd.MaHDBan;
                    txtMakhach.Text = hd.MaKhach;
                    txtManhanvien.Text = hd.MaNhanVien;
                    txtNam.Text = DateTime.Parse(hd.NgayBan.ToString()).Year.ToString();
                    txtThang.Text = DateTime.Parse(hd.NgayBan.ToString()).Month.ToString();
                    txtTongtien.Text = hd.TongTien.ToString();
                }
            }
            else cleartext();
        }
    }
}
