namespace DA1_WF
{
    partial class frmInHDB
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.hDBDataSet = new DA1_WF.HDBDataSet();
            this.hDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cTHDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.hDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hDBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTHDBBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.hDBBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.cTHDBBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DA1_WF.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1124, 737);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // hDBDataSet
            // 
            this.hDBDataSet.DataSetName = "HDBDataSet";
            this.hDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hDBDataSetBindingSource
            // 
            this.hDBDataSetBindingSource.DataSource = this.hDBDataSet;
            this.hDBDataSetBindingSource.Position = 0;
            // 
            // hDBBindingSource
            // 
            this.hDBBindingSource.DataMember = "HDB";
            this.hDBBindingSource.DataSource = this.hDBDataSetBindingSource;
            // 
            // cTHDBBindingSource
            // 
            this.cTHDBBindingSource.DataMember = "CTHDB";
            this.cTHDBBindingSource.DataSource = this.hDBDataSetBindingSource;
            // 
            // frmInHDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 737);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmInHDB";
            this.Text = "frmInHDB";
            this.Load += new System.EventHandler(this.frmInHDB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hDBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTHDBBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource hDBBindingSource;
        private System.Windows.Forms.BindingSource hDBDataSetBindingSource;
        private HDBDataSet hDBDataSet;
        private System.Windows.Forms.BindingSource cTHDBBindingSource;
    }
}