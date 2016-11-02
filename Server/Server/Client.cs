using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server
{
    class Client
    {
        public String name { get; }
        public bool findingMatch { set; get; }
        NetworkStream stream { get; }
        NetworkStream opponentStream { get; set; }
        Server server { get; }
        public Client(String name, NetworkStream stream,Server server)
        {
            this.name = name;
            this.stream = stream;
            this.server = server;
            Thread listenThread = new Thread(listen);
            listenThread.Start();
        }

        public void listen()
        {
            while (true)
            {
                String msg = readStream(stream);
                String[] command = msg.Split('_');
                switch (command[0])
                {
                    case "getonlineclients":
                        {
                            List<String> onlineClients = server.getOnlineClients();
                            //onlineClients.Remove(name);  //test purpuse
                            foreach (String s in onlineClients)
                            {
                                writeToStream(stream, s);
                            }
                            writeToStream(stream, "getonlineclientsdone");
                        }
                        break;
                    case "findmatch":
                        {
                            findingMatch = true;
                        }
                        break;
                    case "getsearchingclients":
                        {
                            List<String> searchingClients = server.getSearchingClients();
                            foreach (String s in searchingClients)
                            {
                                writeToStream(stream, s);
                            }
                            writeToStream(stream, "getsearchingclientsdone");
                        }
                        break;
                }   
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
            stream.Write(msgLenght, 0, 4);

            Byte[] finalMsg = new Byte[msg.Length];
            finalMsg = Encoding.ASCII.GetBytes(msg);
            stream.Write(finalMsg, 0, msg.Length);
        }

    }
}
