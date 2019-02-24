using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mbds.miage.unice.model
{
    class Connection
    {
        private string _username;
        private string _password;
        public Connection(string username,string password)
        {
            this.username = username;
            this.password = password;
        }

        public string username { get => _username; set => _username = value; }
        public string password { get => _password; set => _password = value; }
    }
}
