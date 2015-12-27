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
    public partial class Dob_Korm : Form
    {
        public Dob_Korm()
        {
            InitializeComponent();
        }

        private void kormBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.kormBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.fermDataSetLastV);

        }

        private void Dob_Korm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fermDataSetLastV.korm". При необходимости она может быть перемещена или удалена.
        //    this.kormTableAdapter.Fill(this.fermDataSetLastV.korm);

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                kormTableAdapter.InsertQuery(Convert.ToInt32(id_kormTextBox.Text), dataDateTimePicker.Value, Convert.ToInt32(makuhaTextBox.Text), Convert.ToInt32(otrubTextBox.Text), Convert.ToInt32(kukuruzaTextBox.Text), Convert.ToInt32(ovesTextBox.Text), Convert.ToInt32(yachminTextBox.Text), Convert.ToInt32(sinoTextBox.Text), Convert.ToInt32(solomaTextBox.Text));
                Hide();
            }
            catch (Exception)
            {
                MessageBox.Show("Проверьте на правильность ввода");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
