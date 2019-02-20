using System;
using System.Linq;

namespace Clase_Persona
{
    class Program
    {


        static void Main(string[] args)
        {
            persona[] Alumnos = new persona[7];
            Alumnos[0] = new persona("Diego", "La torre", 18, "Masculino","1536975", 1.74, 64);
            Alumnos[1] = new persona("Diego", "Castro", 19, "Masculino", "145893", 1.69, 60);
            Alumnos[2] = new persona("Franco", "Adanzyc", 19, "MASCULINO","7862145", 1.70, 61);
            Alumnos[3] = new persona("Gustavo", "Zarate", 19, "MASCULINO","14523687", 1.76, 60);
            Alumnos[4] = new persona("Isabel", "Lopez", 18, "Femenino","5479331", 1.65, 64);
            Alumnos[5] = new persona("Rossimar", "Guzman", 18, "Femenino","1447934", 1.54, 40);
            Alumnos[6] = new persona("Dieter", "Quiñones", 19, "MASCULINO", "7547264",1.67, 57);
           
                var consulta1 = from als in Alumnos
                                select als;
            foreach (persona p in consulta1)
            {
                Console.WriteLine("{0} {1} {2} {3} ", p.NOMBRE, p.APELLIDO, p.EDAD, p.SEXO);
            }
            Console.WriteLine("***");

            Console.WriteLine("2.- lista de los alumnos cuya edad sea mayora 18");
            var consulta2 = from als in Alumnos
                                where als.EDAD> 18
                                select als;
            foreach (persona p in consulta2)
            {
                Console.WriteLine("{0}, {1}", p.NOMBRE, p.APELLIDO);
            }

            Console.WriteLine("***");

            Console.WriteLine("3.- lista de alumnos ordenada por apellidos");
            var consulta3 = from als in Alumnos
                            orderby als.APELLIDO

                            select new { als.NOMBRE, als.APELLIDO };
            foreach (var p in consulta3)
            {
                Console.WriteLine("{0}, {1}", p.NOMBRE, p.APELLIDO);
            }

            Console.WriteLine("***");

            Console.WriteLine("4.- lista de alumnos ordenada por nombre luego por apellido descendentemente");
            var consulta4 = from asl in Alumnos
                            orderby asl.NOMBRE, asl.APELLIDO descending
                            select asl;
            foreach (var p in consulta4)
            {
                Console.WriteLine("{0}, {1}", p.NOMBRE, p.APELLIDO);
            }

            Console.WriteLine("***");

            Console.WriteLine("5.- Lista de Alumnos Agrupadas por Edades ");
            var consulta5 = from als in Alumnos
                            group als by als.EDAD into edad
                            select edad;
                            
            foreach(var gruupropiedads in consulta5)
            {
                Console.WriteLine(gruupropiedads.Key);
                foreach (persona alumno in gruupropiedads)
                {
                    Console.WriteLine("{0} {1}", alumno.NOMBRE, alumno.APELLIDO);
                }
                 
        }
            Console.WriteLine("********************************");
            //
            Console.WriteLine("6.- Cantidad de  alumnos por edad ");

            var consulta6 = from almu in Alumnos
                            group almu by almu.EDAD into edad
                            select new { Edad = edad.Key, Cantidad = edad.Count() };
            foreach (var grupoedad in consulta6)
            {
                Console.WriteLine("{0} {1}", grupoedad.Edad, grupoedad.Cantidad);

            }
            Console.WriteLine("***");
            //
            Console.WriteLine("7.- Promedio de Edad por Sexo ");

            var consulta7 = from almu in Alumnos
                            group almu by almu.SEXO into sexos
                            select new { Sexo = sexos.Key, Promedio = sexos.Average(pe => pe.EDAD) };
            foreach (var grupoedad in consulta7)
            {
                Console.WriteLine("{0} {1}", grupoedad.Sexo, grupoedad.Promedio);

            }
            Console.WriteLine("***");
            Console.WriteLine("8.- Las personas mas alta por sexo  ");

            var consulta8 = from almu in Alumnos
                            group almu by almu.SEXO into Alturas
                            select new { Sexo = Alturas.Key, Altura = Alturas.Max(p => p.ALTURA) };
            foreach (var gruposexo in consulta8)
            {
                Console.WriteLine("{0} {1}", gruposexo.Sexo, gruposexo.Altura);

            }
            Console.WriteLine("***");
            Console.WriteLine("9.- Los tres almumnos con menor Peso  ");

            var consulta9 = (from almu in Alumnos
                             orderby almu.PESO
                             select almu).Take(3);
            foreach (var al in consulta9)
            {
                Console.WriteLine("{0} {1} {2}", al.NOMBRE, al.APELLIDO, al.PESO);

            }
            Console.WriteLine("***");

            Console.ReadKey();

        }


    }
}
