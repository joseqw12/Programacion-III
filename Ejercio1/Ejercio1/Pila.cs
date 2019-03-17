using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercio1
{
    class Pila
    {
        public const int maximo = 10;
        private string[] Arreglo = new string[maximo];
        private int tope = -1;
        public void nombre(string valor)
        {
            if (!Llenar())
            {
                tope++;
                Arreglo[tope] = valor;
            }
            else Console.WriteLine("La pila esta llena");
        }
        public void apellido(string valor)
        {
            if (!Llenar())
            {
                tope++;
                Arreglo[tope] = valor;
            }
        }
        public void edad(string valor)
        {
            if (!Llenar())
            {
                tope++;
                Arreglo[tope] = valor;
            }
        }
        public void carrera(string valor)
        {
            if (!Llenar())
            {
                tope++;
                Arreglo[tope] = valor;
            }
        }
        public string push()
        {
            if (!Vacia())
            {
                tope--;
                return Arreglo[tope + 1];

            }
            else
            {
                Console.WriteLine("La pila esta vacia");
                return Arreglo[tope + 1];
            }

        }
        public string push2()
        {
            if (!Vacia())
            {
                tope--;
                return Arreglo[tope + 1];

            }
            else
            {
                Console.WriteLine("La pila esta vacia");
                return Arreglo[tope + 1];
            }
        }
        public string push3()
        {
            if (!Vacia())
            {
                tope--;
                return Arreglo[tope + 1];

            }
            else
            {
                Console.WriteLine("La pila esta vacia");
                return Arreglo[tope + 1];
            }

        }
        public string push4()
        {
            if (!Vacia())
            {
                tope--;
                return Arreglo[tope + 1];

            }
            else
            {
                Console.WriteLine("La pila esta vacia");
                return Arreglo[tope + 1];
            }

        }
        private Boolean Llenar()
            {
            return tope== maximo;
        }
        private Boolean Vacia()
        {
            return tope == -1;
        }
        public void Mostrar()
        {
            for(int i=0;i<=tope;i++)
            {
                Console.WriteLine(Arreglo[i]);
            }
        }

        
    }
}
