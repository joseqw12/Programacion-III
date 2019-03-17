using System;
using System.Collections.Generic;
using System.Text;

namespace ejercio4_lista_de_docentes
{
    class Docentes
    {
        public string NOMBRE;
        public string APELLIDO;
        public int EDAD;
        public string carrera;
       
        public Docentes(string NOMBRE, string APELLIDO, int EDAD,string Carrear)
        {
            this.NOMBRE = NOMBRE;
            this.APELLIDO = APELLIDO;
            this.EDAD = EDAD;
            this.carrera = Carrear;
            
        }
    }
}
