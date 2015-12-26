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
    public partial class Otchets : Form
    {
        public Otchets()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Otchet_Hudoba hudoba = new Otchet_Hudoba();
            hudoba.Show();
            Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Otchet_Zarplata zar = new Otchet_Zarplata();
            zar.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Otchet_Milk milk = new Otchet_Milk();
            milk.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Otch_Korm k = new Otch_Korm();
            k.Show();
            Hide();
        }
    }
}
