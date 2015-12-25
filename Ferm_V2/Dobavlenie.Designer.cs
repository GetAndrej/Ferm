namespace Ferm_V2
{
    partial class Dobavlenie
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.id_cow = new System.Windows.Forms.TextBox();
            this.klichka = new System.Windows.Forms.TextBox();
            this.pol = new System.Windows.Forms.ComboBox();
            this.data_birthday = new System.Windows.Forms.DateTimePicker();
            this.kod = new System.Windows.Forms.TextBox();
            this.inwert_number = new System.Windows.Forms.TextBox();
            this.id_doyarka = new System.Windows.Forms.ComboBox();
            this.privivka = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.id_mesto = new System.Windows.Forms.ComboBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fermDataSetLastV = new Ferm_V2.fermDataSetLastV();
            this.cowTableAdapter1 = new Ferm_V2.fermDataSetLastVTableAdapters.cowTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fermDataSetLastV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Кличка:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Пол:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ростел:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Код:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Инвент. Номер";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Доярка";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 228);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Прививка";
            // 
            // id_cow
            // 
            this.id_cow.Location = new System.Drawing.Point(127, 17);
            this.id_cow.Name = "id_cow";
            this.id_cow.Size = new System.Drawing.Size(200, 20);
            this.id_cow.TabIndex = 8;
            // 
            // klichka
            // 
            this.klichka.Location = new System.Drawing.Point(127, 43);
            this.klichka.Name = "klichka";
            this.klichka.Size = new System.Drawing.Size(200, 20);
            this.klichka.TabIndex = 9;
            // 
            // pol
            // 
            this.pol.AutoCompleteCustomSource.AddRange(new string[] {
            "Корова",
            "Бык"});
            this.pol.FormattingEnabled = true;
            this.pol.Location = new System.Drawing.Point(127, 69);
            this.pol.Name = "pol";
            this.pol.Size = new System.Drawing.Size(200, 21);
            this.pol.TabIndex = 10;
            // 
            // data_birthday
            // 
            this.data_birthday.Location = new System.Drawing.Point(127, 96);
            this.data_birthday.Name = "data_birthday";
            this.data_birthday.Size = new System.Drawing.Size(200, 20);
            this.data_birthday.TabIndex = 11;
            // 
            // kod
            // 
            this.kod.Location = new System.Drawing.Point(127, 122);
            this.kod.Name = "kod";
            this.kod.Size = new System.Drawing.Size(200, 20);
            this.kod.TabIndex = 12;
            // 
            // inwert_number
            // 
            this.inwert_number.Location = new System.Drawing.Point(127, 148);
            this.inwert_number.Name = "inwert_number";
            this.inwert_number.Size = new System.Drawing.Size(200, 20);
            this.inwert_number.TabIndex = 13;
            // 
            // id_doyarka
            // 
            this.id_doyarka.DisplayMember = "id";
            this.id_doyarka.FormattingEnabled = true;
            this.id_doyarka.Location = new System.Drawing.Point(127, 174);
            this.id_doyarka.Name = "id_doyarka";
            this.id_doyarka.Size = new System.Drawing.Size(200, 21);
            this.id_doyarka.TabIndex = 14;
            this.id_doyarka.ValueMember = "id";
            // 
            // privivka
            // 
            this.privivka.Location = new System.Drawing.Point(127, 228);
            this.privivka.Name = "privivka";
            this.privivka.Size = new System.Drawing.Size(200, 20);
            this.privivka.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(186, 254);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Закрыть";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 201);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Место";
            // 
            // id_mesto
            // 
            this.id_mesto.DisplayMember = "id_mest";
            this.id_mesto.FormattingEnabled = true;
            this.id_mesto.Location = new System.Drawing.Point(127, 201);
            this.id_mesto.Name = "id_mesto";
            this.id_mesto.Size = new System.Drawing.Size(200, 21);
            this.id_mesto.TabIndex = 15;
            this.id_mesto.ValueMember = "id_mest";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.fermDataSetLastV;
            this.bindingSource1.Position = 0;
            // 
            // fermDataSetLastV
            // 
            this.fermDataSetLastV.DataSetName = "fermDataSetLastV";
            this.fermDataSetLastV.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cowTableAdapter1
            // 
            this.cowTableAdapter1.ClearBeforeFill = true;
            // 
            // Dobavlenie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 296);
            this.Controls.Add(this.id_mesto);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.privivka);
            this.Controls.Add(this.id_doyarka);
            this.Controls.Add(this.inwert_number);
            this.Controls.Add(this.kod);
            this.Controls.Add(this.data_birthday);
            this.Controls.Add(this.pol);
            this.Controls.Add(this.klichka);
            this.Controls.Add(this.id_cow);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Dobavlenie";
            this.Text = "Dobavlenie";
            this.Load += new System.EventHandler(this.Dobavlenie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fermDataSetLastV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox id_cow;
        private System.Windows.Forms.TextBox klichka;
        private System.Windows.Forms.ComboBox pol;
        private System.Windows.Forms.DateTimePicker data_birthday;
        private System.Windows.Forms.TextBox kod;
        private System.Windows.Forms.TextBox inwert_number;
        private System.Windows.Forms.ComboBox id_doyarka;
        private System.Windows.Forms.TextBox privivka;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox id_mesto;
        private System.Windows.Forms.BindingSource bindingSource1;
        private fermDataSetLastV fermDataSetLastV;
        private fermDataSetLastVTableAdapters.cowTableAdapter cowTableAdapter1;
    }
}