using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Stratego
{
    class Test
    {
        public Test()
        {
            ServerConnection server = new ServerConnection(IPAddress.Parse("127.0.0.1"));
            server.register("Camiel2", "abc");
            while (true)
            { }

        }
    }
}
