using System;
using System.Collections.Generic;
using System.Text;

namespace cola
{
    class cola
    {
        int[] vec;
        int p, u, tam;

        //CONSTRUCTOR
        public cola(int n)
        {
            p = u = -1;
            tam = n;
            vec = new int[tam];
        }

        public bool esta_llena()
        {
            if (u >= tam - 1)
                return true;
            return false;
        }

        public bool esta_vacia()
        {
            if (p == -1)
                return true;
            return false;
        }

        public bool agregar(int dato)
        {
            if (!esta_llena())
            {
                vec[++u] = dato;
                if (u == 0)
                    p = 0;
                return true;
            }
            return false;
        }

        public bool extraer(ref int dato)
        {
            //ESTA VRIABLE SE USARA PARA MOVER EL DATO 1 al 0, el 2 al 1, el 3 al 2 ...
            int var = 1;

            //SI LA PILA NO ESTA VACIA:
            if (!esta_vacia())
            {
                //ENTONCES SACAMOS EL PRIMER DATO (P[O])
                dato = vec[p];

                for (int i = 0; i < vec.Length; i++)
                {
                    //SE PREGUNTA SI var ES MENOR A LA LONGITUD DEL ARREGLO, ESTO SE HACE DEBIDO A QUE var LLEGA A UN VALOR
                    //SUPERIOR A LA LONGITUD DEL ARREGLO
                    if (var < vec.Length)
                    {
                        //PASAMOS EL DATO DE UNA POSICION A OTRA
                        //EJEMPLO: vec[0]=vec[1] EL DATO EN LA POSICION 1 SE PASA A LA POSICION 0 Y ASI HASTA LA LONGITUD DEL ARREGLO
                        vec[i] = vec[var];
                        var++;
                    }
                }

                //AHORA LA VARIABLE QUE SE IRA MOVIENDO SERA u, YA QUE EL PRIMERO SIEMPRE SERA EL ELEMENTO 0
                if (u == p)
                {
                    p = u = -1;
                }
                else
                    //DECREMENTAMOS u YA QUE QUIERE DECIR QUE "HAY UN DATO MENOS EN LA COLA", EN REALIDAD EL DATO SIGUE ALLI
                    u--;
                return true;
            }
            return false;
        }
        public void mostrar()
        {
for(int i=0;i<vec.Length;i++)
            {
                Console.WriteLine(vec[i]);
            }
        }


    }
}

