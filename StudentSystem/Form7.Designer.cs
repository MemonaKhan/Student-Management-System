namespace StudentSystem
{
    partial class Form7
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.umairDataSet = new StudentSystem.umairDataSet();
            this.s_infoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.s_infoTableAdapter = new StudentSystem.umairDataSetTableAdapters.s_infoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.umairDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.s_infoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.s_infoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "StudentSystem.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(520, 376);
            this.reportViewer1.TabIndex = 0;
            // 
            // umairDataSet
            // 
            this.umairDataSet.DataSetName = "umairDataSet";
            this.umairDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // s_infoBindingSource
            // 
            this.s_infoBindingSource.DataMember = "s_info";
            this.s_infoBindingSource.DataSource = this.umairDataSet;
            // 
            // s_infoTableAdapter
            // 
            this.s_infoTableAdapter.ClearBeforeFill = true;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 399);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form7";
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.umairDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.s_infoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource s_infoBindingSource;
        private umairDataSet umairDataSet;
        private umairDataSetTableAdapters.s_infoTableAdapter s_infoTableAdapter;
    }
}