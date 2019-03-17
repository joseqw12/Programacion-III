using System;

namespace Ejercio1
{
    class Program
    {
        public static string PER { get; private set; }

        static void Main(string[] args)
        {
            int opcion = 0;
            int x = 0;

            Pila p = new Pila();
            while (opcion != 4)
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

                        Console.Clear();
                        PER PERS = new PER();
                        Console.Clear();
                        Console.WriteLine("introduzca un elemento");
                        Console.WriteLine("Introdusca un nombre");
                        PERS.nombre = Console.ReadLine();
                        p.nombre(PERS.nombre);
                        Console.WriteLine("introdusca el apellido");
                        PERS.apellido = Console.ReadLine();
                        p.apellido(PERS.apellido);
                        Console.WriteLine("introdusca la edad");
                       PERS.edad = Console.ReadLine();
                        p.edad(PERS.edad);
                        Console.WriteLine("introdusca la carrera");
                       PERS.carrera = Console.ReadLine();
                        p.carrera(PERS.carrera);
                        Console.Clear();
                    
                        Console.ReadKey();
                        break;
                    case 2:
                       
                        PERS.apellido = p.push2();
                        PERS.edad = p.push3();
                        PERS.carrera = p.push4();
                        PERS.nombre = p.push(); 
                        Console.WriteLine("El elemento eliminado es {0}",PERS.nombre," ",PERS.apellido," ",PERS.edad," ",PERS.carrera);
                        Console.ReadKey();
                        break;
                    case 3:
                        p.Mostrar();
                        Console.ReadKey();
                        break;

                }

            }
        }
    }
    struct PER
    {
        public string nombre;
        public string apellido;
        public string edad;
        public string carrera;
        public PER(string Nombre, string Apellido, string Edad, string Carrera)
        {
            nombre = Nombre;
            apellido = Apellido;
            edad = Edad;
            carrera = Carrera;

        }
    }
}
