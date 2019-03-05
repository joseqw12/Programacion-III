using System;

namespace pila
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean salir = false;
            pila_clase p = new pila_clase();
            int opcion = 0;
            int x = 0;
            while (salir != true)
            {
                Console.Clear();
                Console.WriteLine("1. Push");
                Console.WriteLine("2. Pop");
                Console.WriteLine("3. Mostrar");
                Console.WriteLine("4. Salir");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Añanada un elemento");
                        x = int.Parse(Console.ReadLine());
                        p.push(x);
                        break;
                    case 2:
                        x = p.pop();
                        Console.WriteLine("eL ELEMENTO ELIMINADO" + x);
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("los elemtos son:");
                        p.mostrar();
                        Console.ReadKey();
                        break;
                    case 4:
                        Environment.Exit(0);

                        break;
                }
            }
        }
    }
    }

