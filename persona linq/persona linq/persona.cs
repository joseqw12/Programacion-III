using System;
using System.Collections.Generic;
using System.Text;

namespace persona_linq
{
    class persona
    {
     
        public string NOMBRE;
        public string APELLIDO;
        public int EDAD;
        public string SEXO;
        public string CI;
        public double ALTURA;
        public double PESO;
        public persona(string NOMBRE, string APELLIDO, int EDAD, string SEXO, string CI, double ALTURA, double PESO)
        {
            this.NOMBRE = NOMBRE;
            this.APELLIDO = APELLIDO;
            this.EDAD = EDAD;
            this.SEXO = SEXO;
            this.CI = CI;
            this.ALTURA = ALTURA;
            this.PESO = PESO;
        }
    }
}
