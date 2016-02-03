namespace Ferm_V2
{
    partial class Zarplata
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
            this.idzarplataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zarpmilkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zarpmoneyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.primechanieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zarplataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fermDataSetLastV = new Ferm_V2.fermDataSetLastV();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.zarplataTableAdapter = new Ferm_V2.fermDataSetLastVTableAdapters.zarplataTableAdapter();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zarplataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fermDataSetLastV)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idzarplataDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.idpersDataGridViewTextBoxColumn,
            this.zarpmilkDataGridViewTextBoxColumn,
            this.zarpmoneyDataGridViewTextBoxColumn,
            this.primechanieDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.zarplataBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(743, 452);
            this.dataGridView1.TabIndex = 0;
            // 
            // idzarplataDataGridViewTextBoxColumn
            // 
            this.idzarplataDataGridViewTextBoxColumn.DataPropertyName = "id_zarplata";
            this.idzarplataDataGridViewTextBoxColumn.HeaderText = "id_zarplata";
            this.idzarplataDataGridViewTextBoxColumn.Name = "idzarplataDataGridViewTextBoxColumn";
            this.idzarplataDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idpersDataGridViewTextBoxColumn
            // 
            this.idpersDataGridViewTextBoxColumn.DataPropertyName = "id_pers";
            this.idpersDataGridViewTextBoxColumn.HeaderText = "id_pers";
            this.idpersDataGridViewTextBoxColumn.Name = "idpersDataGridViewTextBoxColumn";
            this.idpersDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // zarpmilkDataGridViewTextBoxColumn
            // 
            this.zarpmilkDataGridViewTextBoxColumn.DataPropertyName = "zarp_milk";
            this.zarpmilkDataGridViewTextBoxColumn.HeaderText = "zarp_milk";
            this.zarpmilkDataGridViewTextBoxColumn.Name = "zarpmilkDataGridViewTextBoxColumn";
            this.zarpmilkDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // zarpmoneyDataGridViewTextBoxColumn
            // 
            this.zarpmoneyDataGridViewTextBoxColumn.DataPropertyName = "zarp_money";
            this.zarpmoneyDataGridViewTextBoxColumn.HeaderText = "zarp_money";
            this.zarpmoneyDataGridViewTextBoxColumn.Name = "zarpmoneyDataGridViewTextBoxColumn";
            this.zarpmoneyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // primechanieDataGridViewTextBoxColumn
            // 
            this.primechanieDataGridViewTextBoxColumn.DataPropertyName = "primechanie";
            this.primechanieDataGridViewTextBoxColumn.HeaderText = "primechanie";
            this.primechanieDataGridViewTextBoxColumn.Name = "primechanieDataGridViewTextBoxColumn";
            this.primechanieDataGridViewTextBoxColumn.ReadOnly = true;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 43);
            this.button1.TabIndex = 1;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(161, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 43);
            this.button2.TabIndex = 2;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(262, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 43);
            this.button3.TabIndex = 3;
            this.button3.Text = "Редактировать";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(363, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(95, 43);
            this.button4.TabIndex = 4;
            this.button4.Text = "Удалить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // zarplataTableAdapter
            // 
            this.zarplataTableAdapter.ClearBeforeFill = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(651, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(95, 43);
            this.button5.TabIndex = 5;
            this.button5.Text = "Обновить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Zarplata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 534);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Zarplata";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Зарплата";
            this.Load += new System.EventHandler(this.Zarplata_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zarplataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fermDataSetLastV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private fermDataSetLastV fermDataSetLastV;
        private System.Windows.Forms.BindingSource zarplataBindingSource;
        private fermDataSetLastVTableAdapters.zarplataTableAdapter zarplataTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idzarplataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zarpmilkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zarpmoneyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn primechanieDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button5;
    }
}