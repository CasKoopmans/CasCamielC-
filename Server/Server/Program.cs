using Server.DataBase;
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
                    case "deleteuser":
                        DeleteUser();
                        break;
                    case "help":
                        Console.WriteLine("Commands:");
                        Console.WriteLine("  -exit");
                        Console.WriteLine("  -showUsers");
                        Console.WriteLine("  -deleteUser");
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
            foreach (var client in _tcpServer.DataBase.Clients)
            {
                Console.WriteLine(client);
            }
        }

        private void DeleteUser()
        {
            Console.WriteLine("Enter a name of user u want to delete: ");
            var name = Console.ReadLine();

            Console.WriteLine("Deleting user...");
            if (_tcpServer.DataBase.Clients.Remove(_tcpServer.DataBase.GetClientByName(name)))
            {
                Console.WriteLine("Done!");
            }
            else
            {
                Console.WriteLine("ERROR: THIS USER DOESN'T EXIST");
            }
        }
    }
}
