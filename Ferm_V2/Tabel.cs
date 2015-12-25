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
    public partial class Tabel : Form
    {
        public Tabel()
        {
            InitializeComponent();
        }

        private void Tabel_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fermDataSet.tabel". При необходимости она может быть перемещена или удалена.
            this.tabelTableAdapter.Fill(this.fermDataSet.tabel);

        }

        private void b_personal_Click(object sender, EventArgs e)
        {
            Personal per = new Personal();
            per.Show();
            Hide();
        }
       
      
        private void b_hudoba_Click_1(object sender, EventArgs e)
        {
            Hudoba hud = new Hudoba();
            hud.Show();
            Hide();
        }

        private void b_korm_Click_1(object sender, EventArgs e)
        {
            Korm cor = new Korm();
            cor.Show();
            Hide();
        }

        private void b_tabel_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(" Вы находитесь в разделе Табель");
        }

        private void b_otchet_Click_1(object sender, EventArgs e)
        {
            Otchets otch = new Otchets();
            otch.Show();
        }

        private void b_grafik_Click_1(object sender, EventArgs e)
        {
            Graphics gr = new Graphics();
            gr.Show();
        }

        private void b_infirmation_Click_1(object sender, EventArgs e)
        {
            Contact con = new Contact();
            con.Show();
        }
    }
}
