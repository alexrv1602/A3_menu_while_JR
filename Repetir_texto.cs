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
    public partial class Repetir_texto : Form
    {
        public Repetir_texto()
        {
            InitializeComponent();
        }

        private void Repetir_texto_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnop1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            String text = txtola.Text;
            int i = 0;
            while (i <= 10)
            {
                listBox1.Items.Add($"{i}.{text}");
                i++;
            }
            
        }

        private void txtola_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
