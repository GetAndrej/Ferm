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

        private void b_personal_Click(object sender, EventArgs e)
        {
            Personal per = new Personal();
            per.Show();
            Hide();
        }

        private void b_hudoba_Click(object sender, EventArgs e)
        {
            Hudoba hud = new Hudoba();
            hud.Show();
            Hide();
        }

        private void b_korm_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вы находитесь в разделе Корм");
        }

        private void b_tabel_Click(object sender, EventArgs e)
        {
            Tabel tab = new Tabel();
            tab.Show();
            Hide();
        }

        private void b_otchet_Click(object sender, EventArgs e)
        {
            Otchets otch = new Otchets();
            otch.Show();
            
        }

        private void b_grafik_Click(object sender, EventArgs e)
        {
            Graphics gr = new Graphics();
            gr.Show();
            
        }

        private void b_infirmation_Click(object sender, EventArgs e)
        {
            Contact con = new Contact();
            con.Show();
        }
    }
}
