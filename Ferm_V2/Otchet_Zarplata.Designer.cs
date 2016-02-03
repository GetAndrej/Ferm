namespace Ferm_V2
{
    partial class Otchet_Zarplata
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
            this.zarplataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fermDataSetLastV = new Ferm_V2.fermDataSetLastV();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.zarplataTableAdapter = new Ferm_V2.fermDataSetLastVTableAdapters.zarplataTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.zarplataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fermDataSetLastV)).BeginInit();
            this.SuspendLayout();
            // 
            // zarplataBindingSource
            // 
            this.zarplataBindingSource.DataMember = "zarplata";
            this.zarplataBindingSource.DataSource = this.fermDataSetLastV;
            // 
            // fermDataSetLastV
            // 
            this.fermDataSetLastV.DataSetName = "fermDataSetLastV";
            this.fermDataSetLastV.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.zarplataBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Ferm_V2.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(900, 457);
            this.reportViewer1.TabIndex = 0;
            // 
            // zarplataTableAdapter
            // 
            this.zarplataTableAdapter.ClearBeforeFill = true;
            // 
            // Otchet_Zarplata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 457);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Otchet_Zarplata";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отчет по зарплате";
            this.Load += new System.EventHandler(this.Otchet_Zarplata_Load);
            ((System.ComponentModel.ISupportInitialize)(this.zarplataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fermDataSetLastV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource zarplataBindingSource;
        private fermDataSetLastV fermDataSetLastV;
        private fermDataSetLastVTableAdapters.zarplataTableAdapter zarplataTableAdapter;
    }
}