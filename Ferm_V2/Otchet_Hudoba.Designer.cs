namespace Ferm_V2
{
    partial class Otchet_Hudoba
    {
      
        private System.ComponentModel.IContainer components = null;

          private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.fermDataSetLastV = new Ferm_V2.fermDataSetLastV();
            this.cowBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cowTableAdapter = new Ferm_V2.fermDataSetLastVTableAdapters.cowTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.fermDataSetLastV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cowBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(396, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // reportViewer2
            // 
            this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetHudoba";
            reportDataSource1.Value = this.cowBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "Ferm_V2.Report4.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(0, 0);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.Size = new System.Drawing.Size(757, 404);
            this.reportViewer2.TabIndex = 0;
            // 
            // fermDataSetLastV
            // 
            this.fermDataSetLastV.DataSetName = "fermDataSetLastV";
            this.fermDataSetLastV.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cowBindingSource
            // 
            this.cowBindingSource.DataMember = "cow";
            this.cowBindingSource.DataSource = this.fermDataSetLastV;
            // 
            // cowTableAdapter
            // 
            this.cowTableAdapter.ClearBeforeFill = true;
            // 
            // Otchet_Hudoba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 404);
            this.Controls.Add(this.reportViewer2);
            this.Name = "Otchet_Hudoba";
            this.Text = "Отчет по худобе";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fermDataSetLastV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cowBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

          private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
          private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
          private System.Windows.Forms.BindingSource cowBindingSource;
          private fermDataSetLastV fermDataSetLastV;
          private fermDataSetLastVTableAdapters.cowTableAdapter cowTableAdapter;
    }
}