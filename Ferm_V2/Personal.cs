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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fermDataSetLastV.personal". При необходимости она может быть перемещена или удалена.
            this.personalTableAdapter.Fill(this.fermDataSetLastV.personal);
           

        }

        private void b_dobavit_Click(object sender, EventArgs e)
        {
            Dob_Pers per = new Dob_Pers();
            per.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void b_poisk_Click(object sender, EventArgs e)
        {

        }

        private void b_redactirovat_Click(object sender, EventArgs e)
        {
            Red_Pers red = new Red_Pers();
            red.Show();
           
        }

        private void b_udalit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите подтвердить удаление?", "Удаление данных", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                try
                {
                    personalTableAdapter.DeleteQuery(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
                }
                catch (Exception)
                {
                    MessageBox.Show("Выберите пожалуйста полностью строку");
                }
                personalTableAdapter.Fill(fermDataSetLastV.personal);
                fermDataSetLastV.AcceptChanges();


            }
        }

        private void b_personal_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вы находитесь в разделе Персонал");
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

        private void b_korm_Click(object sender, EventArgs e)
        {
            Korm corm = new Korm();
            corm.Show();
            Hide();
        }

        private void b_tabel_Click(object sender, EventArgs e)
        {
            Tabel tab = new Tabel();
            tab.Show();
            Hide();
        }

        private void b_grafik_Click(object sender, EventArgs e)
        {
            Graphics gr = new Graphics();
            gr.Show();
            Hide();
        }

        private void b_infirmation_Click(object sender, EventArgs e)
        {
            Contact contact = new Contact();
            contact.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Zarplata zar = new Zarplata();
            zar.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            personalTableAdapter.Fill(fermDataSetLastV.personal);
            fermDataSetLastV.AcceptChanges();
        }
    }
}
