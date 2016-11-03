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
            //ServerConnection server = new ServerConnection(IPAddress.Parse("127.0.0.1"));
            //System.Diagnostics.Debug.WriteLine("register = " + server.register("Camiel2", "abc"));
            //System.Diagnostics.Debug.WriteLine("login = " + server.login("Cas", "Cas"));

            ServerConnection server = new ServerConnection();
            if (server.register("Camiel3", "Camiel3"))
                server.findMatch();
            else
            {
                server.closeStream();
                server = new ServerConnection();
                server.register("Camiel4", "Camiel4");
                server.selectMatch("Camiel3");
            }
            Console.WriteLine("match made "+server.opponentName);



            //List<String> players = server.getOnlineClients();
            //foreach (String s in players)
            //{
            //    System.Diagnostics.Debug.WriteLine("online player = " + s);
            //}
            //while (true)
            //{ }

        }
    }
}
