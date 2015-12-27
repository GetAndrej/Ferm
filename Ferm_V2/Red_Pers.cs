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
    public partial class Red_Pers : Form
    {
        public Red_Pers()
        {
            InitializeComponent();
        }


        private void Red_Pers_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fermDataSetLastV1.personal". При необходимости она может быть перемещена или удалена.
            this.personalTableAdapter1.Fill(this.fermDataSetLastV1.personal);

        }
       
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите подтвердить изменения?", "Изменение данных", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                personalBindingSource.EndEdit();
                personalTableAdapter1.UpdateQuery(Convert.ToInt32(idTextBox.Text), nameTextBox.Text, positionTextBox.Text, birthdayDateTimePicker.Value, _addressTextBox.Text, telephoneTextBox.Text);

                Hide();

            }
        }


        private void personalBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.personalBindingSource.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.fermDataSetLastV1);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите подтвердить изменения?", "Изменение данных", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                personalBindingSource.EndEdit();
                personalTableAdapter1.UpdateQuery(Convert.ToInt32(idTextBox.Text), nameTextBox.Text, positionTextBox.Text, birthdayDateTimePicker.Value, _addressTextBox.Text, telephoneTextBox.Text);

                Hide();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
