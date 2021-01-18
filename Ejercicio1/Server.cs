using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace Ejercicio1
{
    class Server
    {
        static void Main(string[] args)
        {
            IPEndPoint ie = new IPEndPoint(IPAddress.Loopback, 31416); // Establezco un par IP-Puerto para el server
            Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp); // Establezco el Socket
            s.Bind(ie); // Se enlaza el Socket al IPEndPoint
            s.Listen(5); // Se queda esperando una conexión y se establece la cola a 5 clientes máximo en cola


            // Cliente :
            Socket sClient = s.Accept(); // Aceptamos la conexión del cliente

            // Obtenemos info del cliente :
            IPEndPoint ieClient = (IPEndPoint)sClient.RemoteEndPoint; // Casteo a IPEndPoint porque EndPoint es más genérico
            Console.WriteLine("Client connected :\n{0} at port {1}", ieClient.Address, ieClient.Port); // Muestro la IP del cliente y el puerto al que está conectado

            // Conexión :
            // Uso using para no tener que cerrarlos después
            using (NetworkStream ns = new NetworkStream(sClient)) // Se crea un Stream que hará de puente entre el Socket, el StreamReader y el StreamWriter
            using (StreamReader sr = new StreamReader(ns))
            using (StreamWriter sw = new StreamWriter(ns))
            {
                sw.WriteLine("Bienvenido al servidor de hora y fecha! IP : " + ieClient.Address);
                sw.Flush(); // Fuerzo el envío de los datos sin esperar al cierre de la conexión

                string msg = ""; // Creo y defino variable para el mensaje que manda el cliente
                string msgParaElCliente = "";

                // No pongo un while porque el ejercicio requiere que se cierre la conexión después de mandar un comando al servidor
                while (msg != null) // Mientras el mensaje escrito por el cliente no sea null...
                {
                    try
                    {
                        msg = sr.ReadLine();
                        string tipo = msg.Split(':')[0];

                        if (tipo == "HORA")
                        {
                            msgParaElCliente = "El cliente con IP " + ieClient.Address + " ha proporcionado la hora : " + msg.Split(':')[1] + ":" + msg.Split(':')[2] + ":" + msg.Split(':')[3];
                        }
                        else if (tipo == "FECHA")
                        {
                            msgParaElCliente = "El cliente con IP " + ieClient.Address + " ha proporcionado la fecha : " + msg.Split(':')[1];
                        }
                        else if(tipo == "TODO")
                        {
                            msgParaElCliente = "El cliente con IP " + ieClient.Address + " ha proporcionado la hora : " + msg.Split(':')[1] + ":" + msg.Split(':')[2] + ":" + msg.Split(':')[3] + "\nEl cliente con IP " + ieClient.Address + " ha proporcionado la fecha : " + msg.Split(':')[1];
                        }
                        else if(tipo == "APAGAR")
                        {
                            msgParaElCliente = "Cerrando servidor...";
                            Console.WriteLine(msgParaElCliente);
                            s.Close();
                        }

                        Console.WriteLine(msgParaElCliente);
                    }
                    catch (IOException e)
                    {
                        break;
                    }
                }
            }

            Console.ReadLine();
            sClient.Close();
        }
    }
}
