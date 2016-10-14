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

            Thread.Sleep(500);
            Console.WriteLine($"Type 'help' to show available commands.");
            ConsoleLoop();

            System.Environment.Exit(1);
        }

        private void ConsoleLoop()
        {
            while (true)
            {
                switch (Console.ReadLine()?.ToLower())
                {
                    case "exit":
                        return;
                    case "showusers":
                        showUsers();
                        break;
                    case "help":
                        Console.WriteLine("Commands:");
                        Console.WriteLine("  -exit");
                        Console.WriteLine("  -showusers");
                        Console.WriteLine("  -help");
                        break;
                    default:
                        Console.WriteLine("Command not recognised...");
                        break;
                }
            }
        }

        private void showUsers()
        {
            Console.WriteLine("No users online right now...");
        }
    }
}
