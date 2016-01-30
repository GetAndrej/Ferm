namespace Ferm_V2
{
    partial class Red_Hud
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
            System.Windows.Forms.Label privivkaLabel;
            System.Windows.Forms.Label id_mestoLabel;
            System.Windows.Forms.Label id_doyarkaLabel;
            System.Windows.Forms.Label inwert_numberLabel;
            System.Windows.Forms.Label kodLabel;
            System.Windows.Forms.Label data_birthdayLabel;
            System.Windows.Forms.Label polLabel;
            System.Windows.Forms.Label klichkaLabel;
            System.Windows.Forms.Label id_cowLabel;
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.privivkaTextBox = new System.Windows.Forms.TextBox();
            this.id_mestoTextBox = new System.Windows.Forms.TextBox();
            this.id_doyarkaTextBox = new System.Windows.Forms.TextBox();
            this.inwert_numberTextBox = new System.Windows.Forms.TextBox();
            this.kodTextBox = new System.Windows.Forms.TextBox();
            this.polTextBox = new System.Windows.Forms.TextBox();
            this.klichkaTextBox = new System.Windows.Forms.TextBox();
            this.id_cowTextBox = new System.Windows.Forms.TextBox();
            this.cowBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fermDataSetLastV = new Ferm_V2.fermDataSetLastV();
            this.cowTableAdapter = new Ferm_V2.fermDataSetLastVTableAdapters.cowTableAdapter();
            this.tableAdapterManager = new Ferm_V2.fermDataSetLastVTableAdapters.TableAdapterManager();
            this.data_birthdayDateTimePicker = new System.Windows.Forms.MonthCalendar();
            privivkaLabel = new System.Windows.Forms.Label();
            id_mestoLabel = new System.Windows.Forms.Label();
            id_doyarkaLabel = new System.Windows.Forms.Label();
            inwert_numberLabel = new System.Windows.Forms.Label();
            kodLabel = new System.Windows.Forms.Label();
            data_birthdayLabel = new System.Windows.Forms.Label();
            polLabel = new System.Windows.Forms.Label();
            klichkaLabel = new System.Windows.Forms.Label();
            id_cowLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cowBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fermDataSetLastV)).BeginInit();
            this.SuspendLayout();
            // 
            // privivkaLabel
            // 
            privivkaLabel.AutoSize = true;
            privivkaLabel.Location = new System.Drawing.Point(22, 203);
            privivkaLabel.Name = "privivkaLabel";
            privivkaLabel.Size = new System.Drawing.Size(47, 13);
            privivkaLabel.TabIndex = 56;
            privivkaLabel.Text = "privivka:";
            // 
            // id_mestoLabel
            // 
            id_mestoLabel.AutoSize = true;
            id_mestoLabel.Location = new System.Drawing.Point(22, 177);
            id_mestoLabel.Name = "id_mestoLabel";
            id_mestoLabel.Size = new System.Drawing.Size(49, 13);
            id_mestoLabel.TabIndex = 54;
            id_mestoLabel.Text = "id mesto:";
            // 
            // id_doyarkaLabel
            // 
            id_doyarkaLabel.AutoSize = true;
            id_doyarkaLabel.Location = new System.Drawing.Point(22, 151);
            id_doyarkaLabel.Name = "id_doyarkaLabel";
            id_doyarkaLabel.Size = new System.Drawing.Size(59, 13);
            id_doyarkaLabel.TabIndex = 52;
            id_doyarkaLabel.Text = "id doyarka:";
            // 
            // inwert_numberLabel
            // 
            inwert_numberLabel.AutoSize = true;
            inwert_numberLabel.Location = new System.Drawing.Point(22, 125);
            inwert_numberLabel.Name = "inwert_numberLabel";
            inwert_numberLabel.Size = new System.Drawing.Size(76, 13);
            inwert_numberLabel.TabIndex = 50;
            inwert_numberLabel.Text = "inwert number:";
            // 
            // kodLabel
            // 
            kodLabel.AutoSize = true;
            kodLabel.Location = new System.Drawing.Point(22, 99);
            kodLabel.Name = "kodLabel";
            kodLabel.Size = new System.Drawing.Size(28, 13);
            kodLabel.TabIndex = 48;
            kodLabel.Text = "kod:";
            // 
            // data_birthdayLabel
            // 
            data_birthdayLabel.AutoSize = true;
            data_birthdayLabel.Location = new System.Drawing.Point(322, 10);
            data_birthdayLabel.Name = "data_birthdayLabel";
            data_birthdayLabel.Size = new System.Drawing.Size(71, 13);
            data_birthdayLabel.TabIndex = 46;
            data_birthdayLabel.Text = "data birthday:";
            // 
            // polLabel
            // 
            polLabel.AutoSize = true;
            polLabel.Location = new System.Drawing.Point(22, 71);
            polLabel.Name = "polLabel";
            polLabel.Size = new System.Drawing.Size(24, 13);
            polLabel.TabIndex = 44;
            polLabel.Text = "pol:";
            // 
            // klichkaLabel
            // 
            klichkaLabel.AutoSize = true;
            klichkaLabel.Location = new System.Drawing.Point(22, 45);
            klichkaLabel.Name = "klichkaLabel";
            klichkaLabel.Size = new System.Drawing.Size(44, 13);
            klichkaLabel.TabIndex = 42;
            klichkaLabel.Text = "klichka:";
            // 
            // id_cowLabel
            // 
            id_cowLabel.AutoSize = true;
            id_cowLabel.Location = new System.Drawing.Point(22, 19);
            id_cowLabel.Name = "id_cowLabel";
            id_cowLabel.Size = new System.Drawing.Size(41, 13);
            id_cowLabel.TabIndex = 40;
            id_cowLabel.Text = "id cow:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 38;
            this.button1.Text = "Редактировать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(184, 269);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 23);
            this.button2.TabIndex = 39;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // privivkaTextBox
            // 
            this.privivkaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cowBindingSource, "privivka", true));
            this.privivkaTextBox.Location = new System.Drawing.Point(104, 200);
            this.privivkaTextBox.Name = "privivkaTextBox";
            this.privivkaTextBox.Size = new System.Drawing.Size(200, 20);
            this.privivkaTextBox.TabIndex = 57;
            // 
            // id_mestoTextBox
            // 
            this.id_mestoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cowBindingSource, "id_mesto", true));
            this.id_mestoTextBox.Location = new System.Drawing.Point(104, 174);
            this.id_mestoTextBox.Name = "id_mestoTextBox";
            this.id_mestoTextBox.Size = new System.Drawing.Size(200, 20);
            this.id_mestoTextBox.TabIndex = 55;
            // 
            // id_doyarkaTextBox
            // 
            this.id_doyarkaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cowBindingSource, "id_doyarka", true));
            this.id_doyarkaTextBox.Location = new System.Drawing.Point(104, 148);
            this.id_doyarkaTextBox.Name = "id_doyarkaTextBox";
            this.id_doyarkaTextBox.Size = new System.Drawing.Size(200, 20);
            this.id_doyarkaTextBox.TabIndex = 53;
            // 
            // inwert_numberTextBox
            // 
            this.inwert_numberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cowBindingSource, "inwert_number", true));
            this.inwert_numberTextBox.Location = new System.Drawing.Point(104, 122);
            this.inwert_numberTextBox.Name = "inwert_numberTextBox";
            this.inwert_numberTextBox.Size = new System.Drawing.Size(200, 20);
            this.inwert_numberTextBox.TabIndex = 51;
            // 
            // kodTextBox
            // 
            this.kodTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cowBindingSource, "kod", true));
            this.kodTextBox.Location = new System.Drawing.Point(104, 96);
            this.kodTextBox.Name = "kodTextBox";
            this.kodTextBox.Size = new System.Drawing.Size(200, 20);
            this.kodTextBox.TabIndex = 49;
            // 
            // polTextBox
            // 
            this.polTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cowBindingSource, "pol", true));
            this.polTextBox.Location = new System.Drawing.Point(104, 68);
            this.polTextBox.Name = "polTextBox";
            this.polTextBox.Size = new System.Drawing.Size(200, 20);
            this.polTextBox.TabIndex = 45;
            // 
            // klichkaTextBox
            // 
            this.klichkaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cowBindingSource, "klichka", true));
            this.klichkaTextBox.Location = new System.Drawing.Point(104, 42);
            this.klichkaTextBox.Name = "klichkaTextBox";
            this.klichkaTextBox.Size = new System.Drawing.Size(200, 20);
            this.klichkaTextBox.TabIndex = 43;
            // 
            // id_cowTextBox
            // 
            this.id_cowTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cowBindingSource, "id_cow", true));
            this.id_cowTextBox.Location = new System.Drawing.Point(104, 16);
            this.id_cowTextBox.Name = "id_cowTextBox";
            this.id_cowTextBox.Size = new System.Drawing.Size(200, 20);
            this.id_cowTextBox.TabIndex = 41;
            // 
            // cowBindingSource
            // 
            this.cowBindingSource.DataMember = "cow";
            this.cowBindingSource.DataSource = this.fermDataSetLastV;
            // 
            // fermDataSetLastV
            // 
            this.fermDataSetLastV.DataSetName = "fermDataSetLastV";
            this.fermDataSetLastV.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cowTableAdapter
            // 
            this.cowTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.cowTableAdapter = null;
            this.tableAdapterManager.kormTableAdapter = null;
            this.tableAdapterManager.loginTableAdapter = null;
            this.tableAdapterManager.mesto_corTableAdapter = null;
            this.tableAdapterManager.milkTableAdapter = null;
            this.tableAdapterManager.personalTableAdapter = null;
            this.tableAdapterManager.tabelTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Ferm_V2.fermDataSetLastVTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.zarplataTableAdapter = null;
            // 
            // data_birthdayDateTimePicker
            // 
            this.data_birthdayDateTimePicker.Location = new System.Drawing.Point(325, 32);
            this.data_birthdayDateTimePicker.Name = "data_birthdayDateTimePicker";
            this.data_birthdayDateTimePicker.TabIndex = 58;
            // 
            // Red_Hud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 303);
            this.Controls.Add(this.data_birthdayDateTimePicker);
            this.Controls.Add(id_cowLabel);
            this.Controls.Add(this.id_cowTextBox);
            this.Controls.Add(klichkaLabel);
            this.Controls.Add(this.klichkaTextBox);
            this.Controls.Add(polLabel);
            this.Controls.Add(this.polTextBox);
            this.Controls.Add(data_birthdayLabel);
            this.Controls.Add(kodLabel);
            this.Controls.Add(this.kodTextBox);
            this.Controls.Add(inwert_numberLabel);
            this.Controls.Add(this.inwert_numberTextBox);
            this.Controls.Add(id_doyarkaLabel);
            this.Controls.Add(this.id_doyarkaTextBox);
            this.Controls.Add(id_mestoLabel);
            this.Controls.Add(this.id_mestoTextBox);
            this.Controls.Add(privivkaLabel);
            this.Controls.Add(this.privivkaTextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Red_Hud";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Red_Hud";
            this.Load += new System.EventHandler(this.Red_Hud_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cowBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fermDataSetLastV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private fermDataSetLastV fermDataSetLastV;
        private System.Windows.Forms.BindingSource cowBindingSource;
        private fermDataSetLastVTableAdapters.cowTableAdapter cowTableAdapter;
        private fermDataSetLastVTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox privivkaTextBox;
        private System.Windows.Forms.TextBox id_mestoTextBox;
        private System.Windows.Forms.TextBox id_doyarkaTextBox;
        private System.Windows.Forms.TextBox inwert_numberTextBox;
        private System.Windows.Forms.TextBox kodTextBox;
        private System.Windows.Forms.TextBox polTextBox;
        private System.Windows.Forms.TextBox klichkaTextBox;
        private System.Windows.Forms.TextBox id_cowTextBox;
        private System.Windows.Forms.MonthCalendar data_birthdayDateTimePicker;
    }
}