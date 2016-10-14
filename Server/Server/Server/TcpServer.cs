using System;
using System.Net;
using System.Net.Sockets;

namespace Server.Server
{
    class TcpServer
    {
        private readonly TcpListener _tcpListener;
        public IPAddress IpAddress { get; set; }

        public TcpServer()
        {
            IpAddress = GetLocalIpAddress();
            _tcpListener = new TcpListener(IpAddress, 6969);
            Console.WriteLine("IpAddress: {0}", IpAddress);
        }

        public void Run()
        {
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
