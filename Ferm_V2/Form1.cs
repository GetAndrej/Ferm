using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ferm_V2
{
    public partial class Hudoba : Form
    {
     

        public Hudoba()
        {
            InitializeComponent();
            //Обновление
          //  cowTableAdapter.Fill(fermDataSet.cow);
            //fermDataSet.AcceptChanges();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fermDataSet.cow". При необходимости она может быть перемещена или удалена.
            this.cowTableAdapter.Fill(this.fermDataSet.cow);

        }

        private void b_personal_Click(object sender, EventArgs e)
        {
            Personal personal = new Personal();
            personal.Show();
            Hide();
        }

        private void b_hudoba_Click(object sender, EventArgs e)
        {
            Hudoba hudoba = new Hudoba();
            hudoba.Show();
            Hide();
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

        private void b_dobavit_Click(object sender, EventArgs e)
        { 
            Add_Hudobu dob = new Add_Hudobu();
            dob.Show();
         
        }

        private void b_redactirovat_Click(object sender, EventArgs e)
        {
            Redactirovanie reda = new Redactirovanie();
            reda.Show();
            
        }

        private void b_udalit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите подтвердить удаление?", "Удаление данных", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                try
                {
                    cowTableAdapter.DeleteQuery1(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
                }
                catch (Exception)
                {
                    MessageBox.Show("Выберите пожалуйста полностью строку");
                }
                cowTableAdapter.Fill(fermDataSet.cow);
                fermDataSet.AcceptChanges();


            }
        }

        private void b_obnovit_Click(object sender, EventArgs e)
        {
            cowTableAdapter.Fill(fermDataSet.cow);
            fermDataSet.AcceptChanges();
        }
    }
}
