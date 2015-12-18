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
    public partial class Tabel : Form
    {
        public Tabel()
        {
            InitializeComponent();
        }

        private void Tabel_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fermDataSet.tabel". При необходимости она может быть перемещена или удалена.
            this.tabelTableAdapter.Fill(this.fermDataSet.tabel);

        }
    }
}
