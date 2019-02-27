using mbds.miage.unice.model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace mbds.miage.unice.pages.chat
{
    public partial class ChatWindow : Window
    {
        ObservableCollection<User> userList = new ObservableCollection<User>();
        public ObservableCollection<User> UserList { get => userList; set => userList = value; }

        public ChatWindow()
        {
            this.DataContext = this;
            User user1 = new User("Datao", "chendatao1126", "http://192.168.0.10:8888/tpgrails/images/chen.jpg");
            userList.Add(user1);
            InitializeComponent();
            Loaded += (s, e) => Keyboard.Focus(Sent);
        }

    }
    public class User
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
