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
using System.Windows.Controls.Primitives;

namespace mbds.miage.unice
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool _isOpened = false;
        public MainWindow()
        {
            this.DataContext = new WindowViewModel(this);
            InitializeComponent();
        }

        public bool IsOpened { get => _isOpened; set => _isOpened = value; }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Popup MyPopup = Login.Template.FindName("MyPopup", Login) as Popup;
            if (MyPopup.IsOpen == false)
            {
                MyPopup.Placement = PlacementMode.Bottom;
                MyPopup.AllowsTransparency = true;
                MyPopup.PopupAnimation = PopupAnimation.Fade;
                //MyPopup.IsOpen = true;
                IsOpened = true;
            }
            else
            {
                Console.WriteLine("Close");
                //MyPopup.IsOpen = false;
                IsOpened = false;
            }


        }

        //public Popup MyPopup { get; private set; }

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    if(MyPopup.IsOpen == false)
        //    {
        //        MyPopup.PlacementTarget = sender as UIElement;
        //        MyPopup.Placement = PlacementMode.Right;
        //        MyPopup.AllowsTransparency = true;
        //        MyPopup.PopupAnimation = PopupAnimation.Fade;
        //        MyPopup.IsOpen = true;
        //    }else if(MyPopup.IsOpen == true)
        //    {
        //        MyPopup.IsOpen = false;
        //    }


        //}

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
