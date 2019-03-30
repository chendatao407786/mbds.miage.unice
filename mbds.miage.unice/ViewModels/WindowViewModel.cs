using mbds.miage.unice.model;
using mbds.miage.unice.pages.chat;
using mbds.miage.unice.pages.test;
using mbds.miage.unice.ViewModels.Base;
using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Media;

namespace mbds.miage.unice.ViewModels
{
    public class WindowViewModel : BaseViewModel
    {
        private Window mWindow;
        private int mOuterMarginSize = 5;
        private int mWindowRadius = 3;
        private bool isPopupOpen = false;
        //private string url = "http://192.168.0.11:8080/api/auth";
        private string url = "http://39.108.185.199:8080/api/auth";
        private string _response = "";
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
        public ICommand Connect { get; set; }
        public ICommand Hyperlink_RequestNavigate { get; set; }

        public string Response { get => _response; set { _response = value; OnPropertyChanged(nameof(Response)); }}

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

            DropDown = new RelayCommand(() =>
            {
                Popup MyPopup = mWindow.Template.FindName("MyPopup", mWindow) as Popup;
                Window zone = mWindow;
                MyPopup.PlacementTarget = zone;
                MyPopup.Placement = PlacementMode.Relative;
                MyPopup.VerticalOffset = 350 - 10 - 5;
                MyPopup.AllowsTransparency = true;
                MyPopup.PopupAnimation = PopupAnimation.Slide;
                if (isPopupOpen == false)
                {
                    MyPopup.IsOpen = true;
                    isPopupOpen = true;
                }
                else
                {
                    isPopupOpen = false;
                    MyPopup.IsOpen = false;
                }
            });
            MinimizeCommand = new RelayCommand(() => mWindow.WindowState = WindowState.Minimized);
            CloseCommand = new RelayCommand(() => mWindow.Close());
            //Hyperlink_RequestNavigate = new RelayCommand(() =>
            //{
            //    Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri));
            //    e.Handled = true;
            //});

            Connect = new RelayCommand(() =>
            {
                TextBox username = mWindow.Template.FindName("username", mWindow) as TextBox;
                PasswordBox passwordBox = mWindow.Template.FindName("password", mWindow) as PasswordBox;
                Connection connection = new Connection(username.Text, passwordBox.Password);
                string json = JsonConvert.SerializeObject(connection);

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.KeepAlive = false;
                request.Method = "POST";
                request.ContentType = "application/json";
                request.Accept = "application/json";
                
                TextBlock message = mWindow.Template.FindName("message", mWindow) as TextBlock;
                try
                {
                    Stream requestStream = request.GetRequestStream();
                    StreamWriter streamWriter = new StreamWriter(requestStream);
                    streamWriter.Write(json);
                    streamWriter.Flush();
                    requestStream.Close();
                    HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                    message.Foreground = new SolidColorBrush(Colors.Green);
                    Response = "Connection successfully";
                    ChatWindow chatWindow = new ChatWindow();
                    chatWindow.Show();
                    //Test test = new Test();
                    //test.Show();
                    mWindow.Close();
                }
                catch(WebException e)
                {
                    message.Foreground = new SolidColorBrush(Colors.Red);
                    HttpWebResponse response = (HttpWebResponse)e.Response;
                    if (response == null)
                    {
                        Response = "Server is not online";
                        return;
                    }
                    Console.WriteLine(response.StatusCode);
                    switch (response.StatusCode)
                    {
                        case HttpStatusCode.Unauthorized:
                            Response = "Unauthorized";
                            break;
                        default:
                            Response = "Error";
                            break;
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine(e);
                }
            });
        }
    }
}
