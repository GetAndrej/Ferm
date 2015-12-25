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
    public partial class Red_Hud : Form
    {
        public Red_Hud()
        {
            InitializeComponent();
            cowTableAdapter.Fill(fermDataSetLastV.cow);
        }

        private void cowBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cowBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.fermDataSetLastV);

        }

        private void Red_Hud_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fermDataSetLastV.cow". При необходимости она может быть перемещена или удалена.
            this.cowTableAdapter.Fill(this.fermDataSetLastV.cow);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fermDataSetLastV.cow". При необходимости она может быть перемещена или удалена.
            this.cowTableAdapter.Fill(this.fermDataSetLastV.cow);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fermDataSetEasy.cow". При необходимости она может быть перемещена или удалена.


        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите подтвердить изменения?", "Изменение данных", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                cowBindingSource.EndEdit();
                cowTableAdapter.UpdateQuery(Convert.ToInt32(id_cowTextBox.Text), klichkaTextBox.Text, polTextBox.Text, data_birthdayDateTimePicker.Value, Convert.ToInt32(kodTextBox.Text), Convert.ToInt32(inwert_numberTextBox.Text), Convert.ToInt32(id_doyarkaTextBox.Text), Convert.ToInt32(id_mestoTextBox.Text), privivkaTextBox.Text);
                
                Hide();
               
                

            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Hide();
        }

        private void cowBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.cowBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.fermDataSetLastV);

        }
    }
}
