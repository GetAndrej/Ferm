namespace Ferm_V2
{
    partial class Korm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.b_infirmation = new System.Windows.Forms.Button();
            this.b_grafik = new System.Windows.Forms.Button();
            this.b_otchet = new System.Windows.Forms.Button();
            this.b_tabel = new System.Windows.Forms.Button();
            this.b_korm = new System.Windows.Forms.Button();
            this.b_hudoba = new System.Windows.Forms.Button();
            this.b_personal = new System.Windows.Forms.Button();
            this.b_poisk = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.b_udalit = new System.Windows.Forms.Button();
            this.b_redactirovat = new System.Windows.Forms.Button();
            this.b_dobavit = new System.Windows.Forms.Button();
            this.fermDataSetLastV = new Ferm_V2.fermDataSetLastV();
            this.kormBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kormTableAdapter = new Ferm_V2.fermDataSetLastVTableAdapters.kormTableAdapter();
            this.idkormDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makuhaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otrubDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kukuruzaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ovesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yachminDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sinoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.solomaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fermDataSetLastV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kormBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idkormDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.makuhaDataGridViewTextBoxColumn,
            this.otrubDataGridViewTextBoxColumn,
            this.kukuruzaDataGridViewTextBoxColumn,
            this.ovesDataGridViewTextBoxColumn,
            this.yachminDataGridViewTextBoxColumn,
            this.sinoDataGridViewTextBoxColumn,
            this.solomaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kormBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(118, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(946, 340);
            this.dataGridView1.TabIndex = 0;
            // 
            // b_infirmation
            // 
            this.b_infirmation.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_infirmation.Location = new System.Drawing.Point(12, 348);
            this.b_infirmation.Name = "b_infirmation";
            this.b_infirmation.Size = new System.Drawing.Size(100, 50);
            this.b_infirmation.TabIndex = 17;
            this.b_infirmation.Text = "Информация";
            this.b_infirmation.UseVisualStyleBackColor = true;
            this.b_infirmation.Click += new System.EventHandler(this.b_infirmation_Click);
            // 
            // b_grafik
            // 
            this.b_grafik.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_grafik.Location = new System.Drawing.Point(12, 292);
            this.b_grafik.Name = "b_grafik";
            this.b_grafik.Size = new System.Drawing.Size(100, 50);
            this.b_grafik.TabIndex = 16;
            this.b_grafik.Text = "Графики";
            this.b_grafik.UseVisualStyleBackColor = true;
            this.b_grafik.Click += new System.EventHandler(this.b_grafik_Click);
            // 
            // b_otchet
            // 
            this.b_otchet.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_otchet.Location = new System.Drawing.Point(12, 236);
            this.b_otchet.Name = "b_otchet";
            this.b_otchet.Size = new System.Drawing.Size(100, 50);
            this.b_otchet.TabIndex = 15;
            this.b_otchet.Text = "Отчет";
            this.b_otchet.UseVisualStyleBackColor = true;
            this.b_otchet.Click += new System.EventHandler(this.b_otchet_Click);
            // 
            // b_tabel
            // 
            this.b_tabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_tabel.Location = new System.Drawing.Point(12, 180);
            this.b_tabel.Name = "b_tabel";
            this.b_tabel.Size = new System.Drawing.Size(100, 50);
            this.b_tabel.TabIndex = 14;
            this.b_tabel.Text = "Табель";
            this.b_tabel.UseVisualStyleBackColor = true;
            this.b_tabel.Click += new System.EventHandler(this.b_tabel_Click);
            // 
            // b_korm
            // 
            this.b_korm.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_korm.Location = new System.Drawing.Point(12, 124);
            this.b_korm.Name = "b_korm";
            this.b_korm.Size = new System.Drawing.Size(100, 50);
            this.b_korm.TabIndex = 13;
            this.b_korm.Text = "Корм";
            this.b_korm.UseVisualStyleBackColor = true;
            this.b_korm.Click += new System.EventHandler(this.b_korm_Click);
            // 
            // b_hudoba
            // 
            this.b_hudoba.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_hudoba.Location = new System.Drawing.Point(12, 68);
            this.b_hudoba.Name = "b_hudoba";
            this.b_hudoba.Size = new System.Drawing.Size(100, 50);
            this.b_hudoba.TabIndex = 12;
            this.b_hudoba.Text = "Худоба";
            this.b_hudoba.UseVisualStyleBackColor = true;
            this.b_hudoba.Click += new System.EventHandler(this.b_hudoba_Click);
            // 
            // b_personal
            // 
            this.b_personal.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_personal.Location = new System.Drawing.Point(12, 12);
            this.b_personal.Name = "b_personal";
            this.b_personal.Size = new System.Drawing.Size(100, 50);
            this.b_personal.TabIndex = 11;
            this.b_personal.Text = "Персонал";
            this.b_personal.UseVisualStyleBackColor = true;
            this.b_personal.Click += new System.EventHandler(this.b_personal_Click);
            // 
            // b_poisk
            // 
            this.b_poisk.Location = new System.Drawing.Point(885, 17);
            this.b_poisk.Name = "b_poisk";
            this.b_poisk.Size = new System.Drawing.Size(75, 25);
            this.b_poisk.TabIndex = 23;
            this.b_poisk.Text = "Поиск";
            this.b_poisk.UseVisualStyleBackColor = true;
            this.b_poisk.Click += new System.EventHandler(this.b_poisk_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(551, 17);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(316, 25);
            this.textBox1.TabIndex = 22;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // b_udalit
            // 
            this.b_udalit.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_udalit.Location = new System.Drawing.Point(346, 12);
            this.b_udalit.Name = "b_udalit";
            this.b_udalit.Size = new System.Drawing.Size(100, 40);
            this.b_udalit.TabIndex = 21;
            this.b_udalit.Text = "Удалить";
            this.b_udalit.UseVisualStyleBackColor = true;
            this.b_udalit.Click += new System.EventHandler(this.b_udalit_Click);
            // 
            // b_redactirovat
            // 
            this.b_redactirovat.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_redactirovat.Location = new System.Drawing.Point(240, 12);
            this.b_redactirovat.Name = "b_redactirovat";
            this.b_redactirovat.Size = new System.Drawing.Size(100, 40);
            this.b_redactirovat.TabIndex = 20;
            this.b_redactirovat.Text = "Редактировать";
            this.b_redactirovat.UseVisualStyleBackColor = true;
            this.b_redactirovat.Click += new System.EventHandler(this.b_redactirovat_Click);
            // 
            // b_dobavit
            // 
            this.b_dobavit.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_dobavit.Location = new System.Drawing.Point(134, 12);
            this.b_dobavit.Name = "b_dobavit";
            this.b_dobavit.Size = new System.Drawing.Size(100, 40);
            this.b_dobavit.TabIndex = 19;
            this.b_dobavit.Text = "Добавить";
            this.b_dobavit.UseVisualStyleBackColor = true;
            this.b_dobavit.Click += new System.EventHandler(this.b_dobavit_Click);
            // 
            // fermDataSetLastV
            // 
            this.fermDataSetLastV.DataSetName = "fermDataSetLastV";
            this.fermDataSetLastV.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kormBindingSource
            // 
            this.kormBindingSource.DataMember = "korm";
            this.kormBindingSource.DataSource = this.fermDataSetLastV;
            // 
            // kormTableAdapter
            // 
            this.kormTableAdapter.ClearBeforeFill = true;
            // 
            // idkormDataGridViewTextBoxColumn
            // 
            this.idkormDataGridViewTextBoxColumn.DataPropertyName = "id_korm";
            this.idkormDataGridViewTextBoxColumn.HeaderText = "id_korm";
            this.idkormDataGridViewTextBoxColumn.Name = "idkormDataGridViewTextBoxColumn";
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            // 
            // makuhaDataGridViewTextBoxColumn
            // 
            this.makuhaDataGridViewTextBoxColumn.DataPropertyName = "makuha";
            this.makuhaDataGridViewTextBoxColumn.HeaderText = "makuha";
            this.makuhaDataGridViewTextBoxColumn.Name = "makuhaDataGridViewTextBoxColumn";
            // 
            // otrubDataGridViewTextBoxColumn
            // 
            this.otrubDataGridViewTextBoxColumn.DataPropertyName = "otrub";
            this.otrubDataGridViewTextBoxColumn.HeaderText = "otrub";
            this.otrubDataGridViewTextBoxColumn.Name = "otrubDataGridViewTextBoxColumn";
            // 
            // kukuruzaDataGridViewTextBoxColumn
            // 
            this.kukuruzaDataGridViewTextBoxColumn.DataPropertyName = "kukuruza";
            this.kukuruzaDataGridViewTextBoxColumn.HeaderText = "kukuruza";
            this.kukuruzaDataGridViewTextBoxColumn.Name = "kukuruzaDataGridViewTextBoxColumn";
            // 
            // ovesDataGridViewTextBoxColumn
            // 
            this.ovesDataGridViewTextBoxColumn.DataPropertyName = "oves";
            this.ovesDataGridViewTextBoxColumn.HeaderText = "oves";
            this.ovesDataGridViewTextBoxColumn.Name = "ovesDataGridViewTextBoxColumn";
            // 
            // yachminDataGridViewTextBoxColumn
            // 
            this.yachminDataGridViewTextBoxColumn.DataPropertyName = "yachmin";
            this.yachminDataGridViewTextBoxColumn.HeaderText = "yachmin";
            this.yachminDataGridViewTextBoxColumn.Name = "yachminDataGridViewTextBoxColumn";
            // 
            // sinoDataGridViewTextBoxColumn
            // 
            this.sinoDataGridViewTextBoxColumn.DataPropertyName = "sino";
            this.sinoDataGridViewTextBoxColumn.HeaderText = "sino";
            this.sinoDataGridViewTextBoxColumn.Name = "sinoDataGridViewTextBoxColumn";
            // 
            // solomaDataGridViewTextBoxColumn
            // 
            this.solomaDataGridViewTextBoxColumn.DataPropertyName = "soloma";
            this.solomaDataGridViewTextBoxColumn.HeaderText = "soloma";
            this.solomaDataGridViewTextBoxColumn.Name = "solomaDataGridViewTextBoxColumn";
            // 
            // Korm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 417);
            this.Controls.Add(this.b_poisk);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.b_udalit);
            this.Controls.Add(this.b_redactirovat);
            this.Controls.Add(this.b_dobavit);
            this.Controls.Add(this.b_infirmation);
            this.Controls.Add(this.b_grafik);
            this.Controls.Add(this.b_otchet);
            this.Controls.Add(this.b_tabel);
            this.Controls.Add(this.b_korm);
            this.Controls.Add(this.b_hudoba);
            this.Controls.Add(this.b_personal);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Korm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Korm";
            this.Load += new System.EventHandler(this.Korm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fermDataSetLastV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kormBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button b_infirmation;
        private System.Windows.Forms.Button b_grafik;
        private System.Windows.Forms.Button b_otchet;
        private System.Windows.Forms.Button b_tabel;
        private System.Windows.Forms.Button b_korm;
        private System.Windows.Forms.Button b_hudoba;
        private System.Windows.Forms.Button b_personal;
        private System.Windows.Forms.Button b_poisk;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button b_udalit;
        private System.Windows.Forms.Button b_redactirovat;
        private System.Windows.Forms.Button b_dobavit;
        private fermDataSetLastV fermDataSetLastV;
        private System.Windows.Forms.BindingSource kormBindingSource;
        private fermDataSetLastVTableAdapters.kormTableAdapter kormTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idkormDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn makuhaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn otrubDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kukuruzaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ovesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yachminDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sinoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn solomaDataGridViewTextBoxColumn;
    }
}