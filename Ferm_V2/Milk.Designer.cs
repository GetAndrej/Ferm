namespace Ferm_V2
{
    partial class Milk
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
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpersonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.utroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vechirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pogolovDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vipoytelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obratDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zhirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zavodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otpravkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vsegodayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.milkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fermDataSetLastV = new Ferm_V2.fermDataSetLastV();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.milkTableAdapter = new Ferm_V2.fermDataSetLastVTableAdapters.milkTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.milkBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fermDataSetLastV)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataDataGridViewTextBoxColumn,
            this.idpersonDataGridViewTextBoxColumn,
            this.utroDataGridViewTextBoxColumn,
            this.obedDataGridViewTextBoxColumn,
            this.vechirDataGridViewTextBoxColumn,
            this.pogolovDataGridViewTextBoxColumn,
            this.vipoytelDataGridViewTextBoxColumn,
            this.obratDataGridViewTextBoxColumn,
            this.zhirDataGridViewTextBoxColumn,
            this.zavodDataGridViewTextBoxColumn,
            this.otpravkaDataGridViewTextBoxColumn,
            this.vsegodayDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.milkBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(5, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1230, 440);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idpersonDataGridViewTextBoxColumn
            // 
            this.idpersonDataGridViewTextBoxColumn.DataPropertyName = "id_person";
            this.idpersonDataGridViewTextBoxColumn.HeaderText = "id_person";
            this.idpersonDataGridViewTextBoxColumn.Name = "idpersonDataGridViewTextBoxColumn";
            this.idpersonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // utroDataGridViewTextBoxColumn
            // 
            this.utroDataGridViewTextBoxColumn.DataPropertyName = "utro";
            this.utroDataGridViewTextBoxColumn.HeaderText = "utro";
            this.utroDataGridViewTextBoxColumn.Name = "utroDataGridViewTextBoxColumn";
            this.utroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // obedDataGridViewTextBoxColumn
            // 
            this.obedDataGridViewTextBoxColumn.DataPropertyName = "obed";
            this.obedDataGridViewTextBoxColumn.HeaderText = "obed";
            this.obedDataGridViewTextBoxColumn.Name = "obedDataGridViewTextBoxColumn";
            this.obedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vechirDataGridViewTextBoxColumn
            // 
            this.vechirDataGridViewTextBoxColumn.DataPropertyName = "vechir";
            this.vechirDataGridViewTextBoxColumn.HeaderText = "vechir";
            this.vechirDataGridViewTextBoxColumn.Name = "vechirDataGridViewTextBoxColumn";
            this.vechirDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pogolovDataGridViewTextBoxColumn
            // 
            this.pogolovDataGridViewTextBoxColumn.DataPropertyName = "pogolov";
            this.pogolovDataGridViewTextBoxColumn.HeaderText = "pogolov";
            this.pogolovDataGridViewTextBoxColumn.Name = "pogolovDataGridViewTextBoxColumn";
            this.pogolovDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vipoytelDataGridViewTextBoxColumn
            // 
            this.vipoytelDataGridViewTextBoxColumn.DataPropertyName = "vipoy_tel";
            this.vipoytelDataGridViewTextBoxColumn.HeaderText = "vipoy_tel";
            this.vipoytelDataGridViewTextBoxColumn.Name = "vipoytelDataGridViewTextBoxColumn";
            this.vipoytelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // obratDataGridViewTextBoxColumn
            // 
            this.obratDataGridViewTextBoxColumn.DataPropertyName = "obrat";
            this.obratDataGridViewTextBoxColumn.HeaderText = "obrat";
            this.obratDataGridViewTextBoxColumn.Name = "obratDataGridViewTextBoxColumn";
            this.obratDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // zhirDataGridViewTextBoxColumn
            // 
            this.zhirDataGridViewTextBoxColumn.DataPropertyName = "zhir";
            this.zhirDataGridViewTextBoxColumn.HeaderText = "zhir";
            this.zhirDataGridViewTextBoxColumn.Name = "zhirDataGridViewTextBoxColumn";
            this.zhirDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // zavodDataGridViewTextBoxColumn
            // 
            this.zavodDataGridViewTextBoxColumn.DataPropertyName = "zavod";
            this.zavodDataGridViewTextBoxColumn.HeaderText = "zavod";
            this.zavodDataGridViewTextBoxColumn.Name = "zavodDataGridViewTextBoxColumn";
            this.zavodDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // otpravkaDataGridViewTextBoxColumn
            // 
            this.otpravkaDataGridViewTextBoxColumn.DataPropertyName = "otpravka";
            this.otpravkaDataGridViewTextBoxColumn.HeaderText = "otpravka";
            this.otpravkaDataGridViewTextBoxColumn.Name = "otpravkaDataGridViewTextBoxColumn";
            this.otpravkaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vsegodayDataGridViewTextBoxColumn
            // 
            this.vsegodayDataGridViewTextBoxColumn.DataPropertyName = "vsego_day";
            this.vsegodayDataGridViewTextBoxColumn.HeaderText = "vsego_day";
            this.vsegodayDataGridViewTextBoxColumn.Name = "vsegodayDataGridViewTextBoxColumn";
            this.vsegodayDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // milkBindingSource
            // 
            this.milkBindingSource.DataMember = "milk";
            this.milkBindingSource.DataSource = this.fermDataSetLastV;
            // 
            // fermDataSetLastV
            // 
            this.fermDataSetLastV.DataSetName = "fermDataSetLastV";
            this.fermDataSetLastV.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(164, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 44);
            this.button2.TabIndex = 2;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(278, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(139, 44);
            this.button3.TabIndex = 3;
            this.button3.Text = "Редактировать";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(423, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(108, 44);
            this.button4.TabIndex = 4;
            this.button4.Text = "Удалить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(1092, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(110, 44);
            this.button5.TabIndex = 5;
            this.button5.Text = "Обновить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // milkTableAdapter
            // 
            this.milkTableAdapter.ClearBeforeFill = true;
            // 
            // Milk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 528);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Milk";
            this.Text = "Milk";
            this.Load += new System.EventHandler(this.Milk_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.milkBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fermDataSetLastV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private fermDataSetLastV fermDataSetLastV;
        private System.Windows.Forms.BindingSource milkBindingSource;
        private fermDataSetLastVTableAdapters.milkTableAdapter milkTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpersonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn utroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn obedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vechirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pogolovDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vipoytelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn obratDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zhirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zavodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn otpravkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vsegodayDataGridViewTextBoxColumn;
    }
}