using mbds.miage.unice.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Input;

namespace mbds.miage.unice.ViewModels
{
    public class WindowViewModel : BaseViewModel
    {
        private Window mWindow;
        private int mOuterMarginSize = 5;
        private int mWindowRadius = 3;
        public int ResizeBorder { get; set; } = 6;
        public Thickness ResizeBorderThickness { get => new Thickness(ResizeBorder + OuterMarginSize); }
        public int OuterMarginSize { get => mWindow.WindowState == WindowState.Maximized ? 0 : mOuterMarginSize; set => mOuterMarginSize = value; }
        public Thickness OuterMarginSizeThickness { get => new Thickness(ResizeBorder); }
        public int WindowRadius { get => mWindow.WindowState == WindowState.Maximized ? 0 : mWindowRadius; set => mWindowRadius = value; }
        public CornerRadius WindowCornerRadius { get => new CornerRadius(WindowRadius); }
        public int TittleHeight { get; set; } = 20;
        public ICommand MinimizeCommand { get; set; }
        public ICommand CloseCommand { get; set; }
        public ICommand DropDown { get; set; }
        public Popup MyPopup { get; set; }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MyPopup.PlacementTarget = sender as UIElement;
            MyPopup.Placement = PlacementMode.Bottom;
            MyPopup.AllowsTransparency = true;
            MyPopup.PopupAnimation = PopupAnimation.Fade;
            if (MyPopup.IsOpen == false)
            {
                MyPopup.IsOpen = true;
            }
            else
            {
                MyPopup.IsOpen = false;
            }
            
           
        }
        public WindowViewModel(Window window)
        {
            mWindow = window;
            mWindow.StateChanged += (sender, e) =>
            {
                OnPropertyChanged(nameof(ResizeBorderThickness));
                OnPropertyChanged(nameof(OuterMarginSize));
                OnPropertyChanged(nameof(OuterMarginSizeThickness));
                OnPropertyChanged(nameof(WindowRadius));
                OnPropertyChanged(nameof(WindowCornerRadius));
            };
            //DropDown = new RelayCommand(() =>
            //{
                
            //});
            MinimizeCommand = new RelayCommand(() => mWindow.WindowState = WindowState.Minimized);
            CloseCommand = new RelayCommand(() => mWindow.Close());
        }
    }
}
