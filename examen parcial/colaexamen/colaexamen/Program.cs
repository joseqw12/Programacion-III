using System;

namespace colaexamen
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            int x = 0;

           cola COL= new cola();
            while (opcion != 4)
            {
                Console.Clear();
                Console.WriteLine("1. INSERTAR");
                Console.WriteLine("2.ELIMINAR");
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
                        COL.Insertar(PERS.nombre);
                        Console.WriteLine("introdusca el apellido");
                        PERS.apellido = Console.ReadLine();
                        COL.Insertar1(PERS.apellido);
                        Console.WriteLine("introdusca la edad");
                        PERS.edad = Console.ReadLine();
                        COL.Insertar2(PERS.edad);
                        Console.WriteLine("ingrese el sexo");
                        PERS.sexo = Console.ReadLine();
                        COL.Insertar3(PERS.sexo);
                        Console.WriteLine("introdusca la carrera");
                        PERS.carrera = Console.ReadLine();
                        COL.Insertar4(PERS.carrera);
                        Console.Clear();

                        Console.ReadKey();
                        break;
                    case 2:

                        PERS.apellido = COL.Eliminar1();
                        PERS.edad = COL.Eliminar2();
                       PERS.sexo = COL.Eliminar3();
                        PERS.carrera = COL.Eliminar4();
                        PERS.nombre = COL.Eliminar();
                        Console.WriteLine("El elemento eliminado es {0}",PERS.nombre,"");
                            Console.ReadKey();
                        break;
                    case 3:
                        COL.mostrar();
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
        public string sexo;
        public string carrera;
        public PER(string Nombre, string Apellido, string Edad, string SEXO, string Carrera )
        {
            nombre = Nombre;
            apellido = Apellido;
            edad = Edad;
            sexo = SEXO;
            carrera = Carrera;

        }
    }
}
