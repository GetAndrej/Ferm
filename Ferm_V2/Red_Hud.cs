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
    public partial class Red_Hud : Form
    {
        public Red_Hud()
        {
            InitializeComponent();
            cowTableAdapter.Fill(fermDataSetLastV.cow);
        }

        private void cowBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cowBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.fermDataSetLastV);

        }

        private void Red_Hud_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fermDataSetLastV.cow". При необходимости она может быть перемещена или удалена.
            this.cowTableAdapter.Fill(this.fermDataSetLastV.cow);
           

        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите подтвердить изменения?", "Изменение данных", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
            
                cowBindingSource.EndEdit();
                cowTableAdapter.UpdateQuery(Convert.ToInt32(id_cowTextBox.Text), klichkaTextBox.Text, polTextBox.Text, data_birthdayDateTimePicker.Value, Convert.ToInt32(kodTextBox.Text), Convert.ToInt32(inwert_numberTextBox.Text), Convert.ToInt32(id_doyarkaTextBox.Text), Convert.ToInt32(id_mestoTextBox.Text), privivkaTextBox.Text);
                Hide();
               
                

           }

//            string constring = "server=localhost;user=root;database=ferm;port=3306;password=123456789;";
//            MySqlConnection con = new MySqlConnection(constring);
//            con.Open();
 //           MySqlCommand cmd = con.CreateCommand();
   //         cmd.CommandType = CommandType.Text;
     //       cmd.CommandText = "UPDATE cow SET `klichka` = '" + klichkaTextBox.Text + "', `pol` = '" + polTextBox.Text + "', `data_birthday` = '" + data_birthdayDateTimePicker.Value + "' where id_cow = '" + id_cowTextBox.Text+"'";
       //     cmd.ExecuteNonQuery();
         //   DataTable dt = new DataTable();
           // MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            //da.Fill(dt);
            //, `data_birthday` = '" + data_birthdayDateTimePicker.Value + "', `kod` = '" + Convert.ToInt32(kodTextBox.Text) + "', `inwert_number` = '" + Convert.ToInt32(inwert_numberTextBox.Text) + "', `id_doyarka` = '" + Convert.ToInt32(id_doyarkaTextBox.Text) + "', `id_mesto` = '" + Convert.ToInt32(id_mestoTextBox.Text) + "', `privivka` = '" + privivkaTextBox.Text + "'
            //dataGridView1.DataSource = dt;
            //`klichka` = "+ klichkaTextBox.Text +", `pol` = "+ polTextBox.Text +", `data_birthday` = "+ data_birthdayDateTimePicker.Value +", `kod` = "+ Convert.ToInt32(kodTextBox.Text) + ", `inwert_number` = "+ Convert.ToInt32(inwert_numberTextBox.Text) + ", `id_doyarka` = "+ Convert.ToInt32(id_doyarkaTextBox.Text) + ", `id_mesto` = "+ Convert.ToInt32(id_mestoTextBox.Text) + ", `privivka` = "+ privivkaTextBox.Text + "


          //  con.Close();







        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void cowBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.cowBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.fermDataSetLastV);

        }
    }
}
