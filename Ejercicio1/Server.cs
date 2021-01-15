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
            IPEndPoint ie = new IPEndPoint(IPAddress.Any, 31416); // Establezco un par IP-Puerto para el server
            Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp); // Establezco el Socket
            s.Bind(ie); // Se enlaza el Socket al IPEndPoint
            s.Listen(5); // Se queda esperando una conexión y se establece la cola a 5


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
                

            }
        }
    }
}
