using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejrcicio1final
{
    class clasevhiculo
    {



        public int placa { get; set; }
        public string tipo_vehiculo { get; set; }
        public double montocobrar { get; set; }
        public int horaentrada { get; set; }
        public int horasalida { get; set; }
        public clasevhiculo(int Placa, string Vtipo, double VCobrar, int Vhoraen, int Vhorasali)
        {
            placa = Placa;
            tipo_vehiculo = Vtipo;
            montocobrar = VCobrar;
            horaentrada = Vhoraen;
            horasalida = Vhorasali;
        }
    }
}


       

