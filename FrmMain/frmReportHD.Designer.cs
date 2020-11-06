namespace FrmMain
{
    partial class frmReportHD
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.HoaDonBanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QuanLyBanDoAnDataSet1 = new FrmMain.QuanLyBanDoAnDataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.HoaDonBanTableAdapter = new FrmMain.QuanLyBanDoAnDataSet1TableAdapters.HoaDonBanTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.HoaDonBanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLyBanDoAnDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // HoaDonBanBindingSource
            // 
            this.HoaDonBanBindingSource.DataMember = "HoaDonBan";
            this.HoaDonBanBindingSource.DataSource = this.QuanLyBanDoAnDataSet1;
            // 
            // QuanLyBanDoAnDataSet1
            // 
            this.QuanLyBanDoAnDataSet1.DataSetName = "QuanLyBanDoAnDataSet1";
            this.QuanLyBanDoAnDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.HoaDonBanBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "FrmMain.ReportTimKiemHD.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1008, 608);
            this.reportViewer1.TabIndex = 0;
            // 
            // HoaDonBanTableAdapter
            // 
            this.HoaDonBanTableAdapter.ClearBeforeFill = true;
            // 
            // frmReportHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 606);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmReportHD";
            this.Text = "frmReportHD";
            this.Load += new System.EventHandler(this.frmReportHD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HoaDonBanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLyBanDoAnDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource HoaDonBanBindingSource;
        private QuanLyBanDoAnDataSet1 QuanLyBanDoAnDataSet1;
        private QuanLyBanDoAnDataSet1TableAdapters.HoaDonBanTableAdapter HoaDonBanTableAdapter;
    }
}