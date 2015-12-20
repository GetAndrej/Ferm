namespace Ferm_V2
{
    partial class Hudoba
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.b_personal = new System.Windows.Forms.Button();
            this.b_hudoba = new System.Windows.Forms.Button();
            this.b_korm = new System.Windows.Forms.Button();
            this.b_tabel = new System.Windows.Forms.Button();
            this.b_otchet = new System.Windows.Forms.Button();
            this.b_grafik = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idcowDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.klichkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.polDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.databirthdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inwertnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iddoyarkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.privivkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cowBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.fermDataSet = new Ferm_V2.fermDataSet();
            this.b_infirmation = new System.Windows.Forms.Button();
            this.b_dobavit = new System.Windows.Forms.Button();
            this.b_redactirovat = new System.Windows.Forms.Button();
            this.b_udalit = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.b_poisk = new System.Windows.Forms.Button();
            this.b_obnovit = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cowTableAdapter = new Ferm_V2.fermDataSetTableAdapters.cowTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cowBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fermDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // b_personal
            // 
            this.b_personal.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_personal.Location = new System.Drawing.Point(12, 67);
            this.b_personal.Name = "b_personal";
            this.b_personal.Size = new System.Drawing.Size(100, 50);
            this.b_personal.TabIndex = 0;
            this.b_personal.Text = "Персонал";
            this.b_personal.UseVisualStyleBackColor = true;
            this.b_personal.Click += new System.EventHandler(this.b_personal_Click);
            // 
            // b_hudoba
            // 
            this.b_hudoba.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_hudoba.Location = new System.Drawing.Point(12, 11);
            this.b_hudoba.Name = "b_hudoba";
            this.b_hudoba.Size = new System.Drawing.Size(100, 50);
            this.b_hudoba.TabIndex = 1;
            this.b_hudoba.Text = "Худоба";
            this.b_hudoba.UseVisualStyleBackColor = true;
            this.b_hudoba.Click += new System.EventHandler(this.b_hudoba_Click);
            // 
            // b_korm
            // 
            this.b_korm.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_korm.Location = new System.Drawing.Point(12, 123);
            this.b_korm.Name = "b_korm";
            this.b_korm.Size = new System.Drawing.Size(100, 50);
            this.b_korm.TabIndex = 2;
            this.b_korm.Text = "Корм";
            this.b_korm.UseVisualStyleBackColor = true;
            this.b_korm.Click += new System.EventHandler(this.b_korm_Click);
            // 
            // b_tabel
            // 
            this.b_tabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_tabel.Location = new System.Drawing.Point(12, 179);
            this.b_tabel.Name = "b_tabel";
            this.b_tabel.Size = new System.Drawing.Size(100, 50);
            this.b_tabel.TabIndex = 4;
            this.b_tabel.Text = "Табель";
            this.b_tabel.UseVisualStyleBackColor = true;
            this.b_tabel.Click += new System.EventHandler(this.b_tabel_Click);
            // 
            // b_otchet
            // 
            this.b_otchet.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_otchet.Location = new System.Drawing.Point(12, 235);
            this.b_otchet.Name = "b_otchet";
            this.b_otchet.Size = new System.Drawing.Size(100, 50);
            this.b_otchet.TabIndex = 6;
            this.b_otchet.Text = "Отчет";
            this.b_otchet.UseVisualStyleBackColor = true;
            this.b_otchet.Click += new System.EventHandler(this.b_otchet_Click);
            // 
            // b_grafik
            // 
            this.b_grafik.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_grafik.Location = new System.Drawing.Point(12, 291);
            this.b_grafik.Name = "b_grafik";
            this.b_grafik.Size = new System.Drawing.Size(100, 50);
            this.b_grafik.TabIndex = 8;
            this.b_grafik.Text = "Графики";
            this.b_grafik.UseVisualStyleBackColor = true;
            this.b_grafik.Click += new System.EventHandler(this.b_grafik_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcowDataGridViewTextBoxColumn,
            this.klichkaDataGridViewTextBoxColumn,
            this.polDataGridViewTextBoxColumn,
            this.databirthdayDataGridViewTextBoxColumn,
            this.kodDataGridViewTextBoxColumn,
            this.inwertnumberDataGridViewTextBoxColumn,
            this.iddoyarkaDataGridViewTextBoxColumn,
            this.privivkaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cowBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(118, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(841, 338);
            this.dataGridView1.TabIndex = 9;
            // 
            // idcowDataGridViewTextBoxColumn
            // 
            this.idcowDataGridViewTextBoxColumn.DataPropertyName = "id_cow";
            this.idcowDataGridViewTextBoxColumn.HeaderText = "id_cow";
            this.idcowDataGridViewTextBoxColumn.Name = "idcowDataGridViewTextBoxColumn";
            // 
            // klichkaDataGridViewTextBoxColumn
            // 
            this.klichkaDataGridViewTextBoxColumn.DataPropertyName = "klichka";
            this.klichkaDataGridViewTextBoxColumn.HeaderText = "klichka";
            this.klichkaDataGridViewTextBoxColumn.Name = "klichkaDataGridViewTextBoxColumn";
            // 
            // polDataGridViewTextBoxColumn
            // 
            this.polDataGridViewTextBoxColumn.DataPropertyName = "pol";
            this.polDataGridViewTextBoxColumn.HeaderText = "pol";
            this.polDataGridViewTextBoxColumn.Name = "polDataGridViewTextBoxColumn";
            // 
            // databirthdayDataGridViewTextBoxColumn
            // 
            this.databirthdayDataGridViewTextBoxColumn.DataPropertyName = "data_birthday";
            this.databirthdayDataGridViewTextBoxColumn.HeaderText = "data_birthday";
            this.databirthdayDataGridViewTextBoxColumn.Name = "databirthdayDataGridViewTextBoxColumn";
            // 
            // kodDataGridViewTextBoxColumn
            // 
            this.kodDataGridViewTextBoxColumn.DataPropertyName = "kod";
            this.kodDataGridViewTextBoxColumn.HeaderText = "kod";
            this.kodDataGridViewTextBoxColumn.Name = "kodDataGridViewTextBoxColumn";
            // 
            // inwertnumberDataGridViewTextBoxColumn
            // 
            this.inwertnumberDataGridViewTextBoxColumn.DataPropertyName = "inwert_number";
            this.inwertnumberDataGridViewTextBoxColumn.HeaderText = "inwert_number";
            this.inwertnumberDataGridViewTextBoxColumn.Name = "inwertnumberDataGridViewTextBoxColumn";
            // 
            // iddoyarkaDataGridViewTextBoxColumn
            // 
            this.iddoyarkaDataGridViewTextBoxColumn.DataPropertyName = "id_doyarka";
            this.iddoyarkaDataGridViewTextBoxColumn.HeaderText = "id_doyarka";
            this.iddoyarkaDataGridViewTextBoxColumn.Name = "iddoyarkaDataGridViewTextBoxColumn";
            // 
            // privivkaDataGridViewTextBoxColumn
            // 
            this.privivkaDataGridViewTextBoxColumn.DataPropertyName = "privivka";
            this.privivkaDataGridViewTextBoxColumn.HeaderText = "privivka";
            this.privivkaDataGridViewTextBoxColumn.Name = "privivkaDataGridViewTextBoxColumn";
            // 
            // cowBindingSource2
            // 
            this.cowBindingSource2.DataMember = "cow";
            this.cowBindingSource2.DataSource = this.fermDataSet;
            // 
            // fermDataSet
            // 
            this.fermDataSet.DataSetName = "fermDataSet";
            this.fermDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // b_infirmation
            // 
            this.b_infirmation.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_infirmation.Location = new System.Drawing.Point(12, 347);
            this.b_infirmation.Name = "b_infirmation";
            this.b_infirmation.Size = new System.Drawing.Size(100, 50);
            this.b_infirmation.TabIndex = 10;
            this.b_infirmation.Text = "Информация";
            this.b_infirmation.UseVisualStyleBackColor = true;
            // 
            // b_dobavit
            // 
            this.b_dobavit.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_dobavit.Location = new System.Drawing.Point(133, 11);
            this.b_dobavit.Name = "b_dobavit";
            this.b_dobavit.Size = new System.Drawing.Size(100, 40);
            this.b_dobavit.TabIndex = 12;
            this.b_dobavit.Text = "Редактировать";
            this.b_dobavit.UseVisualStyleBackColor = true;
            this.b_dobavit.Click += new System.EventHandler(this.b_dobavit_Click);
            // 
            // b_redactirovat
            // 
            this.b_redactirovat.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_redactirovat.Location = new System.Drawing.Point(239, 11);
            this.b_redactirovat.Name = "b_redactirovat";
            this.b_redactirovat.Size = new System.Drawing.Size(100, 40);
            this.b_redactirovat.TabIndex = 14;
            this.b_redactirovat.Text = "Добавить";
            this.b_redactirovat.UseVisualStyleBackColor = true;
            this.b_redactirovat.Click += new System.EventHandler(this.b_redactirovat_Click);
            // 
            // b_udalit
            // 
            this.b_udalit.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_udalit.Location = new System.Drawing.Point(345, 11);
            this.b_udalit.Name = "b_udalit";
            this.b_udalit.Size = new System.Drawing.Size(100, 40);
            this.b_udalit.TabIndex = 16;
            this.b_udalit.Text = "Удалить";
            this.b_udalit.UseVisualStyleBackColor = true;
            this.b_udalit.Click += new System.EventHandler(this.b_udalit_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(550, 16);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(316, 25);
            this.textBox1.TabIndex = 17;
            // 
            // b_poisk
            // 
            this.b_poisk.Location = new System.Drawing.Point(884, 16);
            this.b_poisk.Name = "b_poisk";
            this.b_poisk.Size = new System.Drawing.Size(75, 25);
            this.b_poisk.TabIndex = 18;
            this.b_poisk.Text = "Поиск";
            this.b_poisk.UseVisualStyleBackColor = true;
            // 
            // b_obnovit
            // 
            this.b_obnovit.Location = new System.Drawing.Point(478, 17);
            this.b_obnovit.Name = "b_obnovit";
            this.b_obnovit.Size = new System.Drawing.Size(51, 23);
            this.b_obnovit.TabIndex = 19;
            this.b_obnovit.Text = "Обновить";
            this.b_obnovit.UseVisualStyleBackColor = true;
            this.b_obnovit.Click += new System.EventHandler(this.b_obnovit_Click);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.fermDataSet;
            this.bindingSource1.Position = 0;
            // 
            // cowTableAdapter
            // 
            this.cowTableAdapter.ClearBeforeFill = true;
            // 
            // Hudoba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 440);
            this.Controls.Add(this.b_obnovit);
            this.Controls.Add(this.b_poisk);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.b_udalit);
            this.Controls.Add(this.b_redactirovat);
            this.Controls.Add(this.b_dobavit);
            this.Controls.Add(this.b_infirmation);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.b_grafik);
            this.Controls.Add(this.b_otchet);
            this.Controls.Add(this.b_tabel);
            this.Controls.Add(this.b_korm);
            this.Controls.Add(this.b_hudoba);
            this.Controls.Add(this.b_personal);
            this.Name = "Hudoba";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hudoba";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cowBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fermDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_personal;
        private System.Windows.Forms.Button b_hudoba;
        private System.Windows.Forms.Button b_korm;
        private System.Windows.Forms.Button b_tabel;
        private System.Windows.Forms.Button b_otchet;
        private System.Windows.Forms.Button b_grafik;
        private System.Windows.Forms.BindingSource bindingSource1;
        private fermDataSet fermDataSet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button b_infirmation;
        private System.Windows.Forms.Button b_dobavit;
        private System.Windows.Forms.Button b_redactirovat;
        private System.Windows.Forms.Button b_udalit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button b_poisk;
        public fermDataSetTableAdapters.cowTableAdapter cowTableAdapter;
        private System.Windows.Forms.Button b_obnovit;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcowDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn klichkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn polDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn databirthdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inwertnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddoyarkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn privivkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource cowBindingSource2;
    }
}

