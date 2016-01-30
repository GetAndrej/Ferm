namespace Ferm_V2
{
    partial class Red_Milk
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
            System.Windows.Forms.Label dataLabel;
            System.Windows.Forms.Label id_personLabel;
            System.Windows.Forms.Label utroLabel;
            System.Windows.Forms.Label obedLabel;
            System.Windows.Forms.Label vechirLabel;
            System.Windows.Forms.Label pogolovLabel;
            System.Windows.Forms.Label vipoy_telLabel;
            System.Windows.Forms.Label obratLabel;
            System.Windows.Forms.Label zhirLabel;
            System.Windows.Forms.Label zavodLabel;
            System.Windows.Forms.Label otpravkaLabel;
            System.Windows.Forms.Label vsego_dayLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Red_Milk));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.fermDataSetLastV = new Ferm_V2.fermDataSetLastV();
            this.milkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.milkTableAdapter = new Ferm_V2.fermDataSetLastVTableAdapters.milkTableAdapter();
            this.tableAdapterManager = new Ferm_V2.fermDataSetLastVTableAdapters.TableAdapterManager();
            this.milkBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.milkBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dataDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.id_personTextBox = new System.Windows.Forms.TextBox();
            this.utroTextBox = new System.Windows.Forms.TextBox();
            this.obedTextBox = new System.Windows.Forms.TextBox();
            this.vechirTextBox = new System.Windows.Forms.TextBox();
            this.pogolovTextBox = new System.Windows.Forms.TextBox();
            this.vipoy_telTextBox = new System.Windows.Forms.TextBox();
            this.obratTextBox = new System.Windows.Forms.TextBox();
            this.zhirTextBox = new System.Windows.Forms.TextBox();
            this.zavodTextBox = new System.Windows.Forms.TextBox();
            this.otpravkaTextBox = new System.Windows.Forms.TextBox();
            this.vsego_dayTextBox = new System.Windows.Forms.TextBox();
            dataLabel = new System.Windows.Forms.Label();
            id_personLabel = new System.Windows.Forms.Label();
            utroLabel = new System.Windows.Forms.Label();
            obedLabel = new System.Windows.Forms.Label();
            vechirLabel = new System.Windows.Forms.Label();
            pogolovLabel = new System.Windows.Forms.Label();
            vipoy_telLabel = new System.Windows.Forms.Label();
            obratLabel = new System.Windows.Forms.Label();
            zhirLabel = new System.Windows.Forms.Label();
            zavodLabel = new System.Windows.Forms.Label();
            otpravkaLabel = new System.Windows.Forms.Label();
            vsego_dayLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fermDataSetLastV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.milkBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.milkBindingNavigator)).BeginInit();
            this.milkBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataLabel
            // 
            dataLabel.AutoSize = true;
            dataLabel.Location = new System.Drawing.Point(12, 41);
            dataLabel.Name = "dataLabel";
            dataLabel.Size = new System.Drawing.Size(31, 13);
            dataLabel.TabIndex = 29;
            dataLabel.Text = "data:";
            // 
            // id_personLabel
            // 
            id_personLabel.AutoSize = true;
            id_personLabel.Location = new System.Drawing.Point(12, 66);
            id_personLabel.Name = "id_personLabel";
            id_personLabel.Size = new System.Drawing.Size(53, 13);
            id_personLabel.TabIndex = 31;
            id_personLabel.Text = "id person:";
            // 
            // utroLabel
            // 
            utroLabel.AutoSize = true;
            utroLabel.Location = new System.Drawing.Point(12, 92);
            utroLabel.Name = "utroLabel";
            utroLabel.Size = new System.Drawing.Size(28, 13);
            utroLabel.TabIndex = 33;
            utroLabel.Text = "utro:";
            // 
            // obedLabel
            // 
            obedLabel.AutoSize = true;
            obedLabel.Location = new System.Drawing.Point(12, 118);
            obedLabel.Name = "obedLabel";
            obedLabel.Size = new System.Drawing.Size(34, 13);
            obedLabel.TabIndex = 35;
            obedLabel.Text = "obed:";
            // 
            // vechirLabel
            // 
            vechirLabel.AutoSize = true;
            vechirLabel.Location = new System.Drawing.Point(12, 144);
            vechirLabel.Name = "vechirLabel";
            vechirLabel.Size = new System.Drawing.Size(39, 13);
            vechirLabel.TabIndex = 37;
            vechirLabel.Text = "vechir:";
            // 
            // pogolovLabel
            // 
            pogolovLabel.AutoSize = true;
            pogolovLabel.Location = new System.Drawing.Point(12, 170);
            pogolovLabel.Name = "pogolovLabel";
            pogolovLabel.Size = new System.Drawing.Size(48, 13);
            pogolovLabel.TabIndex = 39;
            pogolovLabel.Text = "pogolov:";
            // 
            // vipoy_telLabel
            // 
            vipoy_telLabel.AutoSize = true;
            vipoy_telLabel.Location = new System.Drawing.Point(12, 196);
            vipoy_telLabel.Name = "vipoy_telLabel";
            vipoy_telLabel.Size = new System.Drawing.Size(49, 13);
            vipoy_telLabel.TabIndex = 41;
            vipoy_telLabel.Text = "vipoy tel:";
            // 
            // obratLabel
            // 
            obratLabel.AutoSize = true;
            obratLabel.Location = new System.Drawing.Point(12, 222);
            obratLabel.Name = "obratLabel";
            obratLabel.Size = new System.Drawing.Size(34, 13);
            obratLabel.TabIndex = 43;
            obratLabel.Text = "obrat:";
            // 
            // zhirLabel
            // 
            zhirLabel.AutoSize = true;
            zhirLabel.Location = new System.Drawing.Point(12, 248);
            zhirLabel.Name = "zhirLabel";
            zhirLabel.Size = new System.Drawing.Size(26, 13);
            zhirLabel.TabIndex = 45;
            zhirLabel.Text = "zhir:";
            // 
            // zavodLabel
            // 
            zavodLabel.AutoSize = true;
            zavodLabel.Location = new System.Drawing.Point(12, 274);
            zavodLabel.Name = "zavodLabel";
            zavodLabel.Size = new System.Drawing.Size(39, 13);
            zavodLabel.TabIndex = 47;
            zavodLabel.Text = "zavod:";
            // 
            // otpravkaLabel
            // 
            otpravkaLabel.AutoSize = true;
            otpravkaLabel.Location = new System.Drawing.Point(12, 300);
            otpravkaLabel.Name = "otpravkaLabel";
            otpravkaLabel.Size = new System.Drawing.Size(52, 13);
            otpravkaLabel.TabIndex = 49;
            otpravkaLabel.Text = "otpravka:";
            // 
            // vsego_dayLabel
            // 
            vsego_dayLabel.AutoSize = true;
            vsego_dayLabel.Location = new System.Drawing.Point(12, 326);
            vsego_dayLabel.Name = "vsego_dayLabel";
            vsego_dayLabel.Size = new System.Drawing.Size(59, 13);
            vsego_dayLabel.TabIndex = 51;
            vsego_dayLabel.Text = "vsego day:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 362);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "Редактировать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(147, 362);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 23);
            this.button2.TabIndex = 28;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // fermDataSetLastV
            // 
            this.fermDataSetLastV.DataSetName = "fermDataSetLastV";
            this.fermDataSetLastV.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // milkBindingSource
            // 
            this.milkBindingSource.DataMember = "milk";
            this.milkBindingSource.DataSource = this.fermDataSetLastV;
            // 
            // milkTableAdapter
            // 
            this.milkTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.cowTableAdapter = null;
            this.tableAdapterManager.kormTableAdapter = null;
            this.tableAdapterManager.loginTableAdapter = null;
            this.tableAdapterManager.mesto_corTableAdapter = null;
            this.tableAdapterManager.milkTableAdapter = this.milkTableAdapter;
            this.tableAdapterManager.personalTableAdapter = null;
            this.tableAdapterManager.tabelTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Ferm_V2.fermDataSetLastVTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.zarplataTableAdapter = null;
            // 
            // milkBindingNavigator
            // 
            this.milkBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.milkBindingNavigator.BindingSource = this.milkBindingSource;
            this.milkBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.milkBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.milkBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.milkBindingNavigatorSaveItem});
            this.milkBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.milkBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.milkBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.milkBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.milkBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.milkBindingNavigator.Name = "milkBindingNavigator";
            this.milkBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.milkBindingNavigator.Size = new System.Drawing.Size(299, 25);
            this.milkBindingNavigator.TabIndex = 29;
            this.milkBindingNavigator.Text = "bindingNavigator1";
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
            // milkBindingNavigatorSaveItem
            // 
            this.milkBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.milkBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("milkBindingNavigatorSaveItem.Image")));
            this.milkBindingNavigatorSaveItem.Name = "milkBindingNavigatorSaveItem";
            this.milkBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.milkBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.milkBindingNavigatorSaveItem.Click += new System.EventHandler(this.milkBindingNavigatorSaveItem_Click_1);
            // 
            // dataDateTimePicker
            // 
            this.dataDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.milkBindingSource, "data", true));
            this.dataDateTimePicker.Location = new System.Drawing.Point(77, 37);
            this.dataDateTimePicker.Name = "dataDateTimePicker";
            this.dataDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dataDateTimePicker.TabIndex = 30;
            // 
            // id_personTextBox
            // 
            this.id_personTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.milkBindingSource, "id_person", true));
            this.id_personTextBox.Location = new System.Drawing.Point(77, 63);
            this.id_personTextBox.Name = "id_personTextBox";
            this.id_personTextBox.Size = new System.Drawing.Size(200, 20);
            this.id_personTextBox.TabIndex = 32;
            // 
            // utroTextBox
            // 
            this.utroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.milkBindingSource, "utro", true));
            this.utroTextBox.Location = new System.Drawing.Point(77, 89);
            this.utroTextBox.Name = "utroTextBox";
            this.utroTextBox.Size = new System.Drawing.Size(200, 20);
            this.utroTextBox.TabIndex = 34;
            // 
            // obedTextBox
            // 
            this.obedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.milkBindingSource, "obed", true));
            this.obedTextBox.Location = new System.Drawing.Point(77, 115);
            this.obedTextBox.Name = "obedTextBox";
            this.obedTextBox.Size = new System.Drawing.Size(200, 20);
            this.obedTextBox.TabIndex = 36;
            // 
            // vechirTextBox
            // 
            this.vechirTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.milkBindingSource, "vechir", true));
            this.vechirTextBox.Location = new System.Drawing.Point(77, 141);
            this.vechirTextBox.Name = "vechirTextBox";
            this.vechirTextBox.Size = new System.Drawing.Size(200, 20);
            this.vechirTextBox.TabIndex = 38;
            // 
            // pogolovTextBox
            // 
            this.pogolovTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.milkBindingSource, "pogolov", true));
            this.pogolovTextBox.Location = new System.Drawing.Point(77, 167);
            this.pogolovTextBox.Name = "pogolovTextBox";
            this.pogolovTextBox.Size = new System.Drawing.Size(200, 20);
            this.pogolovTextBox.TabIndex = 40;
            // 
            // vipoy_telTextBox
            // 
            this.vipoy_telTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.milkBindingSource, "vipoy_tel", true));
            this.vipoy_telTextBox.Location = new System.Drawing.Point(77, 193);
            this.vipoy_telTextBox.Name = "vipoy_telTextBox";
            this.vipoy_telTextBox.Size = new System.Drawing.Size(200, 20);
            this.vipoy_telTextBox.TabIndex = 42;
            // 
            // obratTextBox
            // 
            this.obratTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.milkBindingSource, "obrat", true));
            this.obratTextBox.Location = new System.Drawing.Point(77, 219);
            this.obratTextBox.Name = "obratTextBox";
            this.obratTextBox.Size = new System.Drawing.Size(200, 20);
            this.obratTextBox.TabIndex = 44;
            // 
            // zhirTextBox
            // 
            this.zhirTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.milkBindingSource, "zhir", true));
            this.zhirTextBox.Location = new System.Drawing.Point(77, 245);
            this.zhirTextBox.Name = "zhirTextBox";
            this.zhirTextBox.Size = new System.Drawing.Size(200, 20);
            this.zhirTextBox.TabIndex = 46;
            // 
            // zavodTextBox
            // 
            this.zavodTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.milkBindingSource, "zavod", true));
            this.zavodTextBox.Location = new System.Drawing.Point(77, 271);
            this.zavodTextBox.Name = "zavodTextBox";
            this.zavodTextBox.Size = new System.Drawing.Size(200, 20);
            this.zavodTextBox.TabIndex = 48;
            // 
            // otpravkaTextBox
            // 
            this.otpravkaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.milkBindingSource, "otpravka", true));
            this.otpravkaTextBox.Location = new System.Drawing.Point(77, 297);
            this.otpravkaTextBox.Name = "otpravkaTextBox";
            this.otpravkaTextBox.Size = new System.Drawing.Size(200, 20);
            this.otpravkaTextBox.TabIndex = 50;
            // 
            // vsego_dayTextBox
            // 
            this.vsego_dayTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.milkBindingSource, "vsego_day", true));
            this.vsego_dayTextBox.Location = new System.Drawing.Point(77, 323);
            this.vsego_dayTextBox.Name = "vsego_dayTextBox";
            this.vsego_dayTextBox.Size = new System.Drawing.Size(200, 20);
            this.vsego_dayTextBox.TabIndex = 52;
            // 
            // Red_Milk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 397);
            this.Controls.Add(dataLabel);
            this.Controls.Add(this.dataDateTimePicker);
            this.Controls.Add(id_personLabel);
            this.Controls.Add(this.id_personTextBox);
            this.Controls.Add(utroLabel);
            this.Controls.Add(this.utroTextBox);
            this.Controls.Add(obedLabel);
            this.Controls.Add(this.obedTextBox);
            this.Controls.Add(vechirLabel);
            this.Controls.Add(this.vechirTextBox);
            this.Controls.Add(pogolovLabel);
            this.Controls.Add(this.pogolovTextBox);
            this.Controls.Add(vipoy_telLabel);
            this.Controls.Add(this.vipoy_telTextBox);
            this.Controls.Add(obratLabel);
            this.Controls.Add(this.obratTextBox);
            this.Controls.Add(zhirLabel);
            this.Controls.Add(this.zhirTextBox);
            this.Controls.Add(zavodLabel);
            this.Controls.Add(this.zavodTextBox);
            this.Controls.Add(otpravkaLabel);
            this.Controls.Add(this.otpravkaTextBox);
            this.Controls.Add(vsego_dayLabel);
            this.Controls.Add(this.vsego_dayTextBox);
            this.Controls.Add(this.milkBindingNavigator);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Red_Milk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Red_Milk";
            this.Load += new System.EventHandler(this.Red_Milk_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fermDataSetLastV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.milkBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.milkBindingNavigator)).EndInit();
            this.milkBindingNavigator.ResumeLayout(false);
            this.milkBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private fermDataSetLastV fermDataSetLastV;
        private System.Windows.Forms.BindingSource milkBindingSource;
        private fermDataSetLastVTableAdapters.milkTableAdapter milkTableAdapter;
        private fermDataSetLastVTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator milkBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton milkBindingNavigatorSaveItem;
        private System.Windows.Forms.DateTimePicker dataDateTimePicker;
        private System.Windows.Forms.TextBox id_personTextBox;
        private System.Windows.Forms.TextBox utroTextBox;
        private System.Windows.Forms.TextBox obedTextBox;
        private System.Windows.Forms.TextBox vechirTextBox;
        private System.Windows.Forms.TextBox pogolovTextBox;
        private System.Windows.Forms.TextBox vipoy_telTextBox;
        private System.Windows.Forms.TextBox obratTextBox;
        private System.Windows.Forms.TextBox zhirTextBox;
        private System.Windows.Forms.TextBox zavodTextBox;
        private System.Windows.Forms.TextBox otpravkaTextBox;
        private System.Windows.Forms.TextBox vsego_dayTextBox;
    }
}