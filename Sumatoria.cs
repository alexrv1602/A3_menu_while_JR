using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A3_menu_while_JR
{
    public partial class Sumatoria : Form
    {
        public Sumatoria()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtnumero.Text, out int num))
            {
                int i = 0;
                int suma = 0;
                while (i <= num)
                {
                    suma = suma + i;
                    i++;
                }
                MessageBox.Show($"Sumatoria: {suma}");
            }
            else
            {
                MessageBox.Show("Ingrese un numero valido");
            }
        }
    }
}
