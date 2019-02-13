using System;

namespace inventario
{
    class Program
    {
        static void Main(string[] args)
        { inventario inv = new inventario();
            inv.stockminimo += loquequieran;
            int op = 0;
            int n;
            Boolean salir = false;
          //  while (salir == false)
          do
            {
                Console.Clear();
                Console.WriteLine("1:incrementar");
                Console.WriteLine("2:disminuir");
                Console.WriteLine("3:mostar");
                Console.WriteLine("4: salir");
                Console.WriteLine("Elegir una opcion");
                 op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        Console.Write("incrementar");
                        n = int.Parse(Console.ReadLine());
                        inv.incremento(n);
                        break;
                    case 2:
                        Console.Write("disminuir");
                        n = int.Parse(Console.ReadLine());
                        inv.disminuir(n);
                        break;
                    case 3:
                        inv.mostar();
                        Console.ReadKey();
                        break;
                    case 4: salir = true;
                        break;
                    default:
                        Console.WriteLine("opcion no valida");
                        break;
                }
            }
            while (op != 4) ;


        }
        static void loquequieran(int n)
        {
            Console.WriteLine("El estock esta en su minimo {0}", n);
            Console.ReadKey();
        }
    }
        class inventario
        {
            public delegate void delegado(int n);
            public event delegado stockminimo;
            private int stock;
            public inventario()
            {
                this.stock = 0;
            }
            public void incremento(int n)
            {
                this.stock += n;
                if(this.stock<5&&stockminimo!=null)
                {
                    stockminimo(this.stock);
                }
            }
            public void disminuir(int n)
            {
                if (this.stock < n)
                {
                    Console.WriteLine("nose dispone de este stock");
                    Console.ReadKey();
                }
                else this.stock -= n;
            if (this.stock < 5 && stockminimo != null)
            {
                stockminimo(this.stock);
            }
        }
            public void mostar()
            {
                Console.WriteLine("El estock actual es {0} ", this.stock);
            }
        }
}
