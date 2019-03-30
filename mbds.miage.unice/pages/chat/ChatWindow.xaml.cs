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
            User user2 = new User("Serina", "serina.li", "http://192.168.0.10:8888/tpgrails/images/30704260_10215948242607669_7236327905523141774_n.jpg");
            User user3 = new User("thiaw", "thiaw", "http://192.168.0.10:8888/tpgrails/images/me.png");

            userList.Add(user1);
            userList.Add(user2);
            userList.Add(user3);
            InitializeComponent();
            Loaded += (s, e) => Keyboard.Focus(Sent);
        }

    }
}
