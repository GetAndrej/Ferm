namespace Ferm_V2
{
    partial class Redactirovanie
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
            System.Windows.Forms.Label id_cowLabel;
            System.Windows.Forms.Label klichkaLabel;
            System.Windows.Forms.Label polLabel;
            System.Windows.Forms.Label data_birthdayLabel;
            System.Windows.Forms.Label kodLabel;
            System.Windows.Forms.Label inwert_numberLabel;
            System.Windows.Forms.Label id_doyarkaLabel;
            System.Windows.Forms.Label privivkaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Redactirovanie));
            this.fermDataSet = new Ferm_V2.fermDataSet();
            this.cowBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cowTableAdapter = new Ferm_V2.fermDataSetTableAdapters.cowTableAdapter();
            this.tableAdapterManager = new Ferm_V2.fermDataSetTableAdapters.TableAdapterManager();
            this.cowBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cowBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_cowT = new System.Windows.Forms.TextBox();
            this.klichkaT = new System.Windows.Forms.TextBox();
            this.polT = new System.Windows.Forms.TextBox();
            this.kodT = new System.Windows.Forms.TextBox();
            this.inwert_numberT = new System.Windows.Forms.TextBox();
            this.id_doyarkaT = new System.Windows.Forms.TextBox();
            this.privivkaT = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.fermDataSet1 = new Ferm_V2.fermDataSet();
            this.data_birthdayT = new System.Windows.Forms.DateTimePicker();
            id_cowLabel = new System.Windows.Forms.Label();
            klichkaLabel = new System.Windows.Forms.Label();
            polLabel = new System.Windows.Forms.Label();
            data_birthdayLabel = new System.Windows.Forms.Label();
            kodLabel = new System.Windows.Forms.Label();
            inwert_numberLabel = new System.Windows.Forms.Label();
            id_doyarkaLabel = new System.Windows.Forms.Label();
            privivkaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fermDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cowBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cowBindingNavigator)).BeginInit();
            this.cowBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fermDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // id_cowLabel
            // 
            id_cowLabel.AutoSize = true;
            id_cowLabel.Location = new System.Drawing.Point(25, 38);
            id_cowLabel.Name = "id_cowLabel";
            id_cowLabel.Size = new System.Drawing.Size(19, 13);
            id_cowLabel.TabIndex = 1;
            id_cowLabel.Text = "Id:";
            // 
            // klichkaLabel
            // 
            klichkaLabel.AutoSize = true;
            klichkaLabel.Location = new System.Drawing.Point(25, 64);
            klichkaLabel.Name = "klichkaLabel";
            klichkaLabel.Size = new System.Drawing.Size(49, 13);
            klichkaLabel.TabIndex = 3;
            klichkaLabel.Text = " Кличка:";
            // 
            // polLabel
            // 
            polLabel.AutoSize = true;
            polLabel.Location = new System.Drawing.Point(25, 90);
            polLabel.Name = "polLabel";
            polLabel.Size = new System.Drawing.Size(30, 13);
            polLabel.TabIndex = 5;
            polLabel.Text = "Пол:";
            // 
            // data_birthdayLabel
            // 
            data_birthdayLabel.AutoSize = true;
            data_birthdayLabel.Location = new System.Drawing.Point(25, 116);
            data_birthdayLabel.Name = "data_birthdayLabel";
            data_birthdayLabel.Size = new System.Drawing.Size(90, 13);
            data_birthdayLabel.TabIndex = 7;
            data_birthdayLabel.Text = "День рождения:";
            // 
            // kodLabel
            // 
            kodLabel.AutoSize = true;
            kodLabel.Location = new System.Drawing.Point(25, 142);
            kodLabel.Name = "kodLabel";
            kodLabel.Size = new System.Drawing.Size(29, 13);
            kodLabel.TabIndex = 9;
            kodLabel.Text = "Код:";
            // 
            // inwert_numberLabel
            // 
            inwert_numberLabel.AutoSize = true;
            inwert_numberLabel.Location = new System.Drawing.Point(25, 168);
            inwert_numberLabel.Name = "inwert_numberLabel";
            inwert_numberLabel.Size = new System.Drawing.Size(87, 13);
            inwert_numberLabel.TabIndex = 11;
            inwert_numberLabel.Text = "Инвент. Номер:";
            // 
            // id_doyarkaLabel
            // 
            id_doyarkaLabel.AutoSize = true;
            id_doyarkaLabel.Location = new System.Drawing.Point(25, 194);
            id_doyarkaLabel.Name = "id_doyarkaLabel";
            id_doyarkaLabel.Size = new System.Drawing.Size(49, 13);
            id_doyarkaLabel.TabIndex = 13;
            id_doyarkaLabel.Text = "Доярка:";
            // 
            // privivkaLabel
            // 
            privivkaLabel.AutoSize = true;
            privivkaLabel.Location = new System.Drawing.Point(25, 220);
            privivkaLabel.Name = "privivkaLabel";
            privivkaLabel.Size = new System.Drawing.Size(60, 13);
            privivkaLabel.TabIndex = 15;
            privivkaLabel.Text = "Прививки:";
            // 
            // fermDataSet
            // 
            this.fermDataSet.DataSetName = "fermDataSet";
            this.fermDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cowBindingSource
            // 
            this.cowBindingSource.DataMember = "cow";
            this.cowBindingSource.DataSource = this.fermDataSet;
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
            this.tableAdapterManager.personalTableAdapter = null;
            this.tableAdapterManager.polTableAdapter = null;
            this.tableAdapterManager.tabelTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Ferm_V2.fermDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            this.cowBindingNavigator.Size = new System.Drawing.Size(297, 25);
            this.cowBindingNavigator.TabIndex = 0;
            this.cowBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // cowBindingNavigatorSaveItem
            // 
            this.cowBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cowBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cowBindingNavigatorSaveItem.Image")));
            this.cowBindingNavigatorSaveItem.Name = "cowBindingNavigatorSaveItem";
            this.cowBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.cowBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.cowBindingNavigatorSaveItem.Click += new System.EventHandler(this.cowBindingNavigatorSaveItem_Click);
            // 
            // id_cowT
            // 
            this.id_cowT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cowBindingSource, "id_cow", true));
            this.id_cowT.Location = new System.Drawing.Point(132, 31);
            this.id_cowT.Name = "id_cowT";
            this.id_cowT.Size = new System.Drawing.Size(148, 20);
            this.id_cowT.TabIndex = 2;
            // 
            // klichkaT
            // 
            this.klichkaT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cowBindingSource, "klichka", true));
            this.klichkaT.Location = new System.Drawing.Point(132, 57);
            this.klichkaT.Name = "klichkaT";
            this.klichkaT.Size = new System.Drawing.Size(148, 20);
            this.klichkaT.TabIndex = 4;
            // 
            // polT
            // 
            this.polT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cowBindingSource, "pol", true));
            this.polT.Location = new System.Drawing.Point(132, 83);
            this.polT.Name = "polT";
            this.polT.Size = new System.Drawing.Size(148, 20);
            this.polT.TabIndex = 6;
            // 
            // kodT
            // 
            this.kodT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cowBindingSource, "kod", true));
            this.kodT.Location = new System.Drawing.Point(132, 135);
            this.kodT.Name = "kodT";
            this.kodT.Size = new System.Drawing.Size(148, 20);
            this.kodT.TabIndex = 10;
            // 
            // inwert_numberT
            // 
            this.inwert_numberT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cowBindingSource, "inwert_number", true));
            this.inwert_numberT.Location = new System.Drawing.Point(132, 161);
            this.inwert_numberT.Name = "inwert_numberT";
            this.inwert_numberT.Size = new System.Drawing.Size(148, 20);
            this.inwert_numberT.TabIndex = 12;
            // 
            // id_doyarkaT
            // 
            this.id_doyarkaT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cowBindingSource, "id_doyarka", true));
            this.id_doyarkaT.Location = new System.Drawing.Point(132, 187);
            this.id_doyarkaT.Name = "id_doyarkaT";
            this.id_doyarkaT.Size = new System.Drawing.Size(148, 20);
            this.id_doyarkaT.TabIndex = 14;
            // 
            // privivkaT
            // 
            this.privivkaT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cowBindingSource, "privivka", true));
            this.privivkaT.Location = new System.Drawing.Point(132, 213);
            this.privivkaT.Name = "privivkaT";
            this.privivkaT.Size = new System.Drawing.Size(148, 20);
            this.privivkaT.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Редактировать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(173, 250);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Отменить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // fermDataSet1
            // 
            this.fermDataSet1.DataSetName = "fermDataSet";
            this.fermDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // data_birthdayT
            // 
            this.data_birthdayT.Location = new System.Drawing.Point(132, 110);
            this.data_birthdayT.Name = "data_birthdayT";
            this.data_birthdayT.Size = new System.Drawing.Size(148, 20);
            this.data_birthdayT.TabIndex = 19;
            // 
            // Redactirovanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 291);
            this.Controls.Add(this.data_birthdayT);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(id_cowLabel);
            this.Controls.Add(this.id_cowT);
            this.Controls.Add(klichkaLabel);
            this.Controls.Add(this.klichkaT);
            this.Controls.Add(polLabel);
            this.Controls.Add(this.polT);
            this.Controls.Add(data_birthdayLabel);
            this.Controls.Add(kodLabel);
            this.Controls.Add(this.kodT);
            this.Controls.Add(inwert_numberLabel);
            this.Controls.Add(this.inwert_numberT);
            this.Controls.Add(id_doyarkaLabel);
            this.Controls.Add(this.id_doyarkaT);
            this.Controls.Add(privivkaLabel);
            this.Controls.Add(this.privivkaT);
            this.Controls.Add(this.cowBindingNavigator);
            this.Name = "Redactirovanie";
            this.Text = "Add_Hudobu";
            this.Load += new System.EventHandler(this.Add_Hudobu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fermDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cowBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cowBindingNavigator)).EndInit();
            this.cowBindingNavigator.ResumeLayout(false);
            this.cowBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fermDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private fermDataSet fermDataSet;
        private System.Windows.Forms.BindingSource cowBindingSource;
        private fermDataSetTableAdapters.cowTableAdapter cowTableAdapter;
        private fermDataSetTableAdapters.TableAdapterManager tableAdapterManager;
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
        private System.Windows.Forms.TextBox id_cowT;
        private System.Windows.Forms.TextBox klichkaT;
        private System.Windows.Forms.TextBox polT;
        private System.Windows.Forms.TextBox kodT;
        private System.Windows.Forms.TextBox inwert_numberT;
        private System.Windows.Forms.TextBox id_doyarkaT;
        private System.Windows.Forms.TextBox privivkaT;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private fermDataSet fermDataSet1;
        private System.Windows.Forms.DateTimePicker data_birthdayT;
    }
}