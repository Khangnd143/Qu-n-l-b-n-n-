using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Reflection;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using COMExcel = Microsoft.Office.Interop.Excel;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.html;
using iTextSharp.text.html.simpleparser;

namespace FrmMain
{
    public partial class frmHoaDonBan : Form
    {
        public frmHoaDonBan()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        string flag = "";
        private void frmHoaDonBan_Load(object sender, EventArgs e)
        {
            FisrMode();

            if (txtMaHoaDon.Text != "")
            {
                QLBanMonAnClassesDataContext db1 = new QLBanMonAnClassesDataContext();
                HoaDonBan hd = db1.HoaDonBans.Where(p => p.MaHDBan == txtMaHoaDon.Text).SingleOrDefault();
                dtpNgayBan.Value = hd.NgayBan.Value;
                cbbTenNhanVien.SelectedValue = hd.MaNhanVien;
                cbbTenKhachMonAn.SelectedValue = hd.MaKhach;
                txtTongTien.Text = hd.TongTien.ToString();
                lblTienChu.Text = "Bằng chữ: ";//+"csdsd"

            }

            LoadDTGV_Hoa_Don();
        }

        private void FisrMode()
        {
            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            btnIn.Enabled = true;
            txtMaHoaDon.ReadOnly = true;
            txtMaNhanVien.ReadOnly = true;
            txtMaKhachMonAn.ReadOnly = true;
            txtDiaChi.ReadOnly = true;
            txtDienThoai.ReadOnly = true;
            txtMaMonAn.ReadOnly = true;
            txtDonGia.ReadOnly = true;
            txtThanhTien.ReadOnly = true;
            txtTongTien.ReadOnly = true;
            txtGiamGia.Text = "0";
            txtTongTien.Text = "0";
            Load_Nhan_vien();
            cbbTenNhanVien.Text = "";
            Load_Khach_hang();
            cbbTenKhachMonAn.Text = "";
            Load_MonAn_Hoa();
            cbbTenMonAn.Text = "";
        }

        private void Load_Nhan_vien()
        {
            QLBanMonAnClassesDataContext db = new QLBanMonAnClassesDataContext();
            cbbTenNhanVien.DataSource = db.NhanViens;
            cbbTenNhanVien.DisplayMember = "TenNhanVien";
            cbbTenNhanVien.ValueMember = "MaNhanVien";
        }

        private void Load_Khach_hang()
        {
            QLBanMonAnClassesDataContext db = new QLBanMonAnClassesDataContext();
            cbbTenKhachMonAn.DataSource = db.Khaches;
            cbbTenKhachMonAn.DisplayMember = "TenKhach";
            cbbTenKhachMonAn.ValueMember = "MaKhach";
        }
        private void cbbTenKhachMonAn_TextChanged(object sender, EventArgs e)
        {
            if (cbbTenKhachMonAn.Text != "")
            {
                QLBanMonAnClassesDataContext db = new QLBanMonAnClassesDataContext();
                Khach kh = db.Khaches.Where(p => p.MaKhach == cbbTenKhachMonAn.SelectedValue.ToString()).SingleOrDefault();
                if (kh != null)
                {
                    txtDiaChi.Text = kh.DiaChiKH;
                    txtDienThoai.Text = kh.DienThoaiKH;
                    txtMaKhachMonAn.Text = kh.MaKhach;
                }
            }
        }
        private void cbbTenNhanVien_TextChanged(object sender, EventArgs e)
        {
            if (cbbTenNhanVien.Text != "" || cbbTenNhanVien.Text != null)
            {
                QLBanMonAnClassesDataContext db = new QLBanMonAnClassesDataContext();
                NhanVien nv = db.NhanViens.Where(p => p.MaNhanVien == cbbTenNhanVien.SelectedValue.ToString()).SingleOrDefault();
                if (nv != null)
                {
                    txtMaNhanVien.Text = nv.MaNhanVien.ToString();
                }
            }
        }
        private void Load_MonAn_Hoa()
        {

            QLBanMonAnClassesDataContext db = new QLBanMonAnClassesDataContext();
            cbbTenMonAn.DataSource = db.MonAns;
            cbbTenMonAn.DisplayMember = "TenMonAn";
            cbbTenMonAn.ValueMember = "MaMonAn";
        }
        private void cbbMaMonAn_TextChanged(object sender, EventArgs e)
        {
            if (cbbTenMonAn.Text != "")
            {
                QLBanMonAnClassesDataContext db = new QLBanMonAnClassesDataContext();
                MonAn hh = db.MonAns.Where(p => p.MaMonAn == cbbTenMonAn.SelectedValue.ToString()).SingleOrDefault();
                if (hh != null)
                {
                    txtDonGia.Text = hh.DonGiaBan.ToString();
                    txtMaMonAn.Text = hh.MaMonAn;
                }
            }
        }

