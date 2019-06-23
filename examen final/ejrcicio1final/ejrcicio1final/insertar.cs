using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejrcicio1final
{
    class insertar
    {
        private List<clasevhiculo> Listavehiculos;
        public void ingresar(clasevhiculo vehi)
        {
            Listavehiculos.Add(vehi);
        }
        public Boolean eliminar(clasevhiculo alu)
        {
            return Listavehiculos.Remove(alu);
        }
        public List<clasevhiculo> motos()
        {
            List<clasevhiculo> aux = new List<clasevhiculo>();
            var consulta1 = from al in Listavehiculos
                            where al.tipo_vehiculo == "Moto"
                            select al;
            foreach (clasevhiculo p in consulta1)
            {
                aux.Add(p);
            }

            return aux;
        }

        public List<clasevhiculo> Portipo()
        {

            List<clasevhiculo> au = new List<clasevhiculo>();
            var metodo2 = au.GroupBy(d => new { vehiculo = d.tipo_vehiculo })
                            .Select(g => new
                            {
                                Cantidad = g.Count(),
                                vehiculo1 = g.Key.vehiculo
                            });

            foreach (var vehi in metodo2)
            {

                // au.(vehi.vehiculo1, vehi.Cantidad);

            }
            return au;
        }
    }
}
