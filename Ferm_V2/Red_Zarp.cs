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
    public partial class Red_Zarp : Form
    {
        public Red_Zarp()
        {
            InitializeComponent();
        }

        private void zarplataBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.zarplataBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.fermDataSetLastV);

        }

        private void Red_Zarp_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fermDataSetLastV.zarplata". При необходимости она может быть перемещена или удалена.
            this.zarplataTableAdapter.Fill(this.fermDataSetLastV.zarplata);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите подтвердить изменения?", "Изменение данных", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                zarplataBindingSource.EndEdit();
                zarplataTableAdapter.UpdateQuery(Convert.ToInt32(id_zarplataTextBox.Text), dataDateTimePicker.Value, Convert.ToInt32(id_persTextBox.Text), Convert.ToInt32(zarp_milkTextBox.Text), Convert.ToInt32(zarp_moneyTextBox.Text), primechanieTextBox.Text);
                Close();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
