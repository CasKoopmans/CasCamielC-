using System;
using System.Collections.Generic;
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
    }
}
