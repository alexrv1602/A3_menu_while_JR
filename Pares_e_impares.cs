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
    public partial class Pares_e_impares : Form
    {
        public Pares_e_impares()
        {
            InitializeComponent();
        }

        private void Pares_e_impares_Load(object sender, EventArgs e)
        {

        }

        private void btnop5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int i = 1;

            while (i <= 20)
            {
                if (i % 2 == 0)
                {
                    listBox1.Items.Add(i);
                }
                i++;
            }
        }

        private void btnop6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int i = 1;

            while (i <= 20)
            {
                if (i % 2 == 1)
                {
                    listBox1.Items.Add(i);
                }
                i++;
            }
        }
    }
}
