using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.DataBase
{
    class Client
    {
        public string Name { get; set; }
        public string Passsword { get; set; }
        public string TunnelId { get; set; }
        public int UniqueId { get; set; }
        bool IsOnline { get; set; }
        protected Status ClientStatus { get; set; }

        public Client(string name, string password, string tunnelId, int uniqueId, bool isOnline)
        {
            Name = name;
            Passsword = password;
            TunnelId = tunnelId;
            IsOnline = isOnline;
            UniqueId = uniqueId == 0 ? GetUniqueId(name, password) : uniqueId;
            ClientStatus = Status.CONNECTED;
        }

        protected Status GetStatus()
        {
            return ClientStatus;
        }

        protected void SetStatus(Status newStatus)
        {
            ClientStatus = newStatus;
        }

        public override string ToString()
        {
            return $"Client: {Name}, Id: {UniqueId}";
        }

        public static int GetUniqueId(string username, string password)
        {
            if ((username == null) && (password == null)) return 0;
            var nameV = GetStringInNumbers(username);
            var passwordV = GetStringInNumbers(password);

            return (nameV * 397) ^ passwordV;
        }

        public static int GetStringInNumbers(string text)
        {
            var nameArray = text.ToCharArray();
            return nameArray.Sum(c => (int)c % 32);
        }

        protected enum Status
        {
            NOT_CONNECTED,
            CONNECTED,
            READY_TO_GO,
            BIKING,
            FINISHED
        }
    }
}
