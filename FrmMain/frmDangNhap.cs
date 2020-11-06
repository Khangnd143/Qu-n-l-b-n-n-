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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string ten = txtTenDN.Text;
            QLBanMonAnClassesDataContext db = new QLBanMonAnClassesDataContext();
            DangNhap dangNhap = db.DangNhaps.Where(p => p.TenDangNhap == ten).SingleOrDefault();

            if (dangNhap == null)
            {
                MessageBox.Show("Tài khoản không tồn tại");
            }
            else
            {
                if (txtMK.Text == dangNhap.MatKhau)
                {
                    if (dangNhap.TenDangNhap == "admin")
                    {
                        if (DialogResult.Yes == MessageBox.Show("Bạn muốn thêm tài khoản mới!", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information))
                        {
                            btnThem.Visible = true;
                        }
                        if (DialogResult.No == MessageBox.Show("Bạn muốn thêm tài khoản mới! ", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information))
                        {
                            this.Hide();
                            Form1 frm = new Form1();
                            frm.ShowDialog();
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Đăng nhập thành công !", "" ,MessageBoxButtons.OK ,MessageBoxIcon.Warning);
                        this.Hide();
                        Form1 frm = new Form1();
                        frm.ShowDialog();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Sai mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMK.Text = "";
                    txtMK.Focus();
                }
                   
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        bool check = true;
        private void btnThem_Click(object sender, EventArgs e)
        {
            QLBanMonAnClassesDataContext db = new QLBanMonAnClassesDataContext();
            DangNhap dangNhap = new DangNhap();
            if (check == true)
            {
                txtTenDN.Text = "";
                txtMK.Text = "";
                txtTenDN.Focus();
                check = false;
            }
            else
            {
                dangNhap.TenDangNhap = txtTenDN.Text;
                dangNhap.MatKhau = txtMK.Text;
                DangNhap dn = db.DangNhaps.Where(p => p.TenDangNhap == txtTenDN.Text).SingleOrDefault();
                if (dn != null)
                {
                    MessageBox.Show("Đã có tài khoản !", "Thông báo", MessageBoxButtons.OK);
                    txtTenDN.Text = "";
                    txtMK.Text = "";
                    txtTenDN.Focus();
                }
                else
                {
                    db.DangNhaps.InsertOnSubmit(dangNhap);
                    db.SubmitChanges();
                    MessageBox.Show("Tạo tài khoản thành công!", "Thông báo", MessageBoxButtons.OK);
                    txtTenDN.Text = "";
                    txtMK.Text = "";
                    txtTenDN.Focus();
                    check = true;
                }
            }

        }
    }
}
