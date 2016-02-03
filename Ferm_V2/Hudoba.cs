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
using System.Configuration;

namespace Ferm_V2
{
    
    public partial class Hudoba : Form
    {

        string constring = "server=localhost;user=root;database=ferm;port=3306;password=123456789;";


        public string a;
        public string b;
        public string c;
        public string d;
        public string q;
        public string w;
        public string p;
        public string r;
        public string t;

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
           
        }

       
        private void b_korm_Click(object sender, EventArgs e)
        {
            Korm korm = new Korm();
            korm.Show();
            
        }

        private void b_tabel_Click(object sender, EventArgs e)
        {
            Tabel tabel = new Tabel();
            tabel.Show();
           

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

        private void button1_Click(object sender, EventArgs e)
        {
            Milk milk = new Milk();
            milk.Show();
           
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

        private void выходToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }   

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void редактироватьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
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
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dobavlenie dob = new Dobavlenie();
            dob.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Zarplata zar = new Zarplata();
            zar.Show();
           
        }

        private void худобаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Otchet_Hudoba hudoba = new Otchet_Hudoba();
            hudoba.Show();

        }

        private void зарплатаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Otchet_Zarplata zar = new Otchet_Zarplata();
            zar.Show();
         
        }

        private void кормToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Otch_Korm k = new Otch_Korm();
            k.Show();
           
        }

        private void молокоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Otchet_Milk milk = new Otchet_Milk();
            milk.Show();
           
        }

        private void графикиToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Graphics grap = new Graphics();
            grap.Show();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            string file = "";   // "D:\\ferm_backup.sql";

            FolderBrowserDialog dl = new FolderBrowserDialog();
            if (dl.ShowDialog() == DialogResult.OK)
            {
                file = dl.SelectedPath + "\\ferm" + DateTime.UtcNow.ToFileTime() + ".sql";

                using (MySqlConnection conn = new MySqlConnection(constring))
                {

                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        using (MySqlBackup mb = new MySqlBackup(cmd))
                        {
                            cmd.Connection = conn;
                            conn.Open();

                            mb.ExportToFile(file);
                            conn.Close();
                            MessageBox.Show("Сохранено!");

                        }
                    }
                }
            }
           

           


        }

        private void извлечьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string fil = "";

            OpenFileDialog fil1 = new OpenFileDialog();
            fil1.Filter = "Backup Files(*.sql)|*.sql|All Files(*.*)|*.*";
            fil1.FilterIndex = 0;

            if (fil1.ShowDialog() == DialogResult.OK)
            {
                fil = fil1.FileName;
                using (MySqlConnection conn = new MySqlConnection(constring))
                {
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        using (MySqlBackup mb = new MySqlBackup(cmd))
                        {
                            cmd.Connection = conn;
                            conn.Open();
                            mb.ImportFromFile(fil);
                            conn.Close();
                            MessageBox.Show("Извлечено успешно!");
                        }
                    }
                }
            }
        }


        private void отправитьСообщениеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Contact con = new Contact();
            con.Show();
        }

        private void информацияToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Info info = new Info();
            info.Show();
        }
    }
}
