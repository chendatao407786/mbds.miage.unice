using mbds.miage.unice.src.util;
using System.Windows.Shell;
using mbds.miage.unice.ViewModels;
using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace mbds.miage.unice
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new WindowViewModel(this);
        }

        //protected override void OnSourceInitialized(EventArgs e)
        //{
        //    IconHelper.RemoveIcon(this);
        //}

        //private void TxtUserEntry_TextChanged(object sender, TextChangedEventArgs e)
        //{

        //}

        //private void OnPasswordChange(object sender, EventArgs e)
        //{
        //}
    }
}
