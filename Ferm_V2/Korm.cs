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
    public partial class Korm : Form
    {
        public Korm()
        {
            InitializeComponent();
        }

        private void Korm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fermDataSet.korm". При необходимости она может быть перемещена или удалена.
            this.kormTableAdapter.Fill(this.fermDataSet.korm);

        }

        private void b_dobavit_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void b_poisk_Click(object sender, EventArgs e)
        {

        }

        private void b_redactirovat_Click(object sender, EventArgs e)
        {

        }

        private void b_udalit_Click(object sender, EventArgs e)
        {

        }
    }
}
