using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Collections.Generic;

namespace ServidorSincrono
{
    class Program
    {
        List<String> mensaje = new List<String>(10);
        
        // Datos Recibidos Desde ElCliente.  
        public static string data = null;

        public static void StartListening()
        {
           
            byte[] bytes = new Byte[1024];

            
            IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
            IPAddress ipAddress = ipHostInfo.AddressList[0];
            IPEndPoint localEndPoint = new IPEndPoint(IPAddress.Any, 11000);

          
            Socket listener = new Socket(IPAddress.Any.AddressFamily,
                SocketType.Stream, ProtocolType.Tcp);


            try
            {
                listener.Bind(localEndPoint);
                listener.Listen(10);

                // Inicia a escuchas miestras llegan conexiones.  
                while (true)
                {
                    Console.WriteLine("Esperando por ceonexiones ...");
                    // el Programa es suspendido mientras espera oconexiones de entrada .  
                    Socket handler = listener.Accept();
                    data = null;

                    int bytesRec = handler.Receive(bytes);
                    data = Encoding.ASCII.GetString(bytes, 0, bytesRec);

                    // Muestra los datos en la consola .  
                    Console.WriteLine("Texto recibido: {0}", data);
                    mensaje.Add(data);
                    foreach (String cadena in mensaje)
                    {
                        byte[] msg = Encoding.ASCII.GetBytes(cadena+"-");
                        handler.Send(msg);
                    }
                    // Prepara los datos para responder  al cliente.  
                  //  byte[] msg = Encoding.ASCII.GetBytes(data);
                  
                  //  handler.Send(msg);
                    handler.Shutdown(SocketShutdown.Both);
                    handler.Close();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            Console.WriteLine("\nPresiones ENTER para continuar...");
            Console.Read();

        }

        public static int Main(String[] args)
        {
            StartListening();
            return 0;
        }
    }
}
