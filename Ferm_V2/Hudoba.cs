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
    
    public partial class Hudoba : Form
    {
        string constring = "server=localhost;user=root;database=ferm;port=3306;password=123456789;";

        public Hudoba()
        {
            InitializeComponent();
            //Обновление
          //  cowTableAdapter.Fill(fermDataSet.cow);
            //fermDataSet.AcceptChanges();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fermDataSetLastV.cow". При необходимости она может быть перемещена или удалена.
            this.cowTableAdapter1.Fill(this.fermDataSetLastV.cow);


          

        }

        private void b_personal_Click(object sender, EventArgs e)
        {
            Personal personal = new Personal();
            personal.Show();
            Hide();
        }

        private void b_hudoba_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вы находитесь в разделе Худоба");
        }

        private void b_korm_Click(object sender, EventArgs e)
        {
            Korm korm = new Korm();
            korm.Show();
            Hide();
        }

        private void b_tabel_Click(object sender, EventArgs e)
        {
            Tabel tabel = new Tabel();
            tabel.Show();
            Hide();

        }

        
        public string a;
        public string b;
        public string c;
        public string d;
        public string q;
        public string w;
        public string p;
        public string r;
        public string t;

        private void b_dobavit_Click(object sender, EventArgs e)
        {

            // for (int i = 0; i < dataGridView1.ColumnCount; i++)
            //  krs[i] = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[i].Value.ToString();

            //for (int i = 0; i < dataGridView1.Columns.Count; i++)
            //{
            //    krs[i] += dataGridView1.CurrentRow.Cells[i].Value.ToString();
            //}

            a = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
            b = dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString();
            c = dataGridView1[2, dataGridView1.CurrentRow.Index].Value.ToString();
            d = dataGridView1[3, dataGridView1.CurrentRow.Index].Value.ToString();
            q = dataGridView1[4, dataGridView1.CurrentRow.Index].Value.ToString();
            w = dataGridView1[5, dataGridView1.CurrentRow.Index].Value.ToString();
            p = dataGridView1[6, dataGridView1.CurrentRow.Index].Value.ToString();
            r = dataGridView1[7, dataGridView1.CurrentRow.Index].Value.ToString();
            t = dataGridView1[8, dataGridView1.CurrentRow.Index].Value.ToString();

            Red_Hud red = new Red_Hud();
            red.Owner = this;
            red.Show();

            //var st = new fermDataSetLastV.cowDataTable();
            //cowTableAdapter1.FillBy(st,
            //Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
            //object[] row = st.Rows[0].ItemArray;
            //var edt = new Red_Hud(
            //    Convert.ToInt32(row[0]),
            //    row[1].ToString(),
            //    row[2].ToString(),
            //    Convert.ToDateTime(row[3]),
            //    Convert.ToInt32(row[4]),
            //    Convert.ToInt32(row[5]),
            //    Convert.ToInt32(row[6]),
            //    Convert.ToInt32(row[7]),
            //    row[8].ToString()
            //);
            //edt.ShowDialog();
            //cowTableAdapter1.Fill(fermDataSetLastV.cow);
            //fermDataSetLastV.AcceptChanges();
        }

        private void b_redactirovat_Click(object sender, EventArgs e)
        { 

            Dobavlenie dob = new Dobavlenie();
            dob.Show();

        }

        private void b_udalit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите подтвердить удаление?", "Удаление данных", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                try
                {
                    cowTableAdapter1.DeleteQuery(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
                }
                catch (Exception)
                {
                    MessageBox.Show("Выберите пожалуйста полностью строку");
                }
                cowTableAdapter1.Fill(fermDataSetLastV.cow);
                fermDataSetLastV.AcceptChanges();


            }
        }

        private void b_obnovit_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(constring);
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from cow";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;


            con.Close();
        }

        private void b_otchet_Click(object sender, EventArgs e)
        {
            Otchets otchet = new Otchets();
            otchet.Show();
        }

        private void b_grafik_Click(object sender, EventArgs e)
        {
            Graphics grap = new Graphics();
            grap.Show();
        }
        
        private void b_infirmation_Click(object sender, EventArgs e)
        {
            Contact con = new Contact();
            con.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Milk milk = new Milk();
            milk.Show();
            Hide();
        }

       

       
        private void button2_Click(object sender, EventArgs e)
        {
            Dov_zapros_DB dd = new Dov_zapros_DB();
            dd.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            MySqlConnection con = new MySqlConnection(constring);
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from cow where klichka like('%" + textBox1.Text + "%')";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;


            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
