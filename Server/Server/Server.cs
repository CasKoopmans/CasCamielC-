using System;
using System.Collections.Generic;
using System.IO;
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
                String[] messages = msg.Split('_');
                switch (messages[0])
                {
                    case "login": login(messages[1], stream); break;
                    case "register": register(messages[1], stream); break;
                    default: break;
                }
            }
        }

        public void removeClient(String name)
        {
            foreach (Client c in clients)
            {
                if (c.name.Equals(name))
                {
                    clients.Remove(c);
                    Console.WriteLine(name +" disconnected");
                    break;
                }

            }
        }

        public Client getClient(String name)
        {
            foreach (Client c in clients)
            {
                if (c.name.Equals(name))
                    return c;
            }
            return null;
        }

        public List<String> getSearchingClients()
        {
            List<String> searchingClients = new List<String>();
            foreach (Client c in clients)
            {
                if (c.findingMatch)
                {
                    searchingClients.Add(c.name);
                }
            }
                return searchingClients;
        }

        public List<String> getOnlineClients()
        {
            List<String> onlineClients = new List<String>();
            foreach (Client c in clients)
            {
                onlineClients.Add(c.name);
            }
            return onlineClients;
        }

        private bool login(String loginInfo, NetworkStream stream)
        {
            String[] namePassword = loginInfo.Split('-');
            String name = namePassword[0];
            String password = namePassword[1];

            StreamReader sr = new StreamReader("login.txt");
            while (sr.Peek() > 0)
            {
                if (sr.ReadLine().Equals(loginInfo))
                {
                    writeToStream(stream, "login_true");
                    sr.Close();
                    sr.Dispose();
                    clients.Add(new Client(name, stream,this));
                    Console.WriteLine(name + " logged in");
                    return true;
                }
            }
            sr.Close();
            sr.Dispose();
            writeToStream(stream, "login_false");
            Console.WriteLine("couldn't find user "+name);
            return false;
        }

        private bool register(String registerInfo, NetworkStream stream)
        {
            String[] namePassword = registerInfo.Split('-');
            String name = namePassword[0];
            String password = namePassword[1];

            StreamReader sr = new StreamReader("login.txt");
            while (sr.Peek() > 0)
            {
                String otherName = sr.ReadLine().Split('-')[0];
                if (otherName.Equals(name))
                {
                    Console.WriteLine("registername already exist = "+name);
                    sr.Close();
                    sr.Dispose();
                    return false;
                }
            }
            sr.Close();
            sr.Dispose();
            StreamWriter sw = new StreamWriter("login.txt", true);
            sw.WriteLine(registerInfo);
            sw.Close();
            writeToStream(stream, "register_true");
            clients.Add(new Client(name, stream,this));
            Console.WriteLine(name+" registered");
            return true;
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
            stream.Write(msgLenght, 0, 4);

            Byte[] finalMsg = new Byte[msg.Length];
            finalMsg = Encoding.ASCII.GetBytes(msg);
            stream.Write(finalMsg, 0, msg.Length);
        }

    }
}
