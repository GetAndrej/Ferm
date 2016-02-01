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
    public partial class Tabel : Form
    {

        public Tabel()
        {
            InitializeComponent();
        }

        private void Tabel_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fermDataSetLastV.tabel". При необходимости она может быть перемещена или удалена.
            this.tabelTableAdapter.Fill(this.fermDataSetLastV.tabel);
          

        }

      

        private void b_tabel_Click_1(object sender, EventArgs e)
        {
            Close();
        }

     

        private void button1_Click(object sender, EventArgs e)
        {
            string constring = "server=localhost;user=root;database=ferm;port=3306;password=123456789;";
            MySqlConnection con = new MySqlConnection(constring);
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from tabel";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;


            con.Close();
        }
    }
}
