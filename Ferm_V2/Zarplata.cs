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
    public partial class Zarplata : Form
    {
        public Zarplata()
        {
            InitializeComponent();
        }

        private void Zarplata_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fermDataSetLastV.zarplata". При необходимости она может быть перемещена или удалена.
            this.zarplataTableAdapter.Fill(this.fermDataSetLastV.zarplata);
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Personal per = new Personal();
            per.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dob_Zarp zar = new Dob_Zarp();
            zar.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите подтвердить удаление?", "Удаление данных", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                try
                {
                    zarplataTableAdapter.DeleteQuery(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
                }
                catch (Exception)
                {
                    MessageBox.Show("Выберите пожалуйста полностью строку");
                }
                zarplataTableAdapter.Fill(fermDataSetLastV.zarplata);
                fermDataSetLastV.AcceptChanges();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Red_Zarp red = new Red_Zarp();
            red.Show();
        }
    }
}
