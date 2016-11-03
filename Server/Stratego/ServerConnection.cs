using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using Newtonsoft.Json;

namespace Stratego
{
    public class ServerConnection
    {
        private IPAddress serverIP = IPAddress.Parse("145.48.118.116");
        NetworkStream stream { get; }
        public string opponentName;
        public bool yourTurn;
        public bool turndone;
        public bool setup = false;
        public bool isRed;
        List<Character> characters;
        Thread ingame;

        public ServerConnection()
        {
            TcpClient tcp = new TcpClient();
            tcp.Connect(serverIP, 3000);
            stream = tcp.GetStream();

        }

        public void closeStream()
        {
            stream.Close();
        }

        public void disconnect()
        {
            writeToStream(stream, "disconnect_");
            readStream(stream);
            stream.Close(100);
        }

        //public void sendBoard(Board board)
        //{
        //    JsonConvert.SerializeObject(board);
        //}

        public void selectMatch(String opponentName)
        {
            writeToStream(stream,"selectmatch_" + opponentName);
            String msg = readStream(stream);
            String[] response = msg.Split('_');
            if (response[0].Equals("matchfound"))
            {
                opponentName = response[1];
            }
            yourTurn = false;
            isRed = true;
            ingame = new Thread(play);
            ingame.Start();
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
            yourTurn = true;
            isRed = false;
            ingame = new Thread(play);
            ingame.Start();
        }

        public void play()
        {
            bool gaming = true;
            bool firstTime = true;
            turndone = false;
            while (gaming)
            {
                if (!setup)
                {
                    if (turndone && !isRed)
                    {
                        writeToStream(stream, "setupgame_" + JsonConvert.SerializeObject(characters));
                        characters = (List<Character>)JsonConvert.DeserializeObject(readStream(stream));
                        setup = true;
                        turndone = false;
                    }
                    else if (turndone && isRed)
                    {
                        writeToStream(stream, "setupgame2_" + JsonConvert.SerializeObject(characters));
                        characters = (List<Character>)JsonConvert.DeserializeObject(readStream(stream));
                        setup = true;
                        turndone = true;
                    }
                }
                else
                {

                }
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
            {
                System.Diagnostics.Debug.Write("registered");
                return true;
            }
            else if (response[0].Equals("register") && response[1].Equals("false"))
            {
                System.Diagnostics.Debug.Write("register failed");
                return false;
            }

            return false;
        }

        public bool login(String name, String password)
        {
            writeToStream(stream, "login_" + name + "-" + password);
            String totalResponse = readStream(stream);
            String[] response = totalResponse.Split('_');
            if (response[0].Equals("login") && response[1].Equals("true"))
            {
                System.Diagnostics.Debug.Write("logged failed");
                return true;
            }
            else if (response[0].Equals("login") && response[1].Equals("false"))
            {
                System.Diagnostics.Debug.Write("login succeded");
                return false;
            }

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
