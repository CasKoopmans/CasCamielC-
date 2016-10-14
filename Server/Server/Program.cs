using Server.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            var program = new Program();
        }

        private TcpServer _tcpServer;

        public Program()
        {
            _tcpServer = new TcpServer();

            var serverThread = new Thread(_tcpServer.Run);
            serverThread.Start();
        }
    }
}
