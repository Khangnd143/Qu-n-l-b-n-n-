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
    public partial class TìmMonAnf : Form
    {
        public TìmMonAnf()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TìmMonAnf_Load(object sender, EventArgs e)
        {
            QLBanMonAnClassesDataContext db = new QLBanMonAnClassesDataContext();
            cbbNguyenLieu.DataSource = db.NguyenLieus;
            cbbNguyenLieu.DisplayMember = "TenNguyenLieu";
            cbbNguyenLieu.ValueMember = "MaNguyenLieu";

            cbbTenMonAn.DataSource = db.MonAns;
            cbbTenMonAn.DisplayMember = "TenMonAn";
            cbbTenMonAn.ValueMember = "MaMonAn";
        }

        private void cbbTenMonAn_TextChanged(object sender, EventArgs e)
        {
            QLBanMonAnClassesDataContext db = new QLBanMonAnClassesDataContext();
            DTGV.DataSource = db.MonAns.Where(p => p.MaMonAn == cbbTenMonAn.SelectedValue.ToString()).SingleOrDefault();
            MonAn hh = db.MonAns.Where(p => p.MaMonAn == cbbTenMonAn.SelectedValue.ToString()).SingleOrDefault();
            if(hh!=null)
            textBox1.Text = hh.TenMonAn;

        }

        private void cbbTenMonAn_SelectedValueChanged(object sender, EventArgs e)
        {
            

        }

        private void cbbNguyenLieu_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QLBanMonAnClassesDataContext db = new QLBanMonAnClassesDataContext();
            DTGV.DataSource = db.MonAns.Where(p => p.MaNguyenLieu == cbbNguyenLieu.SelectedValue.ToString()).SingleOrDefault();

        }
    }
}
