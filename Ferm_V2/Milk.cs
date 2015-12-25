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
    public partial class Milk : Form
    {
        public Milk()
        {
            InitializeComponent();
        }

        private void Milk_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fermDataSetLastV.milk". При необходимости она может быть перемещена или удалена.
            this.milkTableAdapter.Fill(this.fermDataSetLastV.milk);
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hudoba hud = new Hudoba();
            hud.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите подтвердить удаление?", "Удаление данных", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                try
                {
                    milkTableAdapter.DeleteQuery();
                }
                catch (Exception)
                {
                    MessageBox.Show("Выберите пожалуйста полностью строку");
                }
                milkTableAdapter.Fill(fermDataSetLastV.milk);
                fermDataSetLastV.AcceptChanges();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dob_Milk dob = new Dob_Milk();
            dob.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            milkTableAdapter.Fill(fermDataSetLastV.milk);
            fermDataSetLastV.AcceptChanges();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Red_Milk re = new Red_Milk();
            re.Show();
        }
    }
}
