using System;

namespace figonacci1
{
    class Program
    {
        delegate int operacio(int n);
        static void Main(string[] args)
        {
            operacio figonacci = null;
            figonacci = (n) =>
            {
                if (n == 0) return 0;
                else if (n == 1) return 1;
                else return figonacci(n - 2) + figonacci(n - 1);
            };
            Console.WriteLine("introdusca un numero");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine(figonacci(c));
            Console.ReadKey();
        }
    }
}
