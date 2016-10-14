using Server.DataBase;
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace Server.Server
{
    class TcpServer
    {
        private readonly TcpListener serverSocket;
        public IPAddress IpAddress { get; set; }
        public bool done = false;
        public readonly Database DataBase = new Database();

        public TcpServer()
        {
            IpAddress = GetLocalIpAddress();
            serverSocket = new TcpListener(IpAddress, 6969);
            Console.WriteLine("IpAddress: {0}", IpAddress);
        }

        public void Run()
        {
            Console.WriteLine("Starting server...");
            serverSocket.Start();
            Console.WriteLine("Server started");
        }

        public static IPAddress GetLocalIpAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                    return ip;
            throw new Exception("Local IP Address Not Found!");
        }
    }
}