        private void LoadDTGV_Hoa_Don()
        {
            QLBanMonAnClassesDataContext db = new QLBanMonAnClassesDataContext();
            DTGV_Hoa_Don.DataSource = db.ChiTietHoaDonBans;
            DTGV_Hoa_Don.Columns[0].HeaderText = "Mã hóa đơn";
            DTGV_Hoa_Don.Columns[1].HeaderText = "Mã hàng";
            DTGV_Hoa_Don.Columns[2].HeaderText = "Số lượng";
            DTGV_Hoa_Don.Columns[3].HeaderText = "Đơn giá";
            DTGV_Hoa_Don.Columns[4].HeaderText = "Giảm giá %";
            DTGV_Hoa_Don.Columns[5].HeaderText = "Thành tiền";

            DTGV_Hoa_Don.Columns[0].Width = 80;
            DTGV_Hoa_Don.Columns[1].Width = 130;
            DTGV_Hoa_Don.Columns[2].Width = 80;
            DTGV_Hoa_Don.Columns[3].Width = 90;
            DTGV_Hoa_Don.Columns[4].Width = 90;
            DTGV_Hoa_Don.Columns[5].Width = 90;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            btnIn.Enabled = false;
            btnThem.Enabled = false;
            ResetValues();
            txtMaHoaDon.Text = Functions.CreateKey("HDB");
            LoadDTGV_Hoa_Don();
            flag = "Them";
        }

        private void ResetValues()
        {
            txtMaHoaDon.Text = "";
            dtpNgayBan.Value = DateTime.Now;
            cbbTenNhanVien.Text = "";
            cbbTenKhachMonAn.Text = "";
            cbbTenMonAn.Text = "";

            txtDiaChi.Text = "";
            txtDienThoai.Text = "";
            txtMaMonAn.Text = "";
            txtMaKhachMonAn.Text = "";
            txtMaNhanVien.Text = "";
            txtDonGia.Text = "0";

            lblTienChu.Text = "Bằng chữ: ";


            txtSoLuong.Text = "0";
            txtGiamGia.Text = "0";
            txtThanhTien.Text = "0";
            txtTongTien.Text = "000";

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (flag == "Them")
            {
                InsertHH();
                FisrMode();
                LoadDTGV_Hoa_Don();
            }
        }

