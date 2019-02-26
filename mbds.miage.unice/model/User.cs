using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mbds.miage.unice.model
{
    class User
    {
        private string _name;
        private string _id;
        private string _srcImage;
        public User(string name, string id, string srcImage)
        {
            _name = name;
            _id = id;
            _srcImage = srcImage;
        }
        public string Name { get => _name; set => _name = value; }
        public string Id { get => _id; set => _id = value; }
        public string SrcImage { get => _srcImage; set => _srcImage = value; }
    }
}
