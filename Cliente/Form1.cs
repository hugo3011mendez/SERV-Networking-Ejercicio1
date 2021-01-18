﻿using System;
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
                    lblError.Text = "Error connection: " + e.Message + "\nError code: " + (SocketError)e.ErrorCode + "(" + e.ErrorCode + ")";
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
            txtIP.Text = "127.0.0.1";
            txtPuerto.Text = "31416";

            lblComando.Text = "";
            lblError.Text = "";
        }


        public void pulsarBotonComando(object sender, EventArgs e)
        {
            string comando = null;

            if (!conectarServer())
            {
                lblError.Text = "ERROR : No se ha podido conectar al servidor con la IP y el puerto especificados";
            }
            else
            {
                lblError.Text = "";

                // Le doy valor a la variable comando con la propiedad Tag del botón pulsado, así me ahorro código
                Button pulsado = (Button)sender;
                comando = pulsado.Tag.ToString();
                
                using (NetworkStream ns = new NetworkStream(server)) // Se crea un Stream que hará de puente entre el Socket, el StreamReader y el StreamWriter
                using (StreamReader sr = new StreamReader(ns))
                using (StreamWriter sw = new StreamWriter(ns))
                {
                    sw.WriteLine(comando);
                    sw.Flush();

                    sr.ReadLine();
                    try
                    {
                        string respuestaServer = sr.ReadToEnd();
                        lblComando.Text = respuestaServer;
                    }
                    catch (IOException e1)
                    {
                        lblError.Text = e1.Message;
                    }
                }

            }
            server.Close();
        }
    }

}
