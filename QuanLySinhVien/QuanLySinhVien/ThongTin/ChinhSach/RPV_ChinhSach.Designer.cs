namespace QuanLySinhVien.ThongTin.ChinhSach
{
    partial class RPV_ChinhSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RPV_ChinhSach));
            this.chinhSachBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanlysinhvienDataSet = new QuanLySinhVien.quanlysinhvienDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.chinhSachTableAdapter1 = new QuanLySinhVien.quanlysinhvienDataSet1TableAdapters.ChinhSachTableAdapter();
            this.chinhSachTableAdapter = new QuanLySinhVien.quanlysinhvienDataSetTableAdapters.ChinhSachTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.chinhSachBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlysinhvienDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // chinhSachBindingSource
            // 
            this.chinhSachBindingSource.DataMember = "ChinhSach";
            this.chinhSachBindingSource.DataSource = this.quanlysinhvienDataSet;
            // 
            // quanlysinhvienDataSet
            // 
            this.quanlysinhvienDataSet.DataSetName = "quanlysinhvienDataSet";
            this.quanlysinhvienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.AutoScroll = true;
            this.reportViewer1.AutoSize = true;
            this.reportViewer1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.chinhSachBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLySinhVien.ThongTin.ChinhSach.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1167, 794);
            this.reportViewer1.TabIndex = 0;
            // 
            // chinhSachTableAdapter1
            // 
            this.chinhSachTableAdapter1.ClearBeforeFill = true;
            // 
            // chinhSachTableAdapter
            // 
            this.chinhSachTableAdapter.ClearBeforeFill = true;
            // 
            // RPV_ChinhSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 794);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RPV_ChinhSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RPV_ChinhSach(Nhóm 3 - nhom3tin10a2@gmail.com)";
            this.Load += new System.EventHandler(this.RPV_ChinhSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chinhSachBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlysinhvienDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private quanlysinhvienDataSet1TableAdapters.ChinhSachTableAdapter chinhSachTableAdapter1;
        private quanlysinhvienDataSet quanlysinhvienDataSet;
        private System.Windows.Forms.BindingSource chinhSachBindingSource;
        private quanlysinhvienDataSetTableAdapters.ChinhSachTableAdapter chinhSachTableAdapter;
    }
}