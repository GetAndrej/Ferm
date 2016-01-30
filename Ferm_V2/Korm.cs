using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fermDataSetLastV1.korm". При необходимости она может быть перемещена или удалена.
            this.kormTableAdapter1.Fill(this.fermDataSetLastV1.korm);
           

        }

        private void b_dobavit_Click(object sender, EventArgs e)
        {
            Dob_Korm d = new Dob_Korm();
            d.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void b_poisk_Click(object sender, EventArgs e)
        {

        }

        private void b_redactirovat_Click(object sender, EventArgs e)
        {
            Red_Korm r = new Red_Korm();
            r.Show();

        }

        private void b_udalit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите подтвердить удаление?", "Удаление данных", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                try
                {
                    kormTableAdapter1.DeleteQuery(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
                }
                catch (Exception)
                {
                    MessageBox.Show("Выберите пожалуйста полностью строку");
                }
                kormTableAdapter1.Fill(fermDataSetLastV1.korm);
                fermDataSetLastV1.AcceptChanges();
            }
        }

        private void b_personal_Click(object sender, EventArgs e)
        {
            Personal per = new Personal();
            per.Show();
            Close();
        }

        private void b_hudoba_Click(object sender, EventArgs e)
        {
            Hudoba hud = new Hudoba();
            hud.Show();
            Close();
        }

        private void b_korm_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вы находитесь в разделе Корм");
        }

        private void b_tabel_Click(object sender, EventArgs e)
        {
            Tabel tab = new Tabel();
            tab.Show();
            Close();
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

        private void button1_Click(object sender, EventArgs e)
        {
            string constring = "server=localhost;user=root;database=ferm;port=3306;password=123456789;";
            MySqlConnection con = new MySqlConnection(constring);
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from korm";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;


            con.Close();
        }
    }
}
