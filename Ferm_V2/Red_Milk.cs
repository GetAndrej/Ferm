using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ferm_V2
{
    public partial class Red_Milk : Form
    {
        public Red_Milk()
        {
            InitializeComponent();
        }

        private void milkBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.milkBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.fermDataSetLastV);

        }

        private void Red_Milk_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fermDataSetLastV.milk". При необходимости она может быть перемещена или удалена.
            this.milkTableAdapter.Fill(this.fermDataSetLastV.milk);
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите подтвердить изменения?", "Изменение данных", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                milkBindingSource.EndEdit();
                milkTableAdapter.UpdateQuery(dataDateTimePicker.Value, Convert.ToInt32(id_personTextBox.Text), Convert.ToInt32(utroTextBox.Text), Convert.ToInt32(obedTextBox.Text), Convert.ToInt32(vechirTextBox.Text), pogolovTextBox.Text, Convert.ToInt32(vipoy_telTextBox.Text), obratTextBox.Text, Convert.ToInt32(zhirTextBox.Text), Convert.ToInt32(zavodTextBox.Text), Convert.ToInt32(otpravkaTextBox.Text), Convert.ToInt32(vsego_dayTextBox.Text));

                Close();



            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void milkBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.milkBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.fermDataSetLastV);

        }
    }
}
