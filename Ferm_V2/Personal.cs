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
    public partial class Personal : Form
    {
        public Personal()
        {
            InitializeComponent();
        }

        private void Personal_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fermDataSet1.personal". При необходимости она может быть перемещена или удалена.
            this.personalTableAdapter.Fill(this.fermDataSet1.personal);

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

        private void b_personal_Click(object sender, EventArgs e)
        {
            Personal pers = new Personal();
            pers.Show();
            Hide();
        }

        private void b_hudoba_Click(object sender, EventArgs e)
        {
            Hudoba hud = new Hudoba();
            hud.Show();
            Hide();
        }

        private void b_otchet_Click(object sender, EventArgs e)
        {
            Otchet_Hudoba f = new Otchet_Hudoba();
            f.Show();

        }
    }
}
