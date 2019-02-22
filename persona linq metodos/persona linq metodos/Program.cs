using System;
using System.Linq;
namespace persona_linq_metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona[] Alumnos = new Persona[7];
            Alumnos[0] = new Persona("Diego", "La Torre", 18, "Masculino", "13121920", 1.74, 76);
            Alumnos[1] = new Persona("Diego", "Castro", 19, "Masculino", "7483306", 1.69, 70);
            Alumnos[2] = new Persona("Isabel", "Lopez", 19, "Femenino", "7504259", 1.65, 60);
            Alumnos[3] = new Persona("Rossimar", "Guzman", 18, "Femenino", "5713604", 1.54, 40);
            Alumnos[4] = new Persona("Franco", "Adamczyk", 18, "Masculino", "12609597", 1.74, 77);
            Alumnos[5] = new Persona("Gustavo", "Zarate", 19, "Masculino", "12575699", 1.76, 60);
            Alumnos[6] = new Persona("Dieter", "Quiñones", 19, "Masculino", "7547264", 1.67, 57);
            Console.WriteLine("lista desendente");
            var Metodo1 = Alumnos.OrderByDescending(p1 => p1.Apellidos);
            foreach (var p in Metodo1)
            {
                Console.WriteLine("{0}, {1}", p.Nombre, p.Apellidos);
            }
            Console.WriteLine("lista de alumnos de 18 y masculinos");
            var metodo2 = Alumnos.Where(d => d.Edad == 18 && d.Sexo == "Masculino");
            foreach (var p in metodo2)
            {
                Console.WriteLine("{0} {1}", p.Nombre, p.Edad, p.Sexo);
            }
            Console.WriteLine("grupos por sexo");
            var metodo3 = Alumnos.GroupBy(b => b.Sexo);
            foreach (var grupo in metodo3)
            {
                Console.WriteLine(grupo.Key);
                foreach (Persona al in grupo)
                {
                    Console.WriteLine("{0} {1}", al.Nombre, al.Apellidos, al.Sexo);
                }

            }
            Console.WriteLine("cantidad de los grupos por sexo");
            var metodo4 = Alumnos.GroupBy(t => new { sexo = t.Sexo })
                         .Select(g => new
                         {
                             Cantidad = g.Count(),
                             sexo = g.Key.sexo
                         });

            foreach (var grupoedad in metodo4)
            {
                Console.WriteLine("{0} {1}", grupoedad.sexo, grupoedad.Cantidad);

            }
            Console.WriteLine("promedio de edad por sexo");
            var metodo5 = Alumnos.GroupBy(p => new { Sexo = p.Sexo })
                           .Select(p1 => new { Sexo = p1.Key, Promedio =p1.Average(s => s.Edad) });

            foreach (var promedio in metodo5)
            {
                Console.WriteLine("{0} {1}", promedio.Sexo, promedio.Promedio);

              
            }
            Console.ReadKey();
        }
    }
}
