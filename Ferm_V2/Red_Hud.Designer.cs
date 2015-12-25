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
            System.Windows.Forms.Label id_cowLabel1;
            System.Windows.Forms.Label klichkaLabel1;
            System.Windows.Forms.Label polLabel1;
            System.Windows.Forms.Label data_birthdayLabel1;
            System.Windows.Forms.Label kodLabel1;
            System.Windows.Forms.Label inwert_numberLabel1;
            System.Windows.Forms.Label id_doyarkaLabel1;
            System.Windows.Forms.Label id_mestoLabel1;
            System.Windows.Forms.Label privivkaLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Red_Hud));
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fermDataSetEasy = new Ferm_V2.fermDataSetEasy();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cowTableAdapter1 = new Ferm_V2.fermDataSetEasyTableAdapters.cowTableAdapter();
            this.tableAdapterManager1 = new Ferm_V2.fermDataSetEasyTableAdapters.TableAdapterManager();
            this.cowBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.id_cowTextBox1 = new System.Windows.Forms.TextBox();
            this.klichkaTextBox1 = new System.Windows.Forms.TextBox();
            this.polTextBox1 = new System.Windows.Forms.TextBox();
            this.kodTextBox1 = new System.Windows.Forms.TextBox();
            this.inwert_numberTextBox1 = new System.Windows.Forms.TextBox();
            this.id_doyarkaTextBox1 = new System.Windows.Forms.TextBox();
            this.id_mestoTextBox1 = new System.Windows.Forms.TextBox();
            this.privivkaTextBox1 = new System.Windows.Forms.TextBox();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            id_cowLabel1 = new System.Windows.Forms.Label();
            klichkaLabel1 = new System.Windows.Forms.Label();
            polLabel1 = new System.Windows.Forms.Label();
            data_birthdayLabel1 = new System.Windows.Forms.Label();
            kodLabel1 = new System.Windows.Forms.Label();
            inwert_numberLabel1 = new System.Windows.Forms.Label();
            id_doyarkaLabel1 = new System.Windows.Forms.Label();
            id_mestoLabel1 = new System.Windows.Forms.Label();
            privivkaLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fermDataSetEasy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cowBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.fermDataSetEasy;
            this.bindingSource1.Position = 0;
            // 
            // fermDataSetEasy
            // 
            this.fermDataSetEasy.DataSetName = "fermDataSetEasy";
            this.fermDataSetEasy.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(199, 288);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // cowTableAdapter1
            // 
            this.cowTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.cowTableAdapter = this.cowTableAdapter1;
            this.tableAdapterManager1.kormTableAdapter = null;
            this.tableAdapterManager1.loginTableAdapter = null;
            this.tableAdapterManager1.mesto_corTableAdapter = null;
            this.tableAdapterManager1.milkTableAdapter = null;
            this.tableAdapterManager1.personalTableAdapter = null;
            this.tableAdapterManager1.polTableAdapter = null;
            this.tableAdapterManager1.tabelTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = Ferm_V2.fermDataSetEasyTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.zarplataTableAdapter = null;
            // 
            // cowBindingSource2
            // 
            this.cowBindingSource2.DataMember = "cow";
            this.cowBindingSource2.DataSource = this.fermDataSetEasy;
            // 
            // id_cowLabel1
            // 
            id_cowLabel1.AutoSize = true;
            id_cowLabel1.Location = new System.Drawing.Point(20, 57);
            id_cowLabel1.Name = "id_cowLabel1";
            id_cowLabel1.Size = new System.Drawing.Size(41, 13);
            id_cowLabel1.TabIndex = 21;
            id_cowLabel1.Text = "id cow:";
            // 
            // id_cowTextBox1
            // 
            this.id_cowTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cowBindingSource2, "id_cow", true));
            this.id_cowTextBox1.Location = new System.Drawing.Point(102, 54);
            this.id_cowTextBox1.Name = "id_cowTextBox1";
            this.id_cowTextBox1.Size = new System.Drawing.Size(200, 20);
            this.id_cowTextBox1.TabIndex = 22;
            // 
            // klichkaLabel1
            // 
            klichkaLabel1.AutoSize = true;
            klichkaLabel1.Location = new System.Drawing.Point(20, 83);
            klichkaLabel1.Name = "klichkaLabel1";
            klichkaLabel1.Size = new System.Drawing.Size(44, 13);
            klichkaLabel1.TabIndex = 23;
            klichkaLabel1.Text = "klichka:";
            // 
            // klichkaTextBox1
            // 
            this.klichkaTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cowBindingSource2, "klichka", true));
            this.klichkaTextBox1.Location = new System.Drawing.Point(102, 80);
            this.klichkaTextBox1.Name = "klichkaTextBox1";
            this.klichkaTextBox1.Size = new System.Drawing.Size(200, 20);
            this.klichkaTextBox1.TabIndex = 24;
            // 
            // polLabel1
            // 
            polLabel1.AutoSize = true;
            polLabel1.Location = new System.Drawing.Point(20, 109);
            polLabel1.Name = "polLabel1";
            polLabel1.Size = new System.Drawing.Size(24, 13);
            polLabel1.TabIndex = 25;
            polLabel1.Text = "pol:";
            // 
            // polTextBox1
            // 
            this.polTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cowBindingSource2, "pol", true));
            this.polTextBox1.Location = new System.Drawing.Point(102, 106);
            this.polTextBox1.Name = "polTextBox1";
            this.polTextBox1.Size = new System.Drawing.Size(200, 20);
            this.polTextBox1.TabIndex = 26;
            // 
            // data_birthdayLabel1
            // 
            data_birthdayLabel1.AutoSize = true;
            data_birthdayLabel1.Location = new System.Drawing.Point(20, 135);
            data_birthdayLabel1.Name = "data_birthdayLabel1";
            data_birthdayLabel1.Size = new System.Drawing.Size(71, 13);
            data_birthdayLabel1.TabIndex = 27;
            data_birthdayLabel1.Text = "data birthday:";
            // 
            // kodLabel1
            // 
            kodLabel1.AutoSize = true;
            kodLabel1.Location = new System.Drawing.Point(20, 161);
            kodLabel1.Name = "kodLabel1";
            kodLabel1.Size = new System.Drawing.Size(28, 13);
            kodLabel1.TabIndex = 29;
            kodLabel1.Text = "kod:";
            // 
            // kodTextBox1
            // 
            this.kodTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cowBindingSource2, "kod", true));
            this.kodTextBox1.Location = new System.Drawing.Point(102, 158);
            this.kodTextBox1.Name = "kodTextBox1";
            this.kodTextBox1.Size = new System.Drawing.Size(200, 20);
            this.kodTextBox1.TabIndex = 30;
            // 
            // inwert_numberLabel1
            // 
            inwert_numberLabel1.AutoSize = true;
            inwert_numberLabel1.Location = new System.Drawing.Point(20, 187);
            inwert_numberLabel1.Name = "inwert_numberLabel1";
            inwert_numberLabel1.Size = new System.Drawing.Size(76, 13);
            inwert_numberLabel1.TabIndex = 31;
            inwert_numberLabel1.Text = "inwert number:";
            // 
            // inwert_numberTextBox1
            // 
            this.inwert_numberTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cowBindingSource2, "inwert_number", true));
            this.inwert_numberTextBox1.Location = new System.Drawing.Point(102, 184);
            this.inwert_numberTextBox1.Name = "inwert_numberTextBox1";
            this.inwert_numberTextBox1.Size = new System.Drawing.Size(200, 20);
            this.inwert_numberTextBox1.TabIndex = 32;
            // 
            // id_doyarkaLabel1
            // 
            id_doyarkaLabel1.AutoSize = true;
            id_doyarkaLabel1.Location = new System.Drawing.Point(20, 213);
            id_doyarkaLabel1.Name = "id_doyarkaLabel1";
            id_doyarkaLabel1.Size = new System.Drawing.Size(59, 13);
            id_doyarkaLabel1.TabIndex = 33;
            id_doyarkaLabel1.Text = "id doyarka:";
            // 
            // id_doyarkaTextBox1
            // 
            this.id_doyarkaTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cowBindingSource2, "id_doyarka", true));
            this.id_doyarkaTextBox1.Location = new System.Drawing.Point(102, 210);
            this.id_doyarkaTextBox1.Name = "id_doyarkaTextBox1";
            this.id_doyarkaTextBox1.Size = new System.Drawing.Size(200, 20);
            this.id_doyarkaTextBox1.TabIndex = 34;
            // 
            // id_mestoLabel1
            // 
            id_mestoLabel1.AutoSize = true;
            id_mestoLabel1.Location = new System.Drawing.Point(20, 239);
            id_mestoLabel1.Name = "id_mestoLabel1";
            id_mestoLabel1.Size = new System.Drawing.Size(49, 13);
            id_mestoLabel1.TabIndex = 35;
            id_mestoLabel1.Text = "id mesto:";
            // 
            // id_mestoTextBox1
            // 
            this.id_mestoTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cowBindingSource2, "id_mesto", true));
            this.id_mestoTextBox1.Location = new System.Drawing.Point(102, 236);
            this.id_mestoTextBox1.Name = "id_mestoTextBox1";
            this.id_mestoTextBox1.Size = new System.Drawing.Size(200, 20);
            this.id_mestoTextBox1.TabIndex = 36;
            // 
            // privivkaLabel1
            // 
            privivkaLabel1.AutoSize = true;
            privivkaLabel1.Location = new System.Drawing.Point(20, 265);
            privivkaLabel1.Name = "privivkaLabel1";
            privivkaLabel1.Size = new System.Drawing.Size(47, 13);
            privivkaLabel1.TabIndex = 37;
            privivkaLabel1.Text = "privivka:";
            // 
            // privivkaTextBox1
            // 
            this.privivkaTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cowBindingSource2, "privivka", true));
            this.privivkaTextBox1.Location = new System.Drawing.Point(102, 262);
            this.privivkaTextBox1.Name = "privivkaTextBox1";
            this.privivkaTextBox1.Size = new System.Drawing.Size(200, 20);
            this.privivkaTextBox1.TabIndex = 38;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.cowBindingSource2;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(747, 25);
            this.bindingNavigator1.TabIndex = 39;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(102, 132);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 40;
            // 
            // Red_Hud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 366);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(id_cowLabel1);
            this.Controls.Add(this.id_cowTextBox1);
            this.Controls.Add(klichkaLabel1);
            this.Controls.Add(this.klichkaTextBox1);
            this.Controls.Add(polLabel1);
            this.Controls.Add(this.polTextBox1);
            this.Controls.Add(data_birthdayLabel1);
            this.Controls.Add(kodLabel1);
            this.Controls.Add(this.kodTextBox1);
            this.Controls.Add(inwert_numberLabel1);
            this.Controls.Add(this.inwert_numberTextBox1);
            this.Controls.Add(id_doyarkaLabel1);
            this.Controls.Add(this.id_doyarkaTextBox1);
            this.Controls.Add(id_mestoLabel1);
            this.Controls.Add(this.id_mestoTextBox1);
            this.Controls.Add(privivkaLabel1);
            this.Controls.Add(this.privivkaTextBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Red_Hud";
            this.Text = "Red_Hud";
            this.Load += new System.EventHandler(this.Red_Hud_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fermDataSetEasy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cowBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private fermDataSetEasy fermDataSetEasy;
        private fermDataSetEasyTableAdapters.cowTableAdapter cowTableAdapter1;
        private fermDataSetEasyTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.BindingSource cowBindingSource2;
        private System.Windows.Forms.TextBox id_cowTextBox1;
        private System.Windows.Forms.TextBox klichkaTextBox1;
        private System.Windows.Forms.TextBox polTextBox1;
        private System.Windows.Forms.TextBox kodTextBox1;
        private System.Windows.Forms.TextBox inwert_numberTextBox1;
        private System.Windows.Forms.TextBox id_doyarkaTextBox1;
        private System.Windows.Forms.TextBox id_mestoTextBox1;
        private System.Windows.Forms.TextBox privivkaTextBox1;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}