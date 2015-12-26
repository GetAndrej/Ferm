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
    public partial class Otchet_Milk : Form
    {
        public Otchet_Milk()
        {
            InitializeComponent();
        }

        private void Otchet_Milk_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fermDataSetLastV.milk". При необходимости она может быть перемещена или удалена.
            this.milkTableAdapter.Fill(this.fermDataSetLastV.milk);

            this.reportViewer1.RefreshReport();
        }
    }
}
