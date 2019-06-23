using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ordenamiento_pila
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
        Pila<string> PI = new Pila<string>();
        private void btningresar_Click(object sender, EventArgs e)
        {
            PI.push(textBox1.Text);
            textBox1.Clear();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            lbleliminar.Text = PI.pop();
        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            int arriba = 0;
            panel1.Controls.Clear();
            string[] are = PI.mostrar();
            for (int i = 0; i < are.Length; i++)
            {
                Label lbl = new Label();
                lbl.Top = arriba;
                arriba += 25;
                lbl.Text = are[i];
                panel1.Controls.Add(lbl);

            }
        }
    }
}
