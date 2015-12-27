namespace Ferm_V2
{
    partial class Dob_Korm
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
            System.Windows.Forms.Label id_kormLabel;
            System.Windows.Forms.Label dataLabel;
            System.Windows.Forms.Label makuhaLabel;
            System.Windows.Forms.Label otrubLabel;
            System.Windows.Forms.Label kukuruzaLabel;
            System.Windows.Forms.Label ovesLabel;
            System.Windows.Forms.Label yachminLabel;
            System.Windows.Forms.Label sinoLabel;
            System.Windows.Forms.Label solomaLabel;
            this.fermDataSetLastV = new Ferm_V2.fermDataSetLastV();
            this.kormBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kormTableAdapter = new Ferm_V2.fermDataSetLastVTableAdapters.kormTableAdapter();
            this.tableAdapterManager = new Ferm_V2.fermDataSetLastVTableAdapters.TableAdapterManager();
            this.id_kormTextBox = new System.Windows.Forms.TextBox();
            this.dataDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.makuhaTextBox = new System.Windows.Forms.TextBox();
            this.otrubTextBox = new System.Windows.Forms.TextBox();
            this.kukuruzaTextBox = new System.Windows.Forms.TextBox();
            this.ovesTextBox = new System.Windows.Forms.TextBox();
            this.yachminTextBox = new System.Windows.Forms.TextBox();
            this.sinoTextBox = new System.Windows.Forms.TextBox();
            this.solomaTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            id_kormLabel = new System.Windows.Forms.Label();
            dataLabel = new System.Windows.Forms.Label();
            makuhaLabel = new System.Windows.Forms.Label();
            otrubLabel = new System.Windows.Forms.Label();
            kukuruzaLabel = new System.Windows.Forms.Label();
            ovesLabel = new System.Windows.Forms.Label();
            yachminLabel = new System.Windows.Forms.Label();
            sinoLabel = new System.Windows.Forms.Label();
            solomaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fermDataSetLastV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kormBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // id_kormLabel
            // 
            id_kormLabel.AutoSize = true;
            id_kormLabel.Location = new System.Drawing.Point(11, 35);
            id_kormLabel.Name = "id_kormLabel";
            id_kormLabel.Size = new System.Drawing.Size(44, 13);
            id_kormLabel.TabIndex = 1;
            id_kormLabel.Text = "id korm:";
            // 
            // dataLabel
            // 
            dataLabel.AutoSize = true;
            dataLabel.Location = new System.Drawing.Point(11, 62);
            dataLabel.Name = "dataLabel";
            dataLabel.Size = new System.Drawing.Size(31, 13);
            dataLabel.TabIndex = 3;
            dataLabel.Text = "data:";
            // 
            // makuhaLabel
            // 
            makuhaLabel.AutoSize = true;
            makuhaLabel.Location = new System.Drawing.Point(11, 87);
            makuhaLabel.Name = "makuhaLabel";
            makuhaLabel.Size = new System.Drawing.Size(48, 13);
            makuhaLabel.TabIndex = 5;
            makuhaLabel.Text = "makuha:";
            // 
            // otrubLabel
            // 
            otrubLabel.AutoSize = true;
            otrubLabel.Location = new System.Drawing.Point(11, 113);
            otrubLabel.Name = "otrubLabel";
            otrubLabel.Size = new System.Drawing.Size(34, 13);
            otrubLabel.TabIndex = 7;
            otrubLabel.Text = "otrub:";
            // 
            // kukuruzaLabel
            // 
            kukuruzaLabel.AutoSize = true;
            kukuruzaLabel.Location = new System.Drawing.Point(11, 139);
            kukuruzaLabel.Name = "kukuruzaLabel";
            kukuruzaLabel.Size = new System.Drawing.Size(54, 13);
            kukuruzaLabel.TabIndex = 9;
            kukuruzaLabel.Text = "kukuruza:";
            // 
            // ovesLabel
            // 
            ovesLabel.AutoSize = true;
            ovesLabel.Location = new System.Drawing.Point(11, 165);
            ovesLabel.Name = "ovesLabel";
            ovesLabel.Size = new System.Drawing.Size(33, 13);
            ovesLabel.TabIndex = 11;
            ovesLabel.Text = "oves:";
            // 
            // yachminLabel
            // 
            yachminLabel.AutoSize = true;
            yachminLabel.Location = new System.Drawing.Point(11, 191);
            yachminLabel.Name = "yachminLabel";
            yachminLabel.Size = new System.Drawing.Size(49, 13);
            yachminLabel.TabIndex = 13;
            yachminLabel.Text = "yachmin:";
            // 
            // sinoLabel
            // 
            sinoLabel.AutoSize = true;
            sinoLabel.Location = new System.Drawing.Point(11, 217);
            sinoLabel.Name = "sinoLabel";
            sinoLabel.Size = new System.Drawing.Size(29, 13);
            sinoLabel.TabIndex = 15;
            sinoLabel.Text = "sino:";
            // 
            // solomaLabel
            // 
            solomaLabel.AutoSize = true;
            solomaLabel.Location = new System.Drawing.Point(11, 243);
            solomaLabel.Name = "solomaLabel";
            solomaLabel.Size = new System.Drawing.Size(43, 13);
            solomaLabel.TabIndex = 17;
            solomaLabel.Text = "soloma:";
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.cowTableAdapter = null;
            this.tableAdapterManager.kormTableAdapter = this.kormTableAdapter;
            this.tableAdapterManager.loginTableAdapter = null;
            this.tableAdapterManager.mesto_corTableAdapter = null;
            this.tableAdapterManager.milkTableAdapter = null;
            this.tableAdapterManager.personalTableAdapter = null;
            this.tableAdapterManager.tabelTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Ferm_V2.fermDataSetLastVTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.zarplataTableAdapter = null;
            // 
            // id_kormTextBox
            // 
            this.id_kormTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kormBindingSource, "id_korm", true));
            this.id_kormTextBox.Location = new System.Drawing.Point(71, 32);
            this.id_kormTextBox.Name = "id_kormTextBox";
            this.id_kormTextBox.Size = new System.Drawing.Size(200, 20);
            this.id_kormTextBox.TabIndex = 2;
            // 
            // dataDateTimePicker
            // 
            this.dataDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.kormBindingSource, "data", true));
            this.dataDateTimePicker.Location = new System.Drawing.Point(71, 58);
            this.dataDateTimePicker.Name = "dataDateTimePicker";
            this.dataDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dataDateTimePicker.TabIndex = 4;
            // 
            // makuhaTextBox
            // 
            this.makuhaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kormBindingSource, "makuha", true));
            this.makuhaTextBox.Location = new System.Drawing.Point(71, 84);
            this.makuhaTextBox.Name = "makuhaTextBox";
            this.makuhaTextBox.Size = new System.Drawing.Size(200, 20);
            this.makuhaTextBox.TabIndex = 6;
            // 
            // otrubTextBox
            // 
            this.otrubTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kormBindingSource, "otrub", true));
            this.otrubTextBox.Location = new System.Drawing.Point(71, 110);
            this.otrubTextBox.Name = "otrubTextBox";
            this.otrubTextBox.Size = new System.Drawing.Size(200, 20);
            this.otrubTextBox.TabIndex = 8;
            // 
            // kukuruzaTextBox
            // 
            this.kukuruzaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kormBindingSource, "kukuruza", true));
            this.kukuruzaTextBox.Location = new System.Drawing.Point(71, 136);
            this.kukuruzaTextBox.Name = "kukuruzaTextBox";
            this.kukuruzaTextBox.Size = new System.Drawing.Size(200, 20);
            this.kukuruzaTextBox.TabIndex = 10;
            // 
            // ovesTextBox
            // 
            this.ovesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kormBindingSource, "oves", true));
            this.ovesTextBox.Location = new System.Drawing.Point(71, 162);
            this.ovesTextBox.Name = "ovesTextBox";
            this.ovesTextBox.Size = new System.Drawing.Size(200, 20);
            this.ovesTextBox.TabIndex = 12;
            // 
            // yachminTextBox
            // 
            this.yachminTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kormBindingSource, "yachmin", true));
            this.yachminTextBox.Location = new System.Drawing.Point(71, 188);
            this.yachminTextBox.Name = "yachminTextBox";
            this.yachminTextBox.Size = new System.Drawing.Size(200, 20);
            this.yachminTextBox.TabIndex = 14;
            // 
            // sinoTextBox
            // 
            this.sinoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kormBindingSource, "sino", true));
            this.sinoTextBox.Location = new System.Drawing.Point(71, 214);
            this.sinoTextBox.Name = "sinoTextBox";
            this.sinoTextBox.Size = new System.Drawing.Size(200, 20);
            this.sinoTextBox.TabIndex = 16;
            // 
            // solomaTextBox
            // 
            this.solomaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kormBindingSource, "soloma", true));
            this.solomaTextBox.Location = new System.Drawing.Point(71, 240);
            this.solomaTextBox.Name = "solomaTextBox";
            this.solomaTextBox.Size = new System.Drawing.Size(200, 20);
            this.solomaTextBox.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 290);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(154, 290);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Dob_Korm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 343);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(id_kormLabel);
            this.Controls.Add(this.id_kormTextBox);
            this.Controls.Add(dataLabel);
            this.Controls.Add(this.dataDateTimePicker);
            this.Controls.Add(makuhaLabel);
            this.Controls.Add(this.makuhaTextBox);
            this.Controls.Add(otrubLabel);
            this.Controls.Add(this.otrubTextBox);
            this.Controls.Add(kukuruzaLabel);
            this.Controls.Add(this.kukuruzaTextBox);
            this.Controls.Add(ovesLabel);
            this.Controls.Add(this.ovesTextBox);
            this.Controls.Add(yachminLabel);
            this.Controls.Add(this.yachminTextBox);
            this.Controls.Add(sinoLabel);
            this.Controls.Add(this.sinoTextBox);
            this.Controls.Add(solomaLabel);
            this.Controls.Add(this.solomaTextBox);
            this.Name = "Dob_Korm";
            this.Text = "Dob_Korm";
            this.Load += new System.EventHandler(this.Dob_Korm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fermDataSetLastV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kormBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private fermDataSetLastV fermDataSetLastV;
        private System.Windows.Forms.BindingSource kormBindingSource;
        private fermDataSetLastVTableAdapters.kormTableAdapter kormTableAdapter;
        private fermDataSetLastVTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox id_kormTextBox;
        private System.Windows.Forms.DateTimePicker dataDateTimePicker;
        private System.Windows.Forms.TextBox makuhaTextBox;
        private System.Windows.Forms.TextBox otrubTextBox;
        private System.Windows.Forms.TextBox kukuruzaTextBox;
        private System.Windows.Forms.TextBox ovesTextBox;
        private System.Windows.Forms.TextBox yachminTextBox;
        private System.Windows.Forms.TextBox sinoTextBox;
        private System.Windows.Forms.TextBox solomaTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}