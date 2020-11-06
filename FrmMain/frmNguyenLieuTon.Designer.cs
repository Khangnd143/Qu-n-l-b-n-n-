namespace FrmMain
{
    partial class frmMonAnTon
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
            this.MonAnBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QuanLyBanDoAnDataSet = new FrmMain.QuanLyBanDoAnDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.MonAnTableAdapter = new FrmMain.QuanLyBanDoAnDataSetTableAdapters.MonAnTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.MonAnBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLyBanDoAnDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // MonAnBindingSource
            // 
            this.MonAnBindingSource.DataMember = "MonAn";
            this.MonAnBindingSource.DataSource = this.QuanLyBanDoAnDataSet;
            // 
            // QuanLyBanDoAnDataSet
            // 
            this.QuanLyBanDoAnDataSet.DataSetName = "QuanLyBanDoAnDataSet";
            this.QuanLyBanDoAnDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.MonAnBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "FrmMain.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1600, 784);
            this.reportViewer1.TabIndex = 0;
            // 
            // MonAnTableAdapter
            // 
            this.MonAnTableAdapter.ClearBeforeFill = true;
            // 
            // frmMonAnTon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1598, 557);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmMonAnTon";
            this.Text = "frmMonAnTon";
            this.Load += new System.EventHandler(this.frmMonAnTon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MonAnBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLyBanDoAnDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource MonAnBindingSource;
        private QuanLyBanDoAnDataSet QuanLyBanDoAnDataSet;
        private QuanLyBanDoAnDataSetTableAdapters.MonAnTableAdapter MonAnTableAdapter;
    }
}