using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace Cliente
{
    public partial class Form1 : Form
    {
        IPEndPoint ie;
        Socket server;

        // Función donde el cliente se conecta al servidor indicado
        public bool conectarServer()
        {
            if (txtIP.Text != "" && txtPuerto.Text != "")
            {
                // Formateo el texto escrito en los textboxes para la conexión al servidor :
                ie = new IPEndPoint(IPAddress.Parse(txtIP.Text.Trim()), Convert.ToInt32(txtPuerto.Text.Trim()));

                server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp); // Y creo el socket del servidor

                try
                {
                    // El cliente inicia la conexión haciendo petición con Connect
                    server.Connect(ie);
                }
                catch (SocketException e)
                {
                    Console.WriteLine("Error connection: {0}\nError code: {1}({2})",
                    e.Message, (SocketError)e.ErrorCode, e.ErrorCode);
                    Console.ReadKey();
                    return false; // Si da error en la conexión, devuelve false
                }
            }
            else
            {
                return false; // Si los textboxes de la IP y el puerto están vacíos, devuelve false
            }

            return true;
        }


        public Form1()
        {
            InitializeComponent();
        }
    }

}
