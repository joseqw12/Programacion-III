using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Net;
using System.Threading.Tasks;

namespace cliente_factorial
{
    class Program
    {
        public static void StartClient(String Nro)
        {

           
            byte[] bytes = new byte[1024];

           
            try
            {
                
                IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
                IPAddress ipAddress = ipHostInfo.AddressList[0];
               
                IPEndPoint romoteEP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 11000);
              
                Socket sender = new Socket(AddressFamily.InterNetwork,
                    SocketType.Stream, ProtocolType.Tcp);

                
                try
                {
                    sender.Connect(romoteEP);

                    Console.WriteLine("Socket connectado a {0}",
                        sender.RemoteEndPoint.ToString());

                  


                    byte[] msg = Encoding.ASCII.GetBytes(Nro);

                    
                    int bytesSent = sender.Send(msg);

                     
                    int bytesRec = sender.Receive(bytes);
                    Console.WriteLine("Imprime Prueba = {0}",
                        Encoding.ASCII.GetString(bytes, 0, bytesRec));

                    
                    sender.Shutdown(SocketShutdown.Both);
                    sender.Close();
                    Console.ReadLine();
                }
                catch (ArgumentNullException ane)
                {
                    Console.WriteLine("ArgumentNullException : {0}", ane.ToString());
                }
                catch (SocketException se)
                {
                    Console.WriteLine("SocketException : {0}", se.ToString());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error no manejado  : {0}", e.ToString());
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            Console.ReadKey();
        }

        public static int Main(String[] args)
        {
          

                Console.Write("introdusca 2 numero");

                string Nro = Console.ReadLine();
       

                StartClient(Nro);
            

                return 0;
            
        }
    }
}