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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnop1_Click(object sender, EventArgs e)
        {
            Repetir_texto repetir_Texto = new Repetir_texto(); //Crear un objeto con el nombre del formulario "Repetir_texto"
            repetir_Texto.Show();

            this.Hide();
        }

        private void btnop2_Click(object sender, EventArgs e)
        {
            Pares_e_impares pares_E_Impares = new Pares_e_impares();
            pares_E_Impares.Show();

            this.Hide();
        }

        private void btnop3_Click(object sender, EventArgs e)
        {
            Sumatoria sumatoria = new Sumatoria();
            sumatoria.Show();

            this.Hide();
        }
    }
}
