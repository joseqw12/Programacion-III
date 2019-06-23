using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lista_de_alumnos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        alumno al;
        Listas lis = new Listas();
        private void button1_Click(object sender, EventArgs e)
        {
          
             
                al = new alumno(comboBox2.Text, txtnombre.Text,comboBox1.Text, int.Parse(txtedad.Text));
          

            lis.insertar(al);
            
            txtedad.Clear();
            txtnombre.Clear();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnlistas_Click(object sender, EventArgs e)
        {
            int arriba = 0;
            panel1.Controls.Clear();
            List<string> mostrar = lis.grupoxsexo();
            foreach (string are in mostrar)
            {
                Label lbl = new Label();
                lbl.Top = arriba;
                arriba += 25;
                lbl.Text = "nro: " + are.ToString();
                panel1.Controls.Add(lbl);
            }
          
          
        }

        private void btnedad_Click(object sender, EventArgs e)
        {
            int arr = 0;
            panel2.Controls.Clear();
            List<int> mostrar1 = lis.edad();
            foreach (int are in mostrar1)
            {
                Label lbl = new Label();
                lbl.Top = arr;
                arr += 25;
                lbl.Text = "edad: " + are.ToString();
                panel2.Controls.Add(lbl);
            }
        }

        private void btncarrera_Click(object sender, EventArgs e)
        {
            int arr = 0;
            panel3.Controls.Clear();
            List<string> mostrar2 = lis.grupoxcarrera();
            foreach (string are in mostrar2)
            {
                Label lbl = new Label();
                lbl.Top = arr;
                arr += 25;
                lbl.Text = "nro: " + are.ToString();
                panel3.Controls.Add(lbl);
            }
        }
    }
}
