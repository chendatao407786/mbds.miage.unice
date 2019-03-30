using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mbds.miage.unice.model
{
    class Message
    {
        private string _id;
        private string _msg;
        private string _from;
        private string _to;
        private DateTime _dateMsg;

        public Message(string id, string msg, string from, string to, DateTime dateMsg)
        {
            _id = id;
            _msg = msg;
            _from = from;
            _to = to;
            _dateMsg = dateMsg;
        }

        public string Id { get => _id; set => _id = value; }
        public string Msg { get => _msg; set => _msg = value; }
        public string From { get => _from; set => _from = value; }
        public string To { get => _to; set => _to = value; }
        public string DateMsg { get => _dateMsg; set => _dateMsg = value; }
    }
}