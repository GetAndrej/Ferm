namespace Ferm_V2
{
    partial class Otchet_Milk
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
            this.fermDataSetLastV = new Ferm_V2.fermDataSetLastV();
            this.milkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.milkTableAdapter = new Ferm_V2.fermDataSetLastVTableAdapters.milkTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.fermDataSetLastV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.milkBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetMilk";
            reportDataSource1.Value = this.milkBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Ferm_V2.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(700, 348);
            this.reportViewer1.TabIndex = 0;
            // 
            // fermDataSetLastV
            // 
            this.fermDataSetLastV.DataSetName = "fermDataSetLastV";
            this.fermDataSetLastV.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // milkBindingSource
            // 
            this.milkBindingSource.DataMember = "milk";
            this.milkBindingSource.DataSource = this.fermDataSetLastV;
            // 
            // milkTableAdapter
            // 
            this.milkTableAdapter.ClearBeforeFill = true;
            // 
            // Otchet_Milk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 348);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Otchet_Milk";
            this.Text = "Otchet_Milk";
            this.Load += new System.EventHandler(this.Otchet_Milk_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fermDataSetLastV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.milkBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource milkBindingSource;
        private fermDataSetLastV fermDataSetLastV;
        private fermDataSetLastVTableAdapters.milkTableAdapter milkTableAdapter;
    }
}