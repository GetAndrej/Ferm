using System;
using System.Windows.Forms;

namespace Ferm_V2
{
    public partial class Add_Hudobu : Form
    {

        public Add_Hudobu()
        {
            InitializeComponent();
        }

        private void cowBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cowBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.fermDataSet);
           }

        private void Add_Hudobu_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fermDataSet.cow". При необходимости она может быть перемещена или удалена.
            //  this.cowTableAdapter.Fill(this.fermDataSet.cow);
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // позже сделать полностью проверку
            if (id_cowT.Text != "") {
            cowTableAdapter.InsertQuery(Convert.ToInt32( id_cowT.Text), klichkaT.Text, Convert.ToInt32( polT.Text), data_birthdayT.Text,Convert.ToInt32( kodT.Text), Convert.ToInt32(inwert_numberT.Text), Convert.ToInt32(id_doyarkaT.Text), privivkaT.Text);
            Hide();
            
            }          
        }
       

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
