using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejrcicio1final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        insertar ins = new insertar();
        private void btningresar_Click(object sender, EventArgs e)
        {
            clasevhiculo a = new clasevhiculo(int.Parse(txtplaca.Text), txtvehiculo.Text, int.Parse(txtmonto.Text),int.Parse(txtentrada.Text),int.Parse(txtsalida.Text));
          
            ins.ingresar(a);
           
        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {

            listBox1.Items.Add(in);
            }
        }
    }

