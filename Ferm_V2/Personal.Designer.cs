namespace Ferm_V2
{
    partial class Personal
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
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zarplataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fermDataSet1 = new Ferm_V2.fermDataSet1();
            this.personalTableAdapter = new Ferm_V2.fermDataSet1TableAdapters.personalTableAdapter();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fermDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.positionDataGridViewTextBoxColumn,
            this.birthdayDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.telephoneDataGridViewTextBoxColumn,
            this.zarplataDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.personalBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(118, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(847, 330);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // positionDataGridViewTextBoxColumn
            // 
            this.positionDataGridViewTextBoxColumn.DataPropertyName = "position";
            this.positionDataGridViewTextBoxColumn.HeaderText = "position";
            this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            // 
            // birthdayDataGridViewTextBoxColumn
            // 
            this.birthdayDataGridViewTextBoxColumn.DataPropertyName = "birthday";
            this.birthdayDataGridViewTextBoxColumn.HeaderText = "birthday";
            this.birthdayDataGridViewTextBoxColumn.Name = "birthdayDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = " address";
            this.addressDataGridViewTextBoxColumn.HeaderText = " address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // telephoneDataGridViewTextBoxColumn
            // 
            this.telephoneDataGridViewTextBoxColumn.DataPropertyName = "telephone";
            this.telephoneDataGridViewTextBoxColumn.HeaderText = "telephone";
            this.telephoneDataGridViewTextBoxColumn.Name = "telephoneDataGridViewTextBoxColumn";
            // 
            // zarplataDataGridViewTextBoxColumn
            // 
            this.zarplataDataGridViewTextBoxColumn.DataPropertyName = "zarplata";
            this.zarplataDataGridViewTextBoxColumn.HeaderText = "zarplata";
            this.zarplataDataGridViewTextBoxColumn.Name = "zarplataDataGridViewTextBoxColumn";
            // 
            // personalBindingSource
            // 
            this.personalBindingSource.DataMember = "personal";
            this.personalBindingSource.DataSource = this.bindingSource1;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.fermDataSet1;
            this.bindingSource1.Position = 0;
            // 
            // fermDataSet1
            // 
            this.fermDataSet1.DataSetName = "fermDataSet1";
            this.fermDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personalTableAdapter
            // 
            this.personalTableAdapter.ClearBeforeFill = true;
            // 
            // b_infirmation
            // 
            this.b_infirmation.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_infirmation.Location = new System.Drawing.Point(12, 348);
            this.b_infirmation.Name = "b_infirmation";
            this.b_infirmation.Size = new System.Drawing.Size(100, 40);
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
            this.b_poisk.Location = new System.Drawing.Point(889, 17);
            this.b_poisk.Name = "b_poisk";
            this.b_poisk.Size = new System.Drawing.Size(75, 25);
            this.b_poisk.TabIndex = 23;
            this.b_poisk.Text = "Поиск";
            this.b_poisk.UseVisualStyleBackColor = true;
            this.b_poisk.Click += new System.EventHandler(this.b_poisk_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(555, 17);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(316, 25);
            this.textBox1.TabIndex = 22;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // b_udalit
            // 
            this.b_udalit.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_udalit.Location = new System.Drawing.Point(350, 12);
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
            this.b_redactirovat.Location = new System.Drawing.Point(244, 12);
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
            this.b_dobavit.Location = new System.Drawing.Point(138, 12);
            this.b_dobavit.Name = "b_dobavit";
            this.b_dobavit.Size = new System.Drawing.Size(100, 40);
            this.b_dobavit.TabIndex = 19;
            this.b_dobavit.Text = "Добавить";
            this.b_dobavit.UseVisualStyleBackColor = true;
            this.b_dobavit.Click += new System.EventHandler(this.b_dobavit_Click);
            // 
            // Personal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 470);
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
            this.Name = "Personal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personal";
            this.Load += new System.EventHandler(this.Personal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fermDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private fermDataSet1 fermDataSet1;
        private System.Windows.Forms.BindingSource personalBindingSource;
        private fermDataSet1TableAdapters.personalTableAdapter personalTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zarplataDataGridViewTextBoxColumn;
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
    }
}