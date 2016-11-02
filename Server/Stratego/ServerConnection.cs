using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Stratego
{
    class ServerConnection
    {
        NetworkStream stream { get; }
        public string opponentName;
        public ServerConnection(IPAddress serverIP)
        {
            TcpClient tcp = new TcpClient();
            tcp.Connect(serverIP, 3000);
            stream = tcp.GetStream();

        }

        public void selectMatch(String opponentName)
        {
            writeToStream(stream,"selectmatch_" + opponentName);
            String msg = readStream(stream);
            String[] response = msg.Split('_');
            if (response[0].Equals("matchfound"))
            {
                opponentName = response[1];
            }

        }

        public void findMatch()
        {
            writeToStream(stream, "findmatch_");
            String msg = readStream(stream);
            String[] response = msg.Split('_');
            if (response[0].Equals("matchfound"))
            {
                opponentName = response[1];
            }
        }

        public List<String> getSearchingClients()
        {
            List<String> searchingClients = new List<String>();
            bool done = false;
            writeToStream(stream, "getsearchingclients_");
            while (!done)
            {
                String msg = readStream(stream);
                switch (msg)
                {
                    case "getsearchingclientsdone": done = true; break;
                    default: searchingClients.Add(msg); break;
                }
            }
            return searchingClients;
        }

        public List<String> getOnlineClients()
        {
            List<String> onlineClients = new List<String>();
            bool done = false;
            writeToStream(stream, "getonlineclients_");
            while (!done)
            {
                String msg = readStream(stream);
                switch (msg)
                {
                    case "getonlineclientsdone":done = true;break;
                    default: onlineClients.Add(msg);break;
                }
            }
            return onlineClients;
        }

        public bool register(String name, String password)
        {
            writeToStream(stream, "register_" + name + "-" + password);
            String totalResponse = readStream(stream);
            String[] response = totalResponse.Split('_');
            if (response[0].Equals("register") && response[1].Equals("true"))
                return true;
            else if (response[0].Equals("register") && response[1].Equals("false"))
                return false;

            return false;
        }

        public bool login(String name, String password)
        {
            writeToStream(stream, "login_" + name + "-" + password);
            String totalResponse = readStream(stream);
            String[] response = totalResponse.Split('_');
            if (response[0].Equals("login") && response[1].Equals("true"))
                return true;
            else if (response[0].Equals("login") && response[1].Equals("false"))
                return false;

            return false;
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
