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
    public partial class Graphics : Form
    {
        public Graphics()
        {
            InitializeComponent();
            
            
        }

        private void Graphics_Load(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constring = "server=localhost;user=root;database=ferm;port=3306;password=123456789;";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand("SELECT * FROM ferm.personal; ", conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    this.chart1.Series["Series1"].Points.AddXY(myReader.GetString("name"), myReader.GetUInt32("zarplata"));
                }
                conDataBase.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Не удается подключить соединение с Базой Данных");
            }
        }

    }
}
