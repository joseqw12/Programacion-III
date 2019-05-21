using System;
using System.Collections.Generic;
using System.Text;

namespace polaca_estrecion
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena;
            Console.WriteLine("Ingresa la cadena a cambiar:");
            cadena = Console.ReadLine();
            Console.WriteLine(cadena.cambiar());
            Console.Read();
        }
    }
    public static class resolver
    {
        public static string cambiar(this string cad)
        {
            int tamanio = cad.Length;
            Stack<char> pila = new Stack<char>();

            StringBuilder stringenposfijo = new StringBuilder();
            for (int i = 0; i < tamanio; i++)
            {
                if ((cad[i] >= '0') && (cad[i] <= '9'))
                {

                    stringenposfijo.Append(cad[i]);
                }
                else if (cad[i] == '(')
                {
                    pila.Push(cad[i]);


                }
                else if ((cad[i] == '*') || (cad[i] == '+') || (cad[i] == '-') || (cad[i] == '/'))


                {
                    while ((pila.Count > 0) && (pila.Peek() != '('))
                    {
                        if (signosaritme(pila.Peek(), cad[i]))
                        {
                            stringenposfijo.Append(pila.Pop());
                        }
                        else
                        {
                            break;
                        }
                    }
                    pila.Push(cad[i]);

                }
                else if (cad[i] == ')')

                {
                    while ((pila.Count > 0) && (pila.Peek() != '('))

                    {
                        stringenposfijo.Append(pila.Pop());


                    }
                    if (pila.Count > 0)
                        pila.Pop(); 
                }
            }
            while (pila.Count > 0)

            {
                stringenposfijo.Append(pila.Pop());

            }
            return stringenposfijo.ToString();

        }
        public static bool signosaritme(char signo, char p_2)
        {
              if (signo == '+' && p_2 == '*') 

                  return false;

                 if (signo == '*' && p_2 == '-') 

            return true;

            if (signo == '+' && p_2 == '-') 

           return true;
                   return true;
        }
        public static int Evaluar(string polaca)
        {
            Stack<int> pila = new Stack<int>();
            int tama = polaca.Length;
            for (int i = 0; i < tama; i++)
            {
                if ((polaca[i] == '*') || (polaca[i] == '+') || (polaca[i] == '-') || (polaca[i] == ' '))
                {
                    int resultado = operacion (pila.Pop(), pila.Pop(), polaca[i]);
                    pila.Push(resultado);
                }
                else if ((polaca[i] >= '0') || (polaca[i] <= '9'))
                {
                    pila.Push((int)(polaca[i] - '0'));
                }
            }
            return pila.Pop();
        }
        public static int operacion (int p, int p_2, char p_3)
        {
            switch (p_3)
            {
                case '+':
                    return p_2 + p;
                case '-':
                    return p_2 - p;
                case '*':
                    return p_2 * p;
                case '/':
                    return p_2 / p;
                default:
                    return -1;
            }
        }
    }
}

