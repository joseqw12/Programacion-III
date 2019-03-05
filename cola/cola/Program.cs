using System;

namespace cola
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean salir = false;
            cola c = new cola();
            int opcion = 0;
            int x = 0;
            while (salir != true)
            {
                Console.Clear();
                Console.WriteLine("1. Push");
                Console.WriteLine("2. quitar");
                Console.WriteLine("3. Mostrar");
                Console.WriteLine("4. Salir");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Añanada un elemento");
                        x = int.Parse(Console.ReadLine());
                        c.push(x);
                        break;
                    case 2:
                        x = c.quitar();
                        Console.WriteLine("eL ELEMENTO ELIMINADO" + x);
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("los elemtos son:");
                        c.mostrar();
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

