using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace singletonclima
{
    public partial class miform : Form
    {
        public miform()
        {
            InitializeComponent();
        }
        double t = 0;
       
        private void btntemperatura_Click(object sender, EventArgs e)
        {
            t = Convert.ToDouble(txttemperatura.Text);
            lbvalor.Text = "la temperatura es de " + t;
        }

        private void btnmetodos_Click(object sender, EventArgs e)
        {
            clima tem = clima.getInstance();
            if(t<12)
            {
               
             //  tem.setValor(t);
               // tem.ShowMethod();
                lbtemperatura.Text = "invirno";
            }
            if(t>12&&t<18)
            {
              //  clima tem1 = clima.getInstance();
              // tem.setValor(t);
               // tem.ShowMethod();
                lbtemperatura.Text = "otoño";
            }
            if (t > 18 && t < 25)
            {
               // clima tem2 = clima.getInstance();
          //  tem.setValor(t);
              //  tem.ShowMethod();
                lbtemperatura.Text = "verano";
            
            }
            if (t > 25 && t < 33)
            {
              //  clima tem3 = clima.getInstance();
              // tem.setValor(t);
              //  tem.ShowMethod();
                lbtemperatura.Text = "primavera";
            }
        }


    }
}
