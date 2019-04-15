using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema2
{
    class ESTUDIANTE
    {
        public string NOMBRE;
        public string APELLIDO;
        public int EDAD;
        public string SEXO;
        public string ALUMNO1;
        public string carrera;

        public ESTUDIANTE(string NOMBRE, string APELLIDO, string sexo, int EDAD, string Carrear ,string alumnos)
        {
            this.NOMBRE = NOMBRE;
            this.APELLIDO = APELLIDO;
            this.SEXO = sexo;
            this.EDAD = EDAD;
            this.carrera = Carrear;
            this.ALUMNO1 = alumnos;

        }
    }
}
