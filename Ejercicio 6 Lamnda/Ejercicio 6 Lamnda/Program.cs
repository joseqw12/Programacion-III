using System;

namespace Ejercicio_6_Lamnda
{
    
    class Program
    {
        delegate int operaciones(int x, int y);
        static void Main(string[] args)
        {
            Console.WriteLine("valores para X=10 y Y=2");
            
            operaciones del = (int x, int y) =>
            { return x + y; };
            Console.WriteLine("Suma");
            
            Console.WriteLine(del(10,2 ));


            del = (int a, int b) =>
            { return a - b; };

            Console.WriteLine("Reta");
            Console.WriteLine(del(10, 2));


            del = (int a, int b) =>
            { return a * b; };
            Console.WriteLine("Multiplicaion");
            Console.WriteLine(del(10, 2));

            del = (int a, int b) =>
            { return a /b; };
            Console.WriteLine("Division");
            Console.WriteLine(del(10, 2));

            Console.ReadKey();
        }
    }
}
