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
    public partial class Dob_Pers : Form
    {
        public Dob_Pers()
        {
            InitializeComponent();
        }

      

        private void Dob_Pers_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fermDataSetLastV.personal". При необходимости она может быть перемещена или удалена.
           // this.personalTableAdapter.Fill(this.fermDataSetLastV.personal);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                personalTableAdapter.InsertQuery(Convert.ToInt32(idTextBox.Text), nameTextBox.Text, positionTextBox.Text, birthdayDateTimePicker.Value, _addressTextBox.Text, telephoneTextBox.Text );
                Hide();
            }
            catch (Exception)
            {
                MessageBox.Show("Проверьте на правильность ввода");
            }
        }
    }
}
