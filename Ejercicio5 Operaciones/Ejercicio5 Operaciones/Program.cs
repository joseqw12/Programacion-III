using System;

namespace Ejercicio5_Operaciones
{
    delegate int operacione(int x, int y);
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese valores para X y Y para las operaciones");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("La suma");
            Console.WriteLine(ops1(Suma,x, y));
            Console.WriteLine("La resta");
            Console.WriteLine(ops1(Resta, x, y));
            Console.WriteLine("La maultiplicacion");
            Console.WriteLine(ops1(Multiplicacion, x, y));
            Console.WriteLine("La division");
            Console.WriteLine(ops1(Division, x, y));
            Console.ReadKey();
        }

        static int ops1(operacione op, int x, int y)
        {
            return (op(x, y));
        }
        static int Multiplicacion(int x, int y)
        {
            return x * y;
        }
        static int Division(int x, int y)
        {
            return x / y;
        }
        static int Suma(int x, int y)
        {
            return x + y;
        }
        static int Resta(int x, int y)
        {
            return x - y;
        }
    }
}
