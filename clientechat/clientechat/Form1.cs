using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace clientechat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btneenviar_Click(object sender, EventArgs e)
        {
           string mensaje=txtnick.Text+":" + txtmensaje.Text;
           StartClient(mensaje);
          
         
            

        }
        public  void StartClient(String mensaje)
        {
            String respuesta ="";

            // Declara un bufer de  datos para recibir datos .  
            byte[] bytes = new byte[1024];

            // Se conecta al dispositivo remoto .  
            try
            {
               
                IPEndPoint romoteEP = new IPEndPoint(IPAddress.Parse(txtIP.Text), 11000);
                // Crear un socket TCP/IP  .  
                Socket sender = new Socket(AddressFamily.InterNetwork,
                    SocketType.Stream, ProtocolType.Tcp);

                // Conetarse al punto final remoto  captura cualquier error .  
                try
                {
                    sender.Connect(romoteEP);
                    sender.RemoteEndPoint.ToString();

                    byte[] msg = Encoding.ASCII.GetBytes(mensaje);

                    // Envia datos a traves del socket .  
                    int bytesSent = sender.Send(msg);


                    int bytesRec = sender.Receive(bytes);
                    while (bytesRec > 0)
                    {
                        respuesta += Encoding.ASCII.GetString(bytes, 0, bytesRec);
                        bytesRec = sender.Receive(bytes);

                    }
                    String[] resp = respuesta.Split('-');
                    listconversacion.Items.Clear();
                    foreach (string r in resp)
                    {
                        listconversacion.Items.Add(r);
                        string[] men = r.Split(':');


                        if (listParticipantes.FindString(men[0]) == -1)
                            listParticipantes.Items.Add(men[0]);
                    }

                    // libera el socket.  
                    sender.Shutdown(SocketShutdown.Both);
                    sender.Close();
                  //  return respuesta;
                  
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
          //  return respuesta;
        }

    }
}
