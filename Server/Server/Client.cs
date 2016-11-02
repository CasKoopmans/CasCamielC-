using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class Client
    {
        String name { get; }
        NetworkStream stream { get; }
        public Client(String name, NetworkStream stream)
        {
            this.name = name;
            this.stream = stream;
        }
    }
}
