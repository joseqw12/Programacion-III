using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RAYSSA_PADILLA_LABORATORIO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
       
    {
        class Program
        {
            static void Main(string[] args)
            {
                do
                {
                    int n;

                    Console.Clear();  //Limpia la pantalla

                    //Entrada
                    Console.WriteLine("1. Sueldo por hrs. extras de un trabajador");
                    Console.WriteLine("2. Asignación de letras a notas de un alumno");
                    Console.WriteLine("3. Calculo de comisión de un vendedor ");
                    Console.WriteLine("4. Determina si una letra es vocal o consonante ");
                    Console.WriteLine("5. Platos de comida");
                    Console.WriteLine("6. Tipo de triángulo");
                    Console.WriteLine("7. Lanzamiento de tres dados");
                    Console.WriteLine("8. El mayor de tres numeros");
                    Console.WriteLine("9. Tres lados conforman un triángulo ? ");
                    Console.WriteLine("10. Devuelve la estación del año");
                    Console.WriteLine("");

                    Console.Write("Digite un valor entre 1-10: ");
                    n = int.Parse(Console.ReadLine());
                    Console.WriteLine("");

                    //Proceso
                    switch (n)
                    {
                        case 1:
                            uno();
                            break;
                        case 2:
                            dos();
                            break;
                        case 3:
                            tres();
                            break;
                        case 4:
                            cuatro();
                            break;
                        case 5:
                            cinco();
                            break;
                        case 6:
                            seis();
                            break;
                        case 7:
                            siete();
                            break;
                        case 8:
                            ocho();
                            break;
                        case 9:
                            nueve();
                            break;
                        case 10:
                            diez();
                            break;
                        default:
                            Console.WriteLine("Introduzca un valor entre 1 y 10");
                            break;
                    }
                    Console.WriteLine("");
                    Console.Write("Digite (Intro) para continuar, (Esc) para salir ...");

                } while (Console.ReadKey().Key != ConsoleKey.Escape);

            }
            static void uno()
            //Determinar la cantidad de dinero que recibirá un trabajador por concepto 
            //de las horas extras trabajadas en una empresa, 
            //sabiendo que cuando las horas de trabajo exceden de 40, 
            //el resto se consideran horas extras y que éstas se pagan al doble de una hora normal 
            //cuando no exceden de 8; si las horas extras exceden de 8 
            //se pagan las primeras 8 al doble de lo que se paga por una hora normal y el resto al triple.
            {
                //Entrada
                double ht;
                double montoxhr, total = 0;
                Console.Write("Introduzca las horas trabajadas: ");
                ht = double.Parse(Console.ReadLine());
                Console.Write("Introduzca el monto por hora: ");
                montoxhr = double.Parse(Console.ReadLine());

                //Proceso
                if (ht <= 40)
                {
                    total = ht * montoxhr;
                }
                else if ((ht > 40) && (ht <= 48))
                {
                    total = 40 * montoxhr + 2 * montoxhr * (ht - 40);
                }
                else if (ht > 48)
                {
                    total = 40 * montoxhr + 2 * montoxhr * 8 + 3 * montoxhr * (ht - 48);
                }

                //Salida   
                Console.WriteLine("El suelto total = {0} ", total);
            }
            static void dos()
            //Se desea agregar una letra para representar la calificación de los alumnos, las 
            // calificaciones son notas entre 1 y 10; use los siguientes parámetros: A para calificaciones 
            //mayores o iguales a 9, B para calificaciones mayores o iguales a 8, C para calificaciones 
            //mayores o iguales a 7, D para calificaciones mayores o iguales a 6, F para todas las 
            //demás calificaciones.
            {
                //Entrada
                int C;
                Console.Write("Introduzca la calificacion: ");
                C= int.Parse(Console.ReadLine())

                //Proceso
                if (C<= 9)
                {
                    Console.Writeline("A  ");
                }
                else if (C>=8)
                {
                    Console.Writeline("B");
                }
                else if (C >= 7)
                {
                    Console.Writeline("C");
                else if (C>=6)
                    Console.Writeline("F")
                }

                //Salida   
            }

            static void tres()
            //Escriba un programa que, al introducir la cantidad vendida por el ejecutivo de ventas, 
            //calcule de cuánto será su comisión.
            //Desde	     Hasta	    Comisión
            //2000.00	10000.00	7%
            //10000.01	20000.00	10%
            //20000.01	en adelante	15%

            {
                double CantVenta, comisión = 0;

                Console.WriteLine("Introduzca la cantidad vendida (>= 2000): ");
                CantVenta = double.Parse(Console.ReadLine());

                if (CantVenta >= 2000 && CantVenta <= 10000)
                {
                    comisión = CantVenta * 0.07;
                }
                else if (CantVenta >= 10000.01 && CantVenta <= 20000)
                {
                    comisión = CantVenta * 0.1;
                }
                else if (CantVenta > 20000.01)
                {
                    comisión = CantVenta * 0.15;
                }
                Console.WriteLine("El monto de comisión es: " + comisión);
            }
            static void cuatro()
            //Dada una letra del abecedario determinar si es vocal o es consonante.
            {
                //entrada
                int letra;
                Console.Write("Introduzca una letra): ");
                letra = int.Parse(Console.ReadLine());
                //proceso
                if (letra = A || letra = E || letra = I || letra = O || letra = U ||) ;
                N = letra;
                Console.WriteLine("La letra es una vocal:" + N);
                else
                N = letra;
                Console.Writeline("La letra es una consonante:" + N);
                //salida
                break;
                static void cinco()
            //Un restaurante, desea dar a conocer a sus clientes el plato que se ha preparado 
            //para cada uno de los tiempos de comida desayuno, almuerzo y cena. 
            //El restaurante prepara un plato único para cada uno de los tiempos. 
            //Cuando el cliente seleccione entre los tiempos de comida (desayuno, almuerzo o cena) 
            //se debe desplegar el detalle de este. 
            //Ejemplo: 
            //Seleccione su tiempo de Comida: desayuno
            //Detalle: Plátanos, Frijoles, Queso, Crema, Pan y Café.

            {
                char tiempo;

                Console.Write("(D)esayuno, (A)lmuerzo, (C)ena: ");
                tiempo = Console.ReadKey(true).KeyChar;          //tiempo = char.Parse(Console.ReadLine());
                switch (tiempo)
                {
                    case 'D':
                    case 'd':
                        Console.WriteLine("Plátanos, Frijoles, Queso, Crema, Pan y Café");
                        break;
                    case 'A':
                    case 'a':
                        Console.WriteLine("Ensalada de atún, Consome de verduras, lasagna");
                        break;
                    case 'C':
                    case 'c':
                        Console.WriteLine("Ensalada de frutas, milanesa, cafe");
                        break;
                    default:
                        Console.WriteLine("No es un tiempo de comida.");
                        break;
                }
            }
                static void seis()
                //Dado que se tienen tres longitudes; si forman un triángulo, devolver el tipo de triángulo
                //según sus lados:
                //T. equilátero: Sus 3 lados son iguales
                //T. isósceles: 2 lados iguales
                //T. escaleno: 3 lados diferentes
                {
                    //Entrada
                    double A, B, C;

                    Console.Write("Lado A del triangulo:");
                    A = double.Parse(Console.ReadLine());
                    Console.Write("lado B del triangulo:");
                    B = double.Parse(Console.ReadLine());
                    Console.Write("lado C del triangulo:");
                    C = double.Parse(Console.ReadLine());
                    //Proceso
                    if ((A == B) && (B == C) && (A == C))

                    {
                        Console.WriteLine("El triangulo es equilatero");
                    }
                    else if ((A == B) || (B == C) || (A == C))
                    {
                        Console.WriteLine("El triangulo es isosceles");
                    }
                    else
                    {
                        Console.WriteLine("El triangulo es escaleno");
                    }
                    //salida
                }
                static void siete()
                // Desarrolle un programa que califique el puntaje obtenido en el lanzamiento de tres dados, 
                // en base a la cantidad de seis obtenidos, de acuerdo a lo siguiente:
                // Tres seis: Oro
                // Dos seis: Plata
                // Un seis: Bronce
                // Ningún seis: Perdió

                {

                    int d1, d2, d3;
                    string mje = "";

                    Console.Write("Digite el resultado del lanzamiento del dado l: ");
                    d1 = int.Parse(Console.ReadLine());
                    Console.Write("Digite el resultado del lanzamiento del dado 2: ");
                    d2 = int.Parse(Console.ReadLine());
                    Console.Write("Digite el resultado del lanzamiento del dado 3: ");
                    d3 = int.Parse(Console.ReadLine());

                    if (d1 + d2 + d3 == 18)
                    //if (d1==6 && d2==6 && d3==6)
                    {
                        mje = "Oro";
                    }
                    else if (d1 + d2 == 12 || d1 + d3 == 12 || d2 + d3 == 12)       //alt+124 = |
                                                                                    // else if ((d1==6 && d2==06) || (d1==6 && d3==6) || (d2==6 && d3==6))
                    {
                        mje = "Plata";
                    }
                    else if (d1 == 6 || d2 == 6 || d3 == 6)       //alt+124 = |
                    {
                        mje = "Bronce";
                    }
                    else
                    {
                        mje = "Perdió";
                    }
                    Console.WriteLine("La evaluación es: " + mje);
                }

                static void ocho()
                // Implemente un programa que, dados tres números, devolver el mayor.

                {
                    //Entrada
                    double N1, N2, N3;
                    Console.Write("Introduzca Numero 1:");
                    N1 = double.Parse(Console.ReadLine());
                    Console.Write("Introduzca Numero 2:");
                    N2 = double.Parse(Console.ReadLine());
                    Console.Write("Introduzca Numero 3:");
                    N3 = double.Parse(Console.ReadLine());
                    //proceso
                    if ((N1 >= N2) && (N1 >= N3))
                    {
                        Console.Write(N1);
                    }
                    else if ((N2 >= N1) && (N2 >= N3))
                    {
                        Console.Write(N2);
                    }
                    else if ((N3 >= N2) && (N3 >= N1))
                    {
                        Console.Write(N3);
                    }
                    //Salida

                static void nueve()
            //Dado que se tienen tres longitudes, diga si conforman un triángulo.
            //Teorema: En todo triángulo, la suma de dos de los lados del triángulo debe ser mayor al tercer lado. 

            {
                double l1, l2, l3;

                Console.Write("Introduzca lado 1: ");
                l1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Introduzca lado 2: ");
                l2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Introduzca lado 3: ");
                l3 = Convert.ToDouble(Console.ReadLine());

                if ((l1 + l2) > l3 && (l1 + l3) > l2 && (l2 + l3) > l1)
                {
                    Console.WriteLine("Es triangulo");
                }
                else
                    Console.WriteLine("NO Es triangulo");

            }
        }
    }




}
    }
}
