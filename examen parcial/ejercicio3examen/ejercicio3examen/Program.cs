using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3examen
{
    class Operaciones
    {
      
             public delegate void Delegado(int n); 
        public event Delegado CuandoRecibaMultiplosCinco;
        public int Sumar(int x, int y)
        {
            int iSuma = x + y;
            if ((iSuma % 5 == 0) && (CuandoRecibaMultiplosCinco != null)) 
            { CuandoRecibaMultiplosCinco(iSuma); }
            return iSuma;
        }
    }
    class ProgramaEvento
    {
        static void Main()
        {
            Operaciones o = new Operaciones();
            o.CuandoRecibaMultiplosCinco += RecibeMultiploCinco;
            Console.WriteLine("VALORE PARA X:7 y Y:8");
         
            int res = o.Sumar(5, 3);
          
            res = o.Sumar(7, 8);
            Console.WriteLine("La suma es = {0}", res);
            Console.ReadKey();
        }
        static void RecibeMultiploCinco(int n)
        { 
            Console.WriteLine("Se obtuvo un multiplo de cinco valor: {0}", n);
        }
    }
}
    

