using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    
    class Server
    {
        List<Client> clients = new List<Client>();
        public Server()
        {
            Console.WriteLine("Server Starting");
            IPAddress localhost = IPAddress.Parse("127.0.0.1");
            Console.WriteLine("ip = " + localhost);
            TcpListener listener = new System.Net.Sockets.TcpListener(localhost, 3000);
            listener.Start();
            while (true)
            {
                Console.WriteLine("waiting for new connection");
                TcpClient connection = listener.AcceptTcpClient();
                Console.WriteLine("Connection found");
                NetworkStream stream = connection.GetStream();
                String msg = readStream(stream);
            }
        }

        private String readStream(NetworkStream stream)
        {
            Byte[] msgLenght = new Byte[4];
            stream.Read(msgLenght, 0, 4);
            int lenght = BitConverter.ToInt32(msgLenght, 0);

            Byte[] msg = new Byte[lenght];
            stream.Read(msg, 0, lenght);
            return Encoding.ASCII.GetString(msg);
        }

        private void writeToStream(NetworkStream stream, String msg)
        {
            Byte[] msgLenght = new Byte[4];
            msgLenght = BitConverter.GetBytes(msg.Length);
            stream.Write 
        }

    }
}
