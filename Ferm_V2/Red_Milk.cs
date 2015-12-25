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
            this.tableAdapterManager.UpdateAll(this.fermDataSetEasy);

        }

        private void Red_Milk_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fermDataSetEasy.milk". При необходимости она может быть перемещена или удалена.
            this.milkTableAdapter.Fill(this.fermDataSetEasy.milk);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите подтвердить изменения?", "Изменение данных", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                milkBindingSource.EndEdit();
                milkTableAdapter.UpdateQuery(Convert.ToInt32(dataTextBox.Text), Convert.ToInt32(id_personTextBox.Text), Convert.ToInt32(utroTextBox.Text), Convert.ToInt32(obedTextBox.Text), Convert.ToInt32(vechirTextBox.Text), pogolovTextBox.Text, Convert.ToInt32(tel_telTextBox.Text), obratTextBox.Text, milk_zarplataTextBox.Text, zhirTextBox.Text, Convert.ToInt32(zavodTextBox.Text), Convert.ToInt32(otpravkaTextBox.Text), Convert.ToInt32(vsego_dayTextBox.Text));

                Hide();



            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
