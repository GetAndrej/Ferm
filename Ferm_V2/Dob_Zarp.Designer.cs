namespace Ferm_V2
{
    partial class Dob_Zarp
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
            System.Windows.Forms.Label id_zarplataLabel;
            System.Windows.Forms.Label dataLabel;
            System.Windows.Forms.Label id_persLabel;
            System.Windows.Forms.Label zarp_milkLabel;
            System.Windows.Forms.Label zarp_moneyLabel;
            System.Windows.Forms.Label primechanieLabel;
            this.fermDataSetLastV = new Ferm_V2.fermDataSetLastV();
            this.zarplataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zarplataTableAdapter = new Ferm_V2.fermDataSetLastVTableAdapters.zarplataTableAdapter();
            this.tableAdapterManager = new Ferm_V2.fermDataSetLastVTableAdapters.TableAdapterManager();
            this.id_zarplataTextBox = new System.Windows.Forms.TextBox();
            this.dataDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.id_persTextBox = new System.Windows.Forms.TextBox();
            this.zarp_milkTextBox = new System.Windows.Forms.TextBox();
            this.zarp_moneyTextBox = new System.Windows.Forms.TextBox();
            this.primechanieTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            id_zarplataLabel = new System.Windows.Forms.Label();
            dataLabel = new System.Windows.Forms.Label();
            id_persLabel = new System.Windows.Forms.Label();
            zarp_milkLabel = new System.Windows.Forms.Label();
            zarp_moneyLabel = new System.Windows.Forms.Label();
            primechanieLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fermDataSetLastV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zarplataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // id_zarplataLabel
            // 
            id_zarplataLabel.AutoSize = true;
            id_zarplataLabel.Location = new System.Drawing.Point(12, 23);
            id_zarplataLabel.Name = "id_zarplataLabel";
            id_zarplataLabel.Size = new System.Drawing.Size(58, 13);
            id_zarplataLabel.TabIndex = 1;
            id_zarplataLabel.Text = "id zarplata:";
            // 
            // dataLabel
            // 
            dataLabel.AutoSize = true;
            dataLabel.Location = new System.Drawing.Point(12, 50);
            dataLabel.Name = "dataLabel";
            dataLabel.Size = new System.Drawing.Size(31, 13);
            dataLabel.TabIndex = 3;
            dataLabel.Text = "data:";
            // 
            // id_persLabel
            // 
            id_persLabel.AutoSize = true;
            id_persLabel.Location = new System.Drawing.Point(12, 75);
            id_persLabel.Name = "id_persLabel";
            id_persLabel.Size = new System.Drawing.Size(41, 13);
            id_persLabel.TabIndex = 5;
            id_persLabel.Text = "id pers:";
            // 
            // zarp_milkLabel
            // 
            zarp_milkLabel.AutoSize = true;
            zarp_milkLabel.Location = new System.Drawing.Point(12, 101);
            zarp_milkLabel.Name = "zarp_milkLabel";
            zarp_milkLabel.Size = new System.Drawing.Size(51, 13);
            zarp_milkLabel.TabIndex = 7;
            zarp_milkLabel.Text = "zarp milk:";
            // 
            // zarp_moneyLabel
            // 
            zarp_moneyLabel.AutoSize = true;
            zarp_moneyLabel.Location = new System.Drawing.Point(12, 127);
            zarp_moneyLabel.Name = "zarp_moneyLabel";
            zarp_moneyLabel.Size = new System.Drawing.Size(64, 13);
            zarp_moneyLabel.TabIndex = 9;
            zarp_moneyLabel.Text = "zarp money:";
            // 
            // primechanieLabel
            // 
            primechanieLabel.AutoSize = true;
            primechanieLabel.Location = new System.Drawing.Point(12, 153);
            primechanieLabel.Name = "primechanieLabel";
            primechanieLabel.Size = new System.Drawing.Size(67, 13);
            primechanieLabel.TabIndex = 11;
            primechanieLabel.Text = "primechanie:";
            // 
            // fermDataSetLastV
            // 
            this.fermDataSetLastV.DataSetName = "fermDataSetLastV";
            this.fermDataSetLastV.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zarplataBindingSource
            // 
            this.zarplataBindingSource.DataMember = "zarplata";
            this.zarplataBindingSource.DataSource = this.fermDataSetLastV;
            // 
            // zarplataTableAdapter
            // 
            this.zarplataTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.cowTableAdapter = null;
            this.tableAdapterManager.kormTableAdapter = null;
            this.tableAdapterManager.loginTableAdapter = null;
            this.tableAdapterManager.mesto_corTableAdapter = null;
            this.tableAdapterManager.milkTableAdapter = null;
            this.tableAdapterManager.personalTableAdapter = null;
            this.tableAdapterManager.tabelTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Ferm_V2.fermDataSetLastVTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.zarplataTableAdapter = this.zarplataTableAdapter;
            // 
            // id_zarplataTextBox
            // 
            this.id_zarplataTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zarplataBindingSource, "id_zarplata", true));
            this.id_zarplataTextBox.Location = new System.Drawing.Point(85, 20);
            this.id_zarplataTextBox.Name = "id_zarplataTextBox";
            this.id_zarplataTextBox.Size = new System.Drawing.Size(200, 20);
            this.id_zarplataTextBox.TabIndex = 2;
            // 
            // dataDateTimePicker
            // 
            this.dataDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.zarplataBindingSource, "data", true));
            this.dataDateTimePicker.Location = new System.Drawing.Point(85, 46);
            this.dataDateTimePicker.Name = "dataDateTimePicker";
            this.dataDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dataDateTimePicker.TabIndex = 4;
            // 
            // id_persTextBox
            // 
            this.id_persTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zarplataBindingSource, "id_pers", true));
            this.id_persTextBox.Location = new System.Drawing.Point(85, 72);
            this.id_persTextBox.Name = "id_persTextBox";
            this.id_persTextBox.Size = new System.Drawing.Size(200, 20);
            this.id_persTextBox.TabIndex = 6;
            // 
            // zarp_milkTextBox
            // 
            this.zarp_milkTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zarplataBindingSource, "zarp_milk", true));
            this.zarp_milkTextBox.Location = new System.Drawing.Point(85, 98);
            this.zarp_milkTextBox.Name = "zarp_milkTextBox";
            this.zarp_milkTextBox.Size = new System.Drawing.Size(200, 20);
            this.zarp_milkTextBox.TabIndex = 8;
            // 
            // zarp_moneyTextBox
            // 
            this.zarp_moneyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zarplataBindingSource, "zarp_money", true));
            this.zarp_moneyTextBox.Location = new System.Drawing.Point(85, 124);
            this.zarp_moneyTextBox.Name = "zarp_moneyTextBox";
            this.zarp_moneyTextBox.Size = new System.Drawing.Size(200, 20);
            this.zarp_moneyTextBox.TabIndex = 10;
            // 
            // primechanieTextBox
            // 
            this.primechanieTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zarplataBindingSource, "primechanie", true));
            this.primechanieTextBox.Location = new System.Drawing.Point(85, 150);
            this.primechanieTextBox.Name = "primechanieTextBox";
            this.primechanieTextBox.Size = new System.Drawing.Size(200, 20);
            this.primechanieTextBox.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(162, 188);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Dob_Zarp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 232);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(id_zarplataLabel);
            this.Controls.Add(this.id_zarplataTextBox);
            this.Controls.Add(dataLabel);
            this.Controls.Add(this.dataDateTimePicker);
            this.Controls.Add(id_persLabel);
            this.Controls.Add(this.id_persTextBox);
            this.Controls.Add(zarp_milkLabel);
            this.Controls.Add(this.zarp_milkTextBox);
            this.Controls.Add(zarp_moneyLabel);
            this.Controls.Add(this.zarp_moneyTextBox);
            this.Controls.Add(primechanieLabel);
            this.Controls.Add(this.primechanieTextBox);
            this.Name = "Dob_Zarp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dob_Zarp";
            this.Load += new System.EventHandler(this.Dob_Zarp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fermDataSetLastV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zarplataBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private fermDataSetLastV fermDataSetLastV;
        private System.Windows.Forms.BindingSource zarplataBindingSource;
        private fermDataSetLastVTableAdapters.zarplataTableAdapter zarplataTableAdapter;
        private fermDataSetLastVTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox id_zarplataTextBox;
        private System.Windows.Forms.DateTimePicker dataDateTimePicker;
        private System.Windows.Forms.TextBox id_persTextBox;
        private System.Windows.Forms.TextBox zarp_milkTextBox;
        private System.Windows.Forms.TextBox zarp_moneyTextBox;
        private System.Windows.Forms.TextBox primechanieTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}