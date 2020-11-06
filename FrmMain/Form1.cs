using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace FrmMain
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chấtLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDMNguyenLieu chatLieu = new frmDMNguyenLieu();
            chatLieu.ShowDialog();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDMNhanVien nhanVien = new frmDMNhanVien();
            nhanVien.ShowDialog();
        }

        private void khácHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDMKhachMonAn khachMonAn = new frmDMKhachMonAn();
            khachMonAn.ShowDialog();

        }

        private void hàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDMMonAnHoa hangHoa = new frmDMMonAnHoa();
            hangHoa.ShowDialog();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            this.Close();
            
        }

        private void hóaĐơnBánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHoaDonBan hoaDonBan = new frmHoaDonBan();
            hoaDonBan.ShowDialog();
        }

        private void hàngTồnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMonAnTon frm = new frmMonAnTon();
            frm.ShowDialog();
        }

        private void hóaĐơnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmTimKiemHD timKiemHD = new frmTimKiemHD();
            timKiemHD.ShowDialog();
        }
        
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel2.Links.Add(6, 4, "mailto:hoangkhanh9119@gmail.com");
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }

        private void hàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TìmMonAnf frm = new TìmMonAnf();
            frm.ShowDialog();
        }
    }
}
