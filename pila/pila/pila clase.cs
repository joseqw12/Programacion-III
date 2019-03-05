using System;
using System.Collections.Generic;
using System.Text;

namespace pila
{
    class pila_clase
    {
        public const int maximo = 10;
        private int[] vector = new int[maximo];
        private int tope = -1;
        public void push(int valor)
        {
            if (!llena())
            {
                tope++;
                vector[tope] = valor;
            }
            else
                Console.WriteLine("La pila esta llena");
        }
        public int pop()
        {
            if (!vacia())
            {
                tope--;
                return vector[tope + 1];
            }
            else
            {
                Console.WriteLine("La pila esta vacia");
                return -1;
            }
        }
        public void mostrar()
        {
            for (int i = 0; i <= tope; i++)
            {
                Console.WriteLine("{0}", vector[i]);
            }

        }
        private Boolean vacia()
        {
            return tope == -1;
        }
        private Boolean llena()
        {
            return tope == maximo;

        }
    }
}
