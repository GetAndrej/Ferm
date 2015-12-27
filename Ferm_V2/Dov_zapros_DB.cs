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
    public partial class Dov_zapros_DB : Form
    {
        string constring = "server=localhost;user=root;database=ferm;port=3306;password=123456789;";
        public Dov_zapros_DB()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mysql_Click(object sender, EventArgs e)
        {
            try
            {
               


                MySqlConnection con = new MySqlConnection(constring);
                con.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(Tex.Text, con);
               
                DataTable dt = new DataTable();
                //MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                dGV.DataSource = dt;


                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message);
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            Tex.Clear();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(constring);
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from cow where pol like('%Б%')";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            dGV.DataSource = dt;


            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(constring);
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select sum(makuha), sum(otrub), sum(kukuruza), sum(oves), sum(yachmin), sum(sino),sum(soloma) from korm; ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            dGV.DataSource = dt;


            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(constring);
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT klichka, data_birthday, ((YEAR(CURRENT_DATE) - YEAR(data_birthday)) -(DATE_FORMAT(CURRENT_DATE, '%m%d') < DATE_FORMAT(data_birthday, '%m%d'))) AS age FROM cow ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            dGV.DataSource = dt;


            con.Close();
        }
    }
}

