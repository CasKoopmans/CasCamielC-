﻿using Newtonsoft.Json;
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
        bool charactersUpdated = false;
        NetworkStream stream { get; }
        Client opponent { get; set; }
        bool ingame = false;
        bool setup = false;
        Server server { get; }
        String characters =null;
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
            bool disconnect = false;
            while (!disconnect)
            {
                    String msg = readStream(stream);
                    String[] command = msg.Split('_');
                    Console.WriteLine(name + " send : " + command[0]);
                    switch (command[0])
                    {
                        case "disconnect":
                            {
                                writeToStream(stream, "OK");
                                server.removeClient(name);
                                disconnect = true;
                            }
                            break;
                        case "selectmatch":
                            {
                                opponent = server.getClient(command[1]);
                                opponent.opponent = this;
                                writeToStream(stream, "matchfound_" + opponent.name);
                            }
                            break;
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
                                while (opponent == null)
                                { }
                                findingMatch = false;
                                writeToStream(stream, "matchfound_" + opponent.name);

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
                        case "setupgame":
                            {
                                 characters = command[1];
                                 while (!opponent.setupIsDone())
                                 {
                                    Thread.Sleep(100);
                                 }
                                writeToStream(stream, characters);
                            }
                            break;
                        case "setupgame2":
                            {
                                characters = command[1];
                                while (opponent.characters == null)
                                { }
                                combineCharacters();
                                setup = true;
                                writeToStream(stream, characters);
                        }
                             break;

                        case "gameturn":
                            {
                                characters = command[1];
                                opponent.characters = characters;
                                opponent.sendCharacters();
                                
                            }
                        break;
                        default: Console.WriteLine("invalid command " + command[0] + " by " + name); break;
                }
            }
        }

        public bool setupIsDone()
        {
            return setup;
        }

        public void sendCharacters()
        {
            writeToStream(stream, characters);
        }

        private void combineCharacters()
        {
            List<Character> ownCharacters = (List<Character>)JsonConvert.DeserializeObject<List<Character>>(characters);
            List<Character> enemyCharacters = (List<Character>)JsonConvert.DeserializeObject<List<Character>>(opponent.characters);
            ownCharacters.AddRange(enemyCharacters);
            characters = JsonConvert.SerializeObject(ownCharacters);
            opponent.characters = characters;
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
