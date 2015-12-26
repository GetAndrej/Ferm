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
    public partial class Otchet_Zarplata : Form
    {
        public Otchet_Zarplata()
        {
            InitializeComponent();
        }

        private void Otchet_Zarplata_Load(object sender, EventArgs e)
        {
           
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fermDataSetLastV.zarplata". При необходимости она может быть перемещена или удалена.
            this.zarplataTableAdapter.Fill(this.fermDataSetLastV.zarplata);

            this.reportViewer1.RefreshReport();
        }
    }
}
