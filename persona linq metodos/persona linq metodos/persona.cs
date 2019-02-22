using System;
using System.Collections.Generic;
using System.Text;

namespace persona_linq_metodos
{
    class Persona
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public int Edad { get; set; }
        public string Sexo;
        string CI;
        public double Altura;
        public double Peso;
        public Persona(string Nombre, string Apellidos, int Edad, string Sexo, string CI, double Altura, double Peso)
        {
            this.Nombre = Nombre;
            this.Apellidos = Apellidos;
            this.Edad = Edad;
            this.Sexo = Sexo;
            this.CI = CI;
            this.Altura = Altura;
            this.Peso = Peso;
        }
    }
}
