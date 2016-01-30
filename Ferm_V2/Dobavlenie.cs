using System;
using System.Windows.Forms;

namespace Ferm_V2
{
    public partial class Dobavlenie : Form
    {
       
       

        public Dobavlenie()
        {
            InitializeComponent();
            this.cowTableAdapter1.Fill(this.fermDataSetLastV.cow);
            this.Validate();
            this.bindingSource1.EndEdit();
          //  this.tableAdapterManager.UpdateAll(this.fermDataSet);

        }

        public Dobavlenie(string id_cow1, string klichka1, string pol1, DateTime data_birthday1, string kod1, string inwert_number1, string id_doyarka1, string id_mesto1, string privivka1)
            : this()
        {
          //  this.cowTableAdapter.Fill(this.fermDataSet1.cow);

           
            id_cow.Text = id_cow1;
            klichka.Text = klichka1;
            switch (pol1.ToUpper())
            {
                case "Корова":
                    pol.SelectedIndex = 0;
                    break;
                case "Бык":
                    pol.SelectedIndex = 1;
                    break;
                default:
                    pol.SelectedIndex = 0;
                    break;
            }
            data_birthday.SelectionStart = data_birthday1;
            kod.Text = kod1;
            inwert_number.Text = inwert_number1;
            id_doyarka.SelectedValue = id_doyarka1;
            id_mesto.Text = id_mesto1;
            privivka.Text = privivka1;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                cowTableAdapter1.InsertQuery(Convert.ToInt32(id_cow.Text), klichka.Text, pol.Text, data_birthday.SelectionStart, Convert.ToInt32(kod.Text), Convert.ToInt32(inwert_number.Text), Convert.ToInt32(id_doyarka.Text), Convert.ToInt32(id_mesto.Text), privivka.Text);
                Close();
            }
            catch (Exception) {
                MessageBox.Show("Проверьте на правильность ввода");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}




      
