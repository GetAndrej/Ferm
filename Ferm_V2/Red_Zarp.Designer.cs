namespace Ferm_V2
{
    partial class Red_Zarp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Red_Zarp));
            this.fermDataSetLastV = new Ferm_V2.fermDataSetLastV();
            this.zarplataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zarplataTableAdapter = new Ferm_V2.fermDataSetLastVTableAdapters.zarplataTableAdapter();
            this.tableAdapterManager = new Ferm_V2.fermDataSetLastVTableAdapters.TableAdapterManager();
            this.zarplataBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.zarplataBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
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
            ((System.ComponentModel.ISupportInitialize)(this.zarplataBindingNavigator)).BeginInit();
            this.zarplataBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // id_zarplataLabel
            // 
            id_zarplataLabel.AutoSize = true;
            id_zarplataLabel.Location = new System.Drawing.Point(9, 40);
            id_zarplataLabel.Name = "id_zarplataLabel";
            id_zarplataLabel.Size = new System.Drawing.Size(58, 13);
            id_zarplataLabel.TabIndex = 1;
            id_zarplataLabel.Text = "id zarplata:";
            // 
            // dataLabel
            // 
            dataLabel.AutoSize = true;
            dataLabel.Location = new System.Drawing.Point(9, 67);
            dataLabel.Name = "dataLabel";
            dataLabel.Size = new System.Drawing.Size(31, 13);
            dataLabel.TabIndex = 3;
            dataLabel.Text = "data:";
            // 
            // id_persLabel
            // 
            id_persLabel.AutoSize = true;
            id_persLabel.Location = new System.Drawing.Point(9, 92);
            id_persLabel.Name = "id_persLabel";
            id_persLabel.Size = new System.Drawing.Size(41, 13);
            id_persLabel.TabIndex = 5;
            id_persLabel.Text = "id pers:";
            // 
            // zarp_milkLabel
            // 
            zarp_milkLabel.AutoSize = true;
            zarp_milkLabel.Location = new System.Drawing.Point(9, 118);
            zarp_milkLabel.Name = "zarp_milkLabel";
            zarp_milkLabel.Size = new System.Drawing.Size(51, 13);
            zarp_milkLabel.TabIndex = 7;
            zarp_milkLabel.Text = "zarp milk:";
            // 
            // zarp_moneyLabel
            // 
            zarp_moneyLabel.AutoSize = true;
            zarp_moneyLabel.Location = new System.Drawing.Point(9, 144);
            zarp_moneyLabel.Name = "zarp_moneyLabel";
            zarp_moneyLabel.Size = new System.Drawing.Size(64, 13);
            zarp_moneyLabel.TabIndex = 9;
            zarp_moneyLabel.Text = "zarp money:";
            // 
            // primechanieLabel
            // 
            primechanieLabel.AutoSize = true;
            primechanieLabel.Location = new System.Drawing.Point(9, 170);
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
            // zarplataBindingNavigator
            // 
            this.zarplataBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.zarplataBindingNavigator.BindingSource = this.zarplataBindingSource;
            this.zarplataBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.zarplataBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.zarplataBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.zarplataBindingNavigatorSaveItem});
            this.zarplataBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.zarplataBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.zarplataBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.zarplataBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.zarplataBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.zarplataBindingNavigator.Name = "zarplataBindingNavigator";
            this.zarplataBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.zarplataBindingNavigator.Size = new System.Drawing.Size(297, 25);
            this.zarplataBindingNavigator.TabIndex = 0;
            this.zarplataBindingNavigator.Text = "bindingNavigator1";
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
            // zarplataBindingNavigatorSaveItem
            // 
            this.zarplataBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.zarplataBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("zarplataBindingNavigatorSaveItem.Image")));
            this.zarplataBindingNavigatorSaveItem.Name = "zarplataBindingNavigatorSaveItem";
            this.zarplataBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.zarplataBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.zarplataBindingNavigatorSaveItem.Click += new System.EventHandler(this.zarplataBindingNavigatorSaveItem_Click);
            // 
            // id_zarplataTextBox
            // 
            this.id_zarplataTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zarplataBindingSource, "id_zarplata", true));
            this.id_zarplataTextBox.Location = new System.Drawing.Point(82, 37);
            this.id_zarplataTextBox.Name = "id_zarplataTextBox";
            this.id_zarplataTextBox.Size = new System.Drawing.Size(200, 20);
            this.id_zarplataTextBox.TabIndex = 2;
            // 
            // dataDateTimePicker
            // 
            this.dataDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.zarplataBindingSource, "data", true));
            this.dataDateTimePicker.Location = new System.Drawing.Point(82, 63);
            this.dataDateTimePicker.Name = "dataDateTimePicker";
            this.dataDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dataDateTimePicker.TabIndex = 4;
            // 
            // id_persTextBox
            // 
            this.id_persTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zarplataBindingSource, "id_pers", true));
            this.id_persTextBox.Location = new System.Drawing.Point(82, 89);
            this.id_persTextBox.Name = "id_persTextBox";
            this.id_persTextBox.Size = new System.Drawing.Size(200, 20);
            this.id_persTextBox.TabIndex = 6;
            // 
            // zarp_milkTextBox
            // 
            this.zarp_milkTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zarplataBindingSource, "zarp_milk", true));
            this.zarp_milkTextBox.Location = new System.Drawing.Point(82, 115);
            this.zarp_milkTextBox.Name = "zarp_milkTextBox";
            this.zarp_milkTextBox.Size = new System.Drawing.Size(200, 20);
            this.zarp_milkTextBox.TabIndex = 8;
            // 
            // zarp_moneyTextBox
            // 
            this.zarp_moneyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zarplataBindingSource, "zarp_money", true));
            this.zarp_moneyTextBox.Location = new System.Drawing.Point(82, 141);
            this.zarp_moneyTextBox.Name = "zarp_moneyTextBox";
            this.zarp_moneyTextBox.Size = new System.Drawing.Size(200, 20);
            this.zarp_moneyTextBox.TabIndex = 10;
            // 
            // primechanieTextBox
            // 
            this.primechanieTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zarplataBindingSource, "primechanie", true));
            this.primechanieTextBox.Location = new System.Drawing.Point(82, 167);
            this.primechanieTextBox.Name = "primechanieTextBox";
            this.primechanieTextBox.Size = new System.Drawing.Size(200, 20);
            this.primechanieTextBox.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Редактировать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(158, 212);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Red_Zarp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 261);
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
            this.Controls.Add(this.zarplataBindingNavigator);
            this.Name = "Red_Zarp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Red_Zarp";
            this.Load += new System.EventHandler(this.Red_Zarp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fermDataSetLastV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zarplataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zarplataBindingNavigator)).EndInit();
            this.zarplataBindingNavigator.ResumeLayout(false);
            this.zarplataBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private fermDataSetLastV fermDataSetLastV;
        private System.Windows.Forms.BindingSource zarplataBindingSource;
        private fermDataSetLastVTableAdapters.zarplataTableAdapter zarplataTableAdapter;
        private fermDataSetLastVTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator zarplataBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton zarplataBindingNavigatorSaveItem;
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