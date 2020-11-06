using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace FrmMain
{
    public partial class frmDMNguyenLieu : Form
    {
        public frmDMNguyenLieu()
        {
            InitializeComponent();
        }
        private void frmDMNguyenLieu_Load(object sender, EventArgs e)
        {
            FisrtMode();
            LoadDTGV_Chat_Lieu();
        }

        private void FisrtMode()
        {
            txtMaNguyenLieu.Enabled = false;
            txtTenNguyenLieu.Enabled = false;
            btnBoQuaCL.Enabled = false;
            btnLuuCl.Enabled = false;
            btnThemCL.Enabled = true;
            btnSuaCL.Enabled = true;
            btnXoaCL.Enabled = true;
        }

        private void LoadDTGV_Chat_Lieu()
        {
            QLBanMonAnClassesDataContext db = new QLBanMonAnClassesDataContext();
            dataGridView1.DataSource = db.NguyenLieus;
            dataGridView1.Columns[0].HeaderText = "Mã Nguyên Liệu";
            dataGridView1.Columns[1].HeaderText = "Tên Nguyên Liệu";
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex < 0)
            {
                MessageBox.Show("Không có dữ liệu !");
            }
            
            else
            {
                int index = e.RowIndex;
                string macl = dataGridView1.Rows[index].Cells[0].Value.ToString();
                QLBanMonAnClassesDataContext db = new QLBanMonAnClassesDataContext();
                NguyenLieu cl = db.NguyenLieus.Where(p => p.MaNguyenLieu == macl).SingleOrDefault();
                txtMaNguyenLieu.Text = cl.MaNguyenLieu;
                txtTenNguyenLieu.Text = cl.TenNguyenLieu;
                return;

            }
            return;
           
        }
        string flag = "";
        private void btnThemCL_Click(object sender, EventArgs e)
        {
            btnSuaCL.Enabled = false;
            btnXoaCL.Enabled = false;
            btnBoQuaCL.Enabled = true;
            btnLuuCl.Enabled = true;
            txtMaNguyenLieu.Enabled = true;
            txtTenNguyenLieu.Enabled = true;
            ResetTxtValue();
            txtMaNguyenLieu.Focus();
            flag = "Them";
            
        }
        private void ResetTxtValue()
        {
            txtMaNguyenLieu.Text = "";
            txtTenNguyenLieu.Text = "";
        }

        private void btnLuuCl_Click(object sender, EventArgs e)
        {
            if (flag == "Them")
            {
                insertCL();
                LoadDTGV_Chat_Lieu();
                FisrtMode();
                ResetTxtValue();
            }
            else if (flag == "Sua")
            {
                EditNguyenLieu();
                LoadDTGV_Chat_Lieu();
                FisrtMode();
                ResetTxtValue();
            }
        }
        private void insertCL()
        {
            QLBanMonAnClassesDataContext db = new QLBanMonAnClassesDataContext();
            if (txtMaNguyenLieu.Text == "")
            {
                MessageBox.Show("Mời nhập Mã chất liệu!");
                txtMaNguyenLieu.Focus();
                return;
            }
            else
            {
                NguyenLieu cl1 = db.NguyenLieus.Where(p => p.MaNguyenLieu == txtMaNguyenLieu.Text).SingleOrDefault();
                if (cl1 != null)
                {
                    MessageBox.Show("Mã Chất liệu này đã có ! Bạn phải nhập mã khác !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaNguyenLieu.Focus();
                    return;
                }
            }
            if (txtTenNguyenLieu.Text == "")
            {
                MessageBox.Show("Mời nhập Tên chất liệu!");
                txtTenNguyenLieu.Focus();
                return;
            }
         
            NguyenLieu cl = new NguyenLieu();
            cl.MaNguyenLieu = txtMaNguyenLieu.Text;
            cl.TenNguyenLieu = txtTenNguyenLieu.Text;
            db.NguyenLieus.InsertOnSubmit(cl);
            db.SubmitChanges();
        }
        private void btnSuaCL_Click(object sender, EventArgs e)
        {
            if (txtMaNguyenLieu.Text == "" || txtTenNguyenLieu.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn dữ liệu nào ! Mời bạn click lên dữ liệu bạn muốn sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            btnSuaCL.Enabled = true;
            btnXoaCL.Enabled = false;
            btnBoQuaCL.Enabled = true;
            btnLuuCl.Enabled = true;
            btnThemCL.Enabled = false;
            txtTenNguyenLieu.Enabled = true;
            flag = "Sua";
        }

        private void EditNguyenLieu()
        {
            
            QLBanMonAnClassesDataContext db = new QLBanMonAnClassesDataContext();
            NguyenLieu cl = db.NguyenLieus.Where(p => p.MaNguyenLieu == txtMaNguyenLieu.Text).SingleOrDefault();
            cl.TenNguyenLieu = txtTenNguyenLieu.Text;
            db.SubmitChanges();
            LoadDTGV_Chat_Lieu();
        }

        private void btnXoaCL_Click(object sender, EventArgs e)
        {
            if (txtMaNguyenLieu.Text == "" || txtTenNguyenLieu.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn dữ liệu nào ! Mời bạn click lên dữ liệu bạn muốn xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            btnSuaCL.Enabled = false;
            btnXoaCL.Enabled = true;
            btnBoQuaCL.Enabled = true;
            btnLuuCl.Enabled = true;
            btnThemCL.Enabled = false;
            txtTenNguyenLieu.Enabled = false;
            if(DialogResult.Yes==MessageBox.Show("Bạn muốn xóa "+ txtTenNguyenLieu.Text + " ?","Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)){
                DeleteCL();
                LoadDTGV_Chat_Lieu();
                ResetTxtValue();
                FisrtMode();
            }
        }

        private void DeleteCL()
        {
            QLBanMonAnClassesDataContext db = new QLBanMonAnClassesDataContext();
            NguyenLieu cl = db.NguyenLieus.Where(p => p.MaNguyenLieu == txtMaNguyenLieu.Text).SingleOrDefault();
            db.NguyenLieus.DeleteOnSubmit(cl);
            db.SubmitChanges();
        }

        private void txtTenNguyenLieu_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyValue == (char)Keys.Enter)
            //{
            //    btnLuuCl_Click(sender, e);
            //    return;
            //}
        }

        private void btnBoQuaCL_Click(object sender, EventArgs e)
        {
            ResetTxtValue();
            FisrtMode();
        }

        private void btnThoatCL_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMaNguyenLieu_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
