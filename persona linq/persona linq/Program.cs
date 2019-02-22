using System;

using System.Linq;

namespace persona_linq
{
    class Program
    {
        static void Main(string[] args)
        {
            persona[] Alumnos = new persona[7];
            Alumnos[0] = new persona("Diego","La torre", 18,"Masculino", "1536975", 1.74, 64);
            Alumnos[1] = new persona("Diego","Castro", 19,"Masculino", "145893", 1.69, 60);
            Alumnos[2] = new persona("Franco","Adanzyc", 18,"Masculino", "7862145", 1.70, 61);
            Alumnos[3] = new persona("Gustavo","Zarate", 19,"Masculino", "14523687", 1.76, 60);
            Alumnos[4] = new persona("Isabel","Lopez", 19,"Femenino", "5479331", 1.65, 64);
            Alumnos[5] = new persona("Rossimar","Guzman", 18,"Femenino", "1447934", 1.54, 40);
            Alumnos[6] = new persona("Dieter","Quiñones", 19,"Masculino", "7547264", 1.67, 57);

            Console.WriteLine("* Los nombre ordenados desdendentemente.-");
            var consulta1 = from al in Alumnos
                            orderby al.APELLIDO descending
                            select al;
            foreach (persona per in consulta1)
            {
                Console.WriteLine("{0} {1}", per.APELLIDO, "  "+ per.NOMBRE);
            }
            Console.WriteLine("* Alumnos cuya edad sea 18 y sea masculino.-");
            var consulta2 = from als in Alumnos
                          where als.EDAD == 18 && als.SEXO == "Masculino"
                          select als;
           foreach(persona per1 in consulta2)
            {
                Console.WriteLine("{0}, {1} ",per1.NOMBRE,per1.EDAD);


            }
            Console.WriteLine("* Grupos de alumonos segun al sexo.-");
            var consulta3 = from asl in Alumnos
               group asl by asl.SEXO into sexo
                            select sexo;


            foreach (var grup in consulta3)
            {
                Console.WriteLine(grup.Key);


                foreach (persona alo in grup)
                {
                    Console.WriteLine( alo.NOMBRE + " " + alo.APELLIDO + " " + alo.SEXO);

                }
            }
            Console.WriteLine("* Cantidad de grupos por sexo .-");
            var consulta4 = from al in Alumnos
                           group al by al.SEXO into sexo
                      select new { Sexo = sexo.Key, Cantidad = sexo.Count() };


            foreach (var grupo in consulta4)
            {

                  Console.WriteLine(grupo.Sexo + "  " + grupo.Cantidad);

            }
            Console.WriteLine("* Promedio por sexo.-");

            var consulta5=from asd in Alumnos
                        group asd by asd.SEXO into sexo

               select new {  Sexo = sexo.Key, Promedio = sexo.Average(p => p.EDAD) };


            foreach (var grup in consulta5)
            {

                Console.WriteLine(grup.Sexo + " =" + grup.Promedio);
            }

            Console.ReadKey();
        }
    }
}
