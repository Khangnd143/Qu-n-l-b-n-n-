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
    public partial class frmReportHD : Form
    {
        public frmReportHD()
        {
            InitializeComponent();
        }

        private void frmReportHD_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QuanLyBanDoAnDataSet1.HoaDonBan' table. You can move, or remove it, as needed.
            this.HoaDonBanTableAdapter.Fill(this.QuanLyBanDoAnDataSet1.HoaDonBan);

            this.reportViewer1.RefreshReport();
            using (QuanLyBanDoAnDataSet1 db = new QuanLyBanDoAnDataSet1())
            {

            }

        }
    }
}
