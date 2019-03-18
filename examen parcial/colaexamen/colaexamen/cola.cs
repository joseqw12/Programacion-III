using System;
using System.Collections.Generic;
using System.Text;

namespace colaexamen
{
    class cola
    {
        public const int Maximo = 10;
        private string[] arreglo = new string[Maximo];
        private int final = -1;
        private int frente = 0;

        public void Insertar(string valor)
        {
            if (!LLena())
            {
                final++;
                arreglo[final] = valor;
            }
            else
                Console.WriteLine("La Cola esta llena");
        }
        public void Insertar1(string valor)
        {
            if (!LLena())
            {
                final++;
                arreglo[final] = valor;
            }
            else
                Console.WriteLine("La Cola esta llena");
        }
        public void Insertar2(string valor)
        {
            if (!LLena())
            {
                final++;
                arreglo[final] = valor;
            }
            else
                Console.WriteLine("La Cola esta llena");
        }
        public void Insertar3(string valor)
        {
            if (!LLena())
            {
                final++;
                arreglo[final] = valor;
            }
            else
                Console.WriteLine("La Cola esta llena");
        }
        public void Insertar4(string valor)
        {
            if (!LLena())
            {
                final++;
                arreglo[final] = valor;
            }
            else
                Console.WriteLine("La Cola esta llena");
        }
        public string Eliminar()
        {
            if (!Vacia())
            {
                frente++;
                return arreglo[frente - 1];
            }
            else
            {
                Console.WriteLine("La Cola esta Vacia");
                return arreglo[frente];
            }
        }
        public string Eliminar1()
        {
            if (!Vacia())
            {
                frente++;
                return arreglo[frente - 1];
            }
            else
            {
                Console.WriteLine("La Cola esta Vacia");
                return arreglo[frente];
            }
        }
        public string Eliminar2()
        {
            if (!Vacia())
            {
                frente++;
                return arreglo[frente - 1];
            }
            else
            {
                Console.WriteLine("La Cola esta Vacia");
                return arreglo[frente];
            }
        }
        public string Eliminar3()
        {
            if (!Vacia())
            {
                frente++;
                return arreglo[frente - 1];
            }
            else
            {
                Console.WriteLine("La Cola esta Vacia");
                return arreglo[frente];
            }
        }
        public string Eliminar4()
        {
            if (!Vacia())
            {
                frente++;
                return arreglo[frente - 1];
            }
            else
            {
                Console.WriteLine("La Cola esta Vacia");
                return arreglo[frente];
            }
        }
        public void mostrar()
        {
            for (int i = frente; i <= final; i++)
                Console.Write(arreglo[i] + " ");

        }
        private Boolean Vacia()
        {
            return final < frente;
        }
        private Boolean LLena()
        {
            return final == Maximo;
        }

    }
}
