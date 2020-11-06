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
    public partial class frmMonAnTon : Form
    {
        public frmMonAnTon()
        {
            InitializeComponent();
        }

        private void frmMonAnTon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QuanLyBanDoAnDataSet.MonAn' table. You can move, or remove it, as needed.
            this.MonAnTableAdapter.Fill(this.QuanLyBanDoAnDataSet.MonAn);

            this.reportViewer1.RefreshReport();
        }
    }
}
