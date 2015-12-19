namespace Ferm_V2
{
    partial class Form2
    {
      
        private System.ComponentModel.IContainer components = null;

          private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.fermDataSet = new Ferm_V2.fermDataSet();
            this.cowBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cowTableAdapter = new Ferm_V2.fermDataSetTableAdapters.cowTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.fermDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cowBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "ReportViewer";
            this.reportViewer1.Size = new System.Drawing.Size(396, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // reportViewer2
            // 
            this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.cowBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "Ferm_V2.Report2.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(0, 0);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.Size = new System.Drawing.Size(757, 404);
            this.reportViewer2.TabIndex = 0;
            // 
            // fermDataSet
            // 
            this.fermDataSet.DataSetName = "fermDataSet";
            this.fermDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cowBindingSource
            // 
            this.cowBindingSource.DataMember = "cow";
            this.cowBindingSource.DataSource = this.fermDataSet;
            // 
            // cowTableAdapter
            // 
            this.cowTableAdapter.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 404);
            this.Controls.Add(this.reportViewer2);
            this.Name = "Form2";
            this.Text = "Отчет по худобе";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fermDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cowBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

          private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
          private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
          private System.Windows.Forms.BindingSource cowBindingSource;
          private fermDataSet fermDataSet;
          private fermDataSetTableAdapters.cowTableAdapter cowTableAdapter;
    }
}