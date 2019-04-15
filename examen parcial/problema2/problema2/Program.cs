using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema2
{
    class Program
    {
        static void Main(string[] args)

        {
            ESTUDIANTE[] estu = new ESTUDIANTE[4];
            estu[0] = new ESTUDIANTE("Juan", "Perez", "Masculino", 35, "industrial", "Dinosio,Pedro,juan");
            estu[1] = new ESTUDIANTE("Maria", "Gomez", "Femenino", 33, "Civil", "Marcela,Ricardo,Maria");
            estu[2] = new ESTUDIANTE("Pedro", "Vaca", "Masculino", 35, "Civil", "Marcela");
            estu[3] = new ESTUDIANTE("Marta", "Aramayo", "Femenino", 40,"industrial", "Dinosio,Pedro,juan");

            Console.WriteLine("* Los nombre ordenados desdendentemente por edad y luego por apellido.-");
            var consulta1 = from al in estu
                            orderby al.EDAD + al.APELLIDO descending
                            select al;
            
            foreach (ESTUDIANTE per in consulta1)
            {
                Console.WriteLine("{0} {1}", per.EDAD, per.APELLIDO, "  " + per.NOMBRE);
            }


            Console.WriteLine("*Lista de docentes menores a 35.-");
            var consulta2 = from als in estu
                            where als.EDAD < 35
                            select als;

            foreach (ESTUDIANTE docen in consulta2)
            {
                Console.WriteLine("{0}, {1} ", docen.NOMBRE, docen.EDAD);

            }
            Console.WriteLine("cantidad de docentes grupados por carrera");
            var metodo3 = estu.GroupBy(d => new { carrer = d.carrera})
                         .Select(g => new
                         {
                             Cantidad = g.Count(),
                             carrer = g.Key.carrer
                         });

            foreach (var grupocare in metodo3)
            {
                Console.WriteLine("{0} {1}", grupocare.carrer, grupocare.Cantidad);

            }
            Console.WriteLine("cantidad de docentes por sexo");
            var metodo4 = estu.GroupBy(t => new { sexo = t.SEXO })
                         .Select(g => new
                         {
                             Cantidad = g.Count(),
                             sexo = g.Key.sexo
                         });

            foreach (var grupoedad in metodo4)
            {
                Console.WriteLine("{0} {1}", grupoedad.sexo, grupoedad.Cantidad);

            }
            Console.ReadKey();

        }
    }
}

