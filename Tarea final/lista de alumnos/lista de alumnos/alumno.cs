using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_de_alumnos
{
    class alumno
    {
     public   string Nombre;

       public string Carrera;
       public string Sexo;
       public int edad;
        public alumno(string CARRERA, string NOMBRE, string SEXO, int EDAD)
        {
            this.Nombre = NOMBRE;
            this.Carrera = CARRERA;
            this.Sexo = SEXO;
            this.edad = EDAD;

        }
    }
    class Listas
    {
        private List<alumno> alum = new List<alumno>();
        public void insertar(alumno alums)
        {
            alum.Add(alums);
        }

        public List<string> grupoxsexo()
        {

            List<string> aux = new List<string>();

            var consulta = from a in alum
                           group a by a.Sexo into type
                           select new { cantidad = type.Count(), sx = type.Key };
            foreach (var a in consulta)
            {
                aux.Add(a.sx);
                aux.Add(a.cantidad.ToString());
            }
            return aux;
        }
        public List<int> edad()
        {
            List<int> au = new List<int>();
            var consulta2 = from al in alum
                            where al.edad > 18
                            select al;
            foreach (alumno p in consulta2)
            {
              
                au.Add(p.edad);
             
            }

            return au;
        }
        public List<string> grupoxcarrera()
        {

            List<string> aux = new List<string>();

            var consulta = from a in alum
                           group a by a.Carrera into type
                           select new { cantidad = type.Count(),car = type.Key };
            foreach (var a in consulta)
            {
                aux.Add(a.car);
                aux.Add(a.cantidad.ToString());
            }
            return aux;
        }





    }
}
