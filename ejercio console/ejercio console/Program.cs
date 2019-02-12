using System;

namespace ejercio_console
{
    class Program
    {
        static void Main(string[] args)
        {
            operacion op = new operacion();
            op.evento += sumar;
            Console.WriteLine("ingrese un numero");
           int numero = int.Parse(Console.ReadLine());
            op.factorial(numero);
 
            Console.WriteLine("presione una tecla para salir");
            Console.ReadKey();
        }
        public static void sumar(int n)
        {
            int resultado = 0;
            for(int i=1;i<=n;i++)
            {
                resultado = resultado + i;
            }
            Console.WriteLine("la suma es" + resultado);
        }
    }
    
    public class operacion
    {
        public delegate void delegado1(int numero );
        public event delegado1 evento;

       
        public void  factorial(int numero)
        {
            
           int resultado = 1;
            
            for(int i=1;i<=numero;i++)
            {
                resultado = resultado * i;
            }
            if (resultado%3==0 && evento!=null)
            { evento(numero);

            }
            Console.WriteLine("el factorial es" + resultado);
        }
        
        
       
       
    }
   
}




   
