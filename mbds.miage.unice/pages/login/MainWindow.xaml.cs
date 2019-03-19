using mbds.miage.unice.ViewModels;
using System.Diagnostics;
using System.Net.Http;
using System.Windows;
using System.Windows.Navigation;

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
        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri));
            e.Handled = true;
        }
    }
}
