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
            this.personalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fermDataSetLastV = new Ferm_V2.fermDataSetLastV();
            this.b_personal = new System.Windows.Forms.Button();
            this.b_poisk = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.b_udalit = new System.Windows.Forms.Button();
            this.b_redactirovat = new System.Windows.Forms.Button();
            this.b_dobavit = new System.Windows.Forms.Button();
            this.personalTableAdapter = new Ferm_V2.fermDataSetLastVTableAdapters.personalTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fermDataSetLastV)).BeginInit();
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
            this.telephoneDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.personalBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(11, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(961, 591);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 50;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 200;
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
            this.addressDataGridViewTextBoxColumn.Width = 170;
            // 
            // telephoneDataGridViewTextBoxColumn
            // 
            this.telephoneDataGridViewTextBoxColumn.DataPropertyName = "telephone";
            this.telephoneDataGridViewTextBoxColumn.HeaderText = "telephone";
            this.telephoneDataGridViewTextBoxColumn.Name = "telephoneDataGridViewTextBoxColumn";
            this.telephoneDataGridViewTextBoxColumn.Width = 200;
            // 
            // personalBindingSource
            // 
            this.personalBindingSource.DataMember = "personal";
            this.personalBindingSource.DataSource = this.fermDataSetLastV;
            // 
            // fermDataSetLastV
            // 
            this.fermDataSetLastV.DataSetName = "fermDataSetLastV";
            this.fermDataSetLastV.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // b_personal
            // 
            this.b_personal.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.b_personal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.b_personal.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_personal.Location = new System.Drawing.Point(11, 8);
            this.b_personal.Name = "b_personal";
            this.b_personal.Size = new System.Drawing.Size(100, 40);
            this.b_personal.TabIndex = 11;
            this.b_personal.Text = "Назад";
            this.b_personal.UseVisualStyleBackColor = true;
            this.b_personal.Click += new System.EventHandler(this.b_personal_Click);
            // 
            // b_poisk
            // 
            this.b_poisk.Location = new System.Drawing.Point(897, 17);
            this.b_poisk.Name = "b_poisk";
            this.b_poisk.Size = new System.Drawing.Size(75, 25);
            this.b_poisk.TabIndex = 23;
            this.b_poisk.Text = "Поиск";
            this.b_poisk.UseVisualStyleBackColor = true;
            this.b_poisk.Click += new System.EventHandler(this.b_poisk_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(636, 17);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(250, 25);
            this.textBox1.TabIndex = 22;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // b_udalit
            // 
            this.b_udalit.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_udalit.Location = new System.Drawing.Point(386, 8);
            this.b_udalit.Name = "b_udalit";
            this.b_udalit.Size = new System.Drawing.Size(100, 40);
            this.b_udalit.TabIndex = 21;
            this.b_udalit.Text = "Удалить";
            this.b_udalit.UseVisualStyleBackColor = true;
            this.b_udalit.Click += new System.EventHandler(this.b_udalit_Click);
            // 
            // b_redactirovat
            // 
            this.b_redactirovat.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.b_redactirovat.Location = new System.Drawing.Point(280, 8);
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
            this.b_dobavit.Location = new System.Drawing.Point(174, 8);
            this.b_dobavit.Name = "b_dobavit";
            this.b_dobavit.Size = new System.Drawing.Size(100, 40);
            this.b_dobavit.TabIndex = 19;
            this.b_dobavit.Text = "Добавить";
            this.b_dobavit.UseVisualStyleBackColor = true;
            this.b_dobavit.Click += new System.EventHandler(this.b_dobavit_Click);
            // 
            // personalTableAdapter
            // 
            this.personalTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.button2.Location = new System.Drawing.Point(535, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 40);
            this.button2.TabIndex = 25;
            this.button2.Text = "Обновить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Personal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.b_poisk);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.b_udalit);
            this.Controls.Add(this.b_redactirovat);
            this.Controls.Add(this.b_dobavit);
            this.Controls.Add(this.b_personal);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Personal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Персонал";
            this.Load += new System.EventHandler(this.Personal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fermDataSetLastV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button b_personal;
        private System.Windows.Forms.Button b_poisk;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button b_udalit;
        private System.Windows.Forms.Button b_redactirovat;
        private System.Windows.Forms.Button b_dobavit;
        private fermDataSetLastV fermDataSetLastV;
        private System.Windows.Forms.BindingSource personalBindingSource;
        private fermDataSetLastVTableAdapters.personalTableAdapter personalTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
    }
}