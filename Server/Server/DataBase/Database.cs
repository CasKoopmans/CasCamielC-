using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.DataBase
{
    class Database
    {
        public List<Client> Clients { get; set; }

        public Database()
        {
            Clients = new List<Client>();
        }

        public void AddClient(Client client)
        {
            var alreadyThere = Enumerable.Contains(Clients, client);
            Console.WriteLine($"Adding client: {!alreadyThere}");
            if (!alreadyThere) Clients.Add(client);
        }


        public Client GetClientByName(string name)
        {
            foreach (var client in Clients)
            {
                if (!client.Name.Equals(name)) continue;
                return client;
            }
            return null;
        }

        #region saving and loading clients

        public void SaveClients(string filePath)
        {
            
        }

        public void LoadClients(string filePath)
        {
            
        }

        #endregion
    }
}
