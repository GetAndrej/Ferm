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
            cowTableAdapter1.Fill(fermDataSetEasy.cow);
        }

        private void cowBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cowBindingSource2.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.fermDataSetEasy);

        }

        private void Red_Hud_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fermDataSetEasy.cow". При необходимости она может быть перемещена или удалена.
            
                      
        }

  
       
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите подтвердить изменения?", "Изменение данных", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                cowBindingSource2.EndEdit();
                cowTableAdapter1.UpdateQuery1(Convert.ToInt32(id_cowTextBox1.Text), klichkaTextBox1.Text, Convert.ToInt32(polTextBox1.Text), dateTimePicker1.Text, Convert.ToInt32(kodTextBox1.Text), Convert.ToInt32(inwert_numberTextBox1.Text), Convert.ToInt32(id_doyarkaTextBox1.Text), Convert.ToInt32(id_mestoTextBox1.Text), privivkaTextBox1.Text);
                
                Hide();
               
                

            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
