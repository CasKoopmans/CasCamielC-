﻿using System;
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
                    case "login": login(messages[1],stream);break;
                    case "register": register(messages[1],stream);break;
                    default: break;
                }
            }
        }

        private bool login(String loginInfo,NetworkStream stream)
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
                    new Client(name, stream);                    
                    return true;
                }
            }
            sr.Close();
            writeToStream(stream, "login_false");
            return false;
        }

        private bool register(String registerInfo,NetworkStream stream)
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
                    writeToStream(stream, "register_false");
                    sr.Close();
                    return false;
                }
            }
            sr.Close();

            StreamWriter sw = new StreamWriter("login.txt",true);
            sw.WriteLine(registerInfo);
            sw.Close();
            writeToStream(stream, "register_true");
            new Client(name, stream);
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
            stream.Write(msgLenght,0,4);

            Byte[] finalMsg = new Byte[msg.Length];
            finalMsg = Encoding.ASCII.GetBytes(msg);
            stream.Write(finalMsg, 0, msg.Length);
        }

    }
}
