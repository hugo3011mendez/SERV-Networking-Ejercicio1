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
                sw.WriteLine("Bienvenido al servidor de hora y fecha!");
                sw.Flush(); // Fuerzo el envío de los datos sin esperar al cierre de la conexión

                string msg = ""; // Creo y defino variable para el mensaje que manda el cliente
                // No pongo un while porque el ejercicio requiere que se cierre la conexión después de mandar un comando al servidor
                if (msg != null) // Si el mensaje escrito por el cliente no es null...
                {
                    string tipo = msg.Split(':')[0];

                    if (tipo == "HORA")
                    {
                        int hora = Convert.ToInt32(msg.Split(':')[1]);
                        int minuto = Convert.ToInt32(msg.Split(':')[2]);
                        int segundo = Convert.ToInt32(msg.Split(':')[3]);
                    }
                    else if (tipo == "FECHA")
                    {
                        int dia = Convert.ToInt32(msg.Split(':')[1]);
                        int mes = Convert.ToInt32(msg.Split(':')[2]);
                        int anho = Convert.ToInt32(msg.Split(':')[3]);
                    }
                    else if(tipo == "TODO")
                    {
                        int dia = Convert.ToInt32(msg.Split(':')[1]);
                        int mes = Convert.ToInt32(msg.Split(':')[2]);
                        int anho = Convert.ToInt32(msg.Split(':')[3]);
                        int hora = Convert.ToInt32(msg.Split(':')[4]);
                        int minuto = Convert.ToInt32(msg.Split(':')[5]);
                        int segundo = Convert.ToInt32(msg.Split(':')[6]);

                    }
                    else if(tipo == "APAGAR")
                    {
                        Console.WriteLine("Cerrando servidor...");
                    }
                }

                sClient.Close();
                Console.ReadLine();
                s.Close();
            }
        }
    }
}
