using System;
using System.Linq;

namespace ejercio4_lista_de_docentes
{
    class Program
    {
        static void Main(string[] args)
        {
            Docentes[] docent = new Docentes[5];
            docent[0] = new Docentes("Vicente", "Campos", 61, "Administracion De Empresas");
            docent[1] = new Docentes("Henrry", "Subieta", 50, "Programacion");
            docent[2] = new Docentes("Luis", "Teran", 45, "Ing Industrial");
            docent[3] = new Docentes("Alicia", "Alarcon", 62, "contablilidad");
            docent[4] = new Docentes("Sandra", "Villafani", 60, "Medicina");
            Console.WriteLine("* Los nombre ordenados desdendentemente.-");
            var consulta1 = from al in docent
                            orderby al.APELLIDO descending
                            select al;
            foreach (Docentes doc in consulta1)
            {
                Console.WriteLine("{0}{1}", doc.APELLIDO, " " + doc.NOMBRE);
            }
            Console.WriteLine("*Lista de docentes de edad mayor a 60.-");
            var consulta2 = from als in docent
                            where als.EDAD >= 60
                            select als;
                             
            foreach (Docentes docen in consulta2)
            {
                Console.WriteLine("{0}, {1} ", docen.NOMBRE, docen.EDAD);

                
            }
            Console.WriteLine("cantidad de docentes con la misma edad");
            var metodo4 = docent.GroupBy(t => new { edad = t.EDAD })
                         .Select(g => new
                         {
                             Cantidad = g.Count(),
                             Edad= g.Key.edad
                         });

            foreach (var grupoedad in metodo4)
            {
                Console.WriteLine("{0} {1}" ,grupoedad.Edad,  grupoedad.Cantidad);
              
            }
            Console.ReadKey();
        }
    }
}
