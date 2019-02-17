using mbds.miage.unice.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

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
        public int TitleHeight { get; set; } = 20;
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
        }
    }
}