        private void InsertHH()
        {
            QLBanMonAnClassesDataContext db = new QLBanMonAnClassesDataContext();
            HoaDonBan hoaDonBan = new HoaDonBan();
            ChiTietHoaDonBan chiTietHoaDon = new ChiTietHoaDonBan();
            MonAn hh;
            if (txtMaMonAn.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn mặt hàng bán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                chiTietHoaDon.MaMonAn = txtMaMonAn.Text;
                hh = db.MonAns.Where(p => p.MaMonAn == txtMaMonAn.Text).Single();
            }
            if (txtMaKhachMonAn.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
            else
            {
                hoaDonBan.MaKhach = txtMaKhachMonAn.Text;
            }
            if (txtMaNhanVien.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               
            }
            else
            {
                hoaDonBan.MaNhanVien = txtMaNhanVien.Text;
            }
            chiTietHoaDon.MaHDBan = txtMaHoaDon.Text;

            if (txtSoLuong.Text == null || txtSoLuong.Text == "0")
            {
                MessageBox.Show("Mời bạn nhập Số lượng hàng bán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoLuong.Focus();
            }
            else if (float.Parse(txtSoLuong.Text) > hh.SoLuong)
            {
                
                MessageBox.Show(cbbTenMonAn.Text+" chỉ còn "+hh.SoLuong.ToString()+"! Mời bạn thực hiện Thêm lại hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoLuong.Focus();
            }
            else
            {
                chiTietHoaDon.SoLuong = float.Parse(txtSoLuong.Text);

                chiTietHoaDon.DonGia = float.Parse(txtSoLuong.Text);
                if (txtGiamGia.Text != null && txtGiamGia.Text != "")
                {
                    chiTietHoaDon.GiamGia = float.Parse(txtGiamGia.Text);
                }
                else chiTietHoaDon.GiamGia = 0;
                chiTietHoaDon.ThanhTien = float.Parse(txtThanhTien.Text);

                hoaDonBan.MaHDBan = chiTietHoaDon.MaHDBan;
                hoaDonBan.NgayBan = dtpNgayBan.Value;
                
                hoaDonBan.TongTien = float.Parse(txtTongTien.Text);

                db.ChiTietHoaDonBans.InsertOnSubmit(chiTietHoaDon);
                db.HoaDonBans.InsertOnSubmit(hoaDonBan);
                db.SubmitChanges();

                
                hh.SoLuong = hh.SoLuong - chiTietHoaDon.SoLuong;
                db.SubmitChanges();
            }
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            double tt, sl, dg, gg;
            if (txtSoLuong.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txtSoLuong.Text);
            if (txtGiamGia.Text == "")
                gg = 0;
            else
                gg = Convert.ToDouble(txtGiamGia.Text);
            if (txtDonGia.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(txtDonGia.Text);
            tt = sl * dg;
            txtThanhTien.Text = tt.ToString();
            txtTongTien.Text = tt.ToString();
        }

        private void txtTongTien_TextChanged(object sender, EventArgs e)
        {
            lblTienChu.Text = ReadNumber.ByWords(decimal.Parse(txtTongTien.Text));

        }

        private void txtThanhTien_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGiamGia_TextChanged(object sender, EventArgs e)
        {
            double tt, sl, dg, gg;
            if (txtSoLuong.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txtSoLuong.Text);
            if (txtGiamGia.Text == "")
                gg = 0;
            else
                gg = Convert.ToDouble(txtGiamGia.Text);
            if (txtDonGia.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(txtDonGia.Text);
            tt = sl * dg - sl * dg * gg / 100;
            txtTongTien.Text = tt.ToString();
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else e.Handled = true;
        }

        private void txtGiamGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else e.Handled = true;
        }

        private void frmHoaDonBan_FormClosing(object sender, FormClosingEventArgs e)
        {
            ResetValues();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ToCsV(DataGridView dGV, string filename)
        {
            string stOutput = "Hóa Đơn Bán hàng";
            // Export titles:
            string sHeaders = "";

            for (int j = 0; j < dGV.Columns.Count; j++)
                sHeaders = sHeaders.ToString() + Convert.ToString(dGV.Columns[j].HeaderText) + "\t";
            stOutput += sHeaders + "\r\n";
            // Export data.
            for (int i = 0; i < dGV.RowCount - 1; i++)
            {
                string stLine = "";
                for (int j = 0; j < dGV.Rows[i].Cells.Count; j++)
                    stLine = stLine.ToString() + Convert.ToString(dGV.Rows[i].Cells[j].Value) + "\t";
                stOutput += stLine + "\r\n";
            }
            Encoding utf16 = Encoding.GetEncoding(1254);
            byte[] output = utf16.GetBytes(stOutput);
            FileStream fs = new FileStream(filename, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(output, 0, output.Length); //write the encoded file
            bw.Flush();
            bw.Close();
            fs.Close();
        }
        private void btnIn_Click(object sender, EventArgs e)
        {
            //BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);

            //PdfPTable pdfTable = new PdfPTable(DTGV_Hoa_Don.ColumnCount);
            //pdfTable.DefaultCell.Padding = 3;
            //pdfTable.WidthPercentage = 90;
            //pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
            //pdfTable.DefaultCell.BorderWidth = 1;

            //iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);
            //foreach (DataGridViewColumn column in DTGV_Hoa_Don.Columns)
            //{
            //    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText,text ));
            //    cell.BackgroundColor = new BaseColor(240, 240, 240);
            //    pdfTable.AddCell(cell);
            //}
            //foreach(DataGridViewRow row in DTGV_Hoa_Don.Rows)
            //{
            //    foreach(DataGridViewCell cell in row.Cells)
            //    {
            //        if (cell.Value == null)
            //        {
            //            pdfTable.AddCell("");
            //        }
            //        else
            //        pdfTable.AddCell(new Phrase(cell.Value.ToString(),text));
            //    }
            //}

            SaveFileDialog saveFile = new SaveFileDialog();

            saveFile.FileName = "Report";
            saveFile.Filter = "Text Files (*.xls)|*.xls|All files (*.*)|*.*";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                ToCsV(DTGV_Hoa_Don, saveFile.FileName);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ResetValues();
            FisrMode();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
