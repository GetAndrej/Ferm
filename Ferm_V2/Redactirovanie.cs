using System;
using System.Windows.Forms;

namespace Ferm_V2
{
    public partial class Redactirovanie : Form
    {
       
        readonly bool edit;

        public Redactirovanie()
        {
            InitializeComponent();
            edit = false;
        }

        public Redactirovanie(string id_cow1, string klichka1, string pol1, DateTime data_birthday1, string kod1, string inwert_number1, string id_doyarka1, string privivka1)
            : this()
        {
            this.cow2TableAdapter1.Fill(this.fermDataSet1.cow);

            edit = true;
            id_cow.Text = id_cow1;
            klichka.Text = klichka1;
            switch (pol1.ToUpper())
            {
                case "корова":
                    pol.SelectedIndex = 0;
                    break;
                case "бык":
                    pol.SelectedIndex = 1;
                    break;
                default:
                    pol.SelectedIndex = 0;
                    break;
            }
            data_birthday.Value = data_birthday1;
            kod.Text = kod1;
            inwert_number.Text = inwert_number1;
            id_doyarka.SelectedValue = id_doyarka1;
            privivka.Text = privivka1;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // сделать редактирование
            //cow2TableAdapter1.UpdateQuery11(Convert.ToInt32(id_cow.Text), klichka.Text, Convert.ToInt32(pol.Text), data_birthday.Text, Convert.ToInt32(kod.Text), Convert.ToInt32(inwert_number.Text), Convert.ToInt32(id_doyarka.Text), privivka.Text);
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}




      
