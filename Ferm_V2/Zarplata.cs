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
            Close();
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

        private void button5_Click(object sender, EventArgs e)
        {
            string constring = "server=localhost;user=root;database=ferm;port=3306;password=123456789;";
            MySqlConnection con = new MySqlConnection(constring);
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from zarplata";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;


            con.Close();
        }
    }
}
