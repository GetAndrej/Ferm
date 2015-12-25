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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Red_Hud));
            System.Windows.Forms.Label id_cowLabel;
            System.Windows.Forms.Label klichkaLabel;
            System.Windows.Forms.Label polLabel;
            System.Windows.Forms.Label data_birthdayLabel;
            System.Windows.Forms.Label kodLabel;
            System.Windows.Forms.Label inwert_numberLabel;
            System.Windows.Forms.Label id_doyarkaLabel;
            System.Windows.Forms.Label id_mestoLabel;
            System.Windows.Forms.Label privivkaLabel;
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.fermDataSetLastV = new Ferm_V2.fermDataSetLastV();
            this.cowBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cowTableAdapter = new Ferm_V2.fermDataSetLastVTableAdapters.cowTableAdapter();
            this.tableAdapterManager = new Ferm_V2.fermDataSetLastVTableAdapters.TableAdapterManager();
            this.cowBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.cowBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_cowTextBox = new System.Windows.Forms.TextBox();
            this.klichkaTextBox = new System.Windows.Forms.TextBox();
            this.polTextBox = new System.Windows.Forms.TextBox();
            this.data_birthdayDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.kodTextBox = new System.Windows.Forms.TextBox();
            this.inwert_numberTextBox = new System.Windows.Forms.TextBox();
            this.id_doyarkaTextBox = new System.Windows.Forms.TextBox();
            this.id_mestoTextBox = new System.Windows.Forms.TextBox();
            this.privivkaTextBox = new System.Windows.Forms.TextBox();
            id_cowLabel = new System.Windows.Forms.Label();
            klichkaLabel = new System.Windows.Forms.Label();
            polLabel = new System.Windows.Forms.Label();
            data_birthdayLabel = new System.Windows.Forms.Label();
            kodLabel = new System.Windows.Forms.Label();
            inwert_numberLabel = new System.Windows.Forms.Label();
            id_doyarkaLabel = new System.Windows.Forms.Label();
            id_mestoLabel = new System.Windows.Forms.Label();
            privivkaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fermDataSetLastV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cowBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cowBindingNavigator)).BeginInit();
            this.cowBindingNavigator.SuspendLayout();
            this.SuspendLayout();
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
            // fermDataSetLastV
            // 
            this.fermDataSetLastV.DataSetName = "fermDataSetLastV";
            this.fermDataSetLastV.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cowBindingSource
            // 
            this.cowBindingSource.DataMember = "cow";
            this.cowBindingSource.DataSource = this.fermDataSetLastV;
            // 
            // cowTableAdapter
            // 
            this.cowTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.cowTableAdapter = this.cowTableAdapter;
            this.tableAdapterManager.kormTableAdapter = null;
            this.tableAdapterManager.loginTableAdapter = null;
            this.tableAdapterManager.mesto_corTableAdapter = null;
            this.tableAdapterManager.milkTableAdapter = null;
            this.tableAdapterManager.personalTableAdapter = null;
            this.tableAdapterManager.tabelTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Ferm_V2.fermDataSetLastVTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.zarplataTableAdapter = null;
            // 
            // cowBindingNavigator
            // 
            this.cowBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cowBindingNavigator.BindingSource = this.cowBindingSource;
            this.cowBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cowBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cowBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorDeleteItem,
            this.cowBindingNavigatorSaveItem});
            this.cowBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cowBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cowBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cowBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cowBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cowBindingNavigator.Name = "cowBindingNavigator";
            this.cowBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cowBindingNavigator.Size = new System.Drawing.Size(747, 25);
            this.cowBindingNavigator.TabIndex = 20;
            this.cowBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 15);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // cowBindingNavigatorSaveItem
            // 
            this.cowBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cowBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cowBindingNavigatorSaveItem.Image")));
            this.cowBindingNavigatorSaveItem.Name = "cowBindingNavigatorSaveItem";
            this.cowBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.cowBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.cowBindingNavigatorSaveItem.Click += new System.EventHandler(this.cowBindingNavigatorSaveItem_Click_1);
            // 
            // id_cowLabel
            // 
            id_cowLabel.AutoSize = true;
            id_cowLabel.Location = new System.Drawing.Point(20, 31);
            id_cowLabel.Name = "id_cowLabel";
            id_cowLabel.Size = new System.Drawing.Size(41, 13);
            id_cowLabel.TabIndex = 20;
            id_cowLabel.Text = "id cow:";
            // 
            // id_cowTextBox
            // 
            this.id_cowTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cowBindingSource, "id_cow", true));
            this.id_cowTextBox.Location = new System.Drawing.Point(102, 28);
            this.id_cowTextBox.Name = "id_cowTextBox";
            this.id_cowTextBox.Size = new System.Drawing.Size(200, 20);
            this.id_cowTextBox.TabIndex = 21;
            // 
            // klichkaLabel
            // 
            klichkaLabel.AutoSize = true;
            klichkaLabel.Location = new System.Drawing.Point(20, 57);
            klichkaLabel.Name = "klichkaLabel";
            klichkaLabel.Size = new System.Drawing.Size(44, 13);
            klichkaLabel.TabIndex = 22;
            klichkaLabel.Text = "klichka:";
            // 
            // klichkaTextBox
            // 
            this.klichkaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cowBindingSource, "klichka", true));
            this.klichkaTextBox.Location = new System.Drawing.Point(102, 54);
            this.klichkaTextBox.Name = "klichkaTextBox";
            this.klichkaTextBox.Size = new System.Drawing.Size(200, 20);
            this.klichkaTextBox.TabIndex = 23;
            // 
            // polLabel
            // 
            polLabel.AutoSize = true;
            polLabel.Location = new System.Drawing.Point(20, 83);
            polLabel.Name = "polLabel";
            polLabel.Size = new System.Drawing.Size(24, 13);
            polLabel.TabIndex = 24;
            polLabel.Text = "pol:";
            // 
            // polTextBox
            // 
            this.polTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cowBindingSource, "pol", true));
            this.polTextBox.Location = new System.Drawing.Point(102, 80);
            this.polTextBox.Name = "polTextBox";
            this.polTextBox.Size = new System.Drawing.Size(200, 20);
            this.polTextBox.TabIndex = 25;
            // 
            // data_birthdayLabel
            // 
            data_birthdayLabel.AutoSize = true;
            data_birthdayLabel.Location = new System.Drawing.Point(20, 110);
            data_birthdayLabel.Name = "data_birthdayLabel";
            data_birthdayLabel.Size = new System.Drawing.Size(71, 13);
            data_birthdayLabel.TabIndex = 26;
            data_birthdayLabel.Text = "data birthday:";
            // 
            // data_birthdayDateTimePicker
            // 
            this.data_birthdayDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.cowBindingSource, "data_birthday", true));
            this.data_birthdayDateTimePicker.Location = new System.Drawing.Point(102, 106);
            this.data_birthdayDateTimePicker.Name = "data_birthdayDateTimePicker";
            this.data_birthdayDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.data_birthdayDateTimePicker.TabIndex = 27;
            // 
            // kodLabel
            // 
            kodLabel.AutoSize = true;
            kodLabel.Location = new System.Drawing.Point(20, 135);
            kodLabel.Name = "kodLabel";
            kodLabel.Size = new System.Drawing.Size(28, 13);
            kodLabel.TabIndex = 28;
            kodLabel.Text = "kod:";
            // 
            // kodTextBox
            // 
            this.kodTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cowBindingSource, "kod", true));
            this.kodTextBox.Location = new System.Drawing.Point(102, 132);
            this.kodTextBox.Name = "kodTextBox";
            this.kodTextBox.Size = new System.Drawing.Size(200, 20);
            this.kodTextBox.TabIndex = 29;
            // 
            // inwert_numberLabel
            // 
            inwert_numberLabel.AutoSize = true;
            inwert_numberLabel.Location = new System.Drawing.Point(20, 161);
            inwert_numberLabel.Name = "inwert_numberLabel";
            inwert_numberLabel.Size = new System.Drawing.Size(76, 13);
            inwert_numberLabel.TabIndex = 30;
            inwert_numberLabel.Text = "inwert number:";
            // 
            // inwert_numberTextBox
            // 
            this.inwert_numberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cowBindingSource, "inwert_number", true));
            this.inwert_numberTextBox.Location = new System.Drawing.Point(102, 158);
            this.inwert_numberTextBox.Name = "inwert_numberTextBox";
            this.inwert_numberTextBox.Size = new System.Drawing.Size(200, 20);
            this.inwert_numberTextBox.TabIndex = 31;
            // 
            // id_doyarkaLabel
            // 
            id_doyarkaLabel.AutoSize = true;
            id_doyarkaLabel.Location = new System.Drawing.Point(20, 187);
            id_doyarkaLabel.Name = "id_doyarkaLabel";
            id_doyarkaLabel.Size = new System.Drawing.Size(59, 13);
            id_doyarkaLabel.TabIndex = 32;
            id_doyarkaLabel.Text = "id doyarka:";
            // 
            // id_doyarkaTextBox
            // 
            this.id_doyarkaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cowBindingSource, "id_doyarka", true));
            this.id_doyarkaTextBox.Location = new System.Drawing.Point(102, 184);
            this.id_doyarkaTextBox.Name = "id_doyarkaTextBox";
            this.id_doyarkaTextBox.Size = new System.Drawing.Size(200, 20);
            this.id_doyarkaTextBox.TabIndex = 33;
            // 
            // id_mestoLabel
            // 
            id_mestoLabel.AutoSize = true;
            id_mestoLabel.Location = new System.Drawing.Point(20, 213);
            id_mestoLabel.Name = "id_mestoLabel";
            id_mestoLabel.Size = new System.Drawing.Size(49, 13);
            id_mestoLabel.TabIndex = 34;
            id_mestoLabel.Text = "id mesto:";
            // 
            // id_mestoTextBox
            // 
            this.id_mestoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cowBindingSource, "id_mesto", true));
            this.id_mestoTextBox.Location = new System.Drawing.Point(102, 210);
            this.id_mestoTextBox.Name = "id_mestoTextBox";
            this.id_mestoTextBox.Size = new System.Drawing.Size(200, 20);
            this.id_mestoTextBox.TabIndex = 35;
            // 
            // privivkaLabel
            // 
            privivkaLabel.AutoSize = true;
            privivkaLabel.Location = new System.Drawing.Point(20, 239);
            privivkaLabel.Name = "privivkaLabel";
            privivkaLabel.Size = new System.Drawing.Size(47, 13);
            privivkaLabel.TabIndex = 36;
            privivkaLabel.Text = "privivka:";
            // 
            // privivkaTextBox
            // 
            this.privivkaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cowBindingSource, "privivka", true));
            this.privivkaTextBox.Location = new System.Drawing.Point(102, 236);
            this.privivkaTextBox.Name = "privivkaTextBox";
            this.privivkaTextBox.Size = new System.Drawing.Size(200, 20);
            this.privivkaTextBox.TabIndex = 37;
            // 
            // Red_Hud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 366);
            this.Controls.Add(id_cowLabel);
            this.Controls.Add(this.id_cowTextBox);
            this.Controls.Add(klichkaLabel);
            this.Controls.Add(this.klichkaTextBox);
            this.Controls.Add(polLabel);
            this.Controls.Add(this.polTextBox);
            this.Controls.Add(data_birthdayLabel);
            this.Controls.Add(this.data_birthdayDateTimePicker);
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
            this.Controls.Add(this.cowBindingNavigator);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Red_Hud";
            this.Text = "Red_Hud";
            this.Load += new System.EventHandler(this.Red_Hud_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fermDataSetLastV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cowBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cowBindingNavigator)).EndInit();
            this.cowBindingNavigator.ResumeLayout(false);
            this.cowBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private fermDataSetLastV fermDataSetLastV;
        private System.Windows.Forms.BindingSource cowBindingSource;
        private fermDataSetLastVTableAdapters.cowTableAdapter cowTableAdapter;
        private fermDataSetLastVTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cowBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton cowBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_cowTextBox;
        private System.Windows.Forms.TextBox klichkaTextBox;
        private System.Windows.Forms.TextBox polTextBox;
        private System.Windows.Forms.DateTimePicker data_birthdayDateTimePicker;
        private System.Windows.Forms.TextBox kodTextBox;
        private System.Windows.Forms.TextBox inwert_numberTextBox;
        private System.Windows.Forms.TextBox id_doyarkaTextBox;
        private System.Windows.Forms.TextBox id_mestoTextBox;
        private System.Windows.Forms.TextBox privivkaTextBox;
    }
}