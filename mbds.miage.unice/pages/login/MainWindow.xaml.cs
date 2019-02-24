using mbds.miage.unice.ViewModels;
using System.Net.Http;
using System.Windows;

namespace mbds.miage.unice
{
    public partial class MainWindow : Window
    {
        private static readonly HttpClient client = new HttpClient();
        public MainWindow()
        {
            this.DataContext = new WindowViewModel(this);
            InitializeComponent();
        }
    }
}
