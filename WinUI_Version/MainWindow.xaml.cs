using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System;
using System.IO;
using System.Media;
using Microsoft.UI.Windowing;
using Windows.Storage;

namespace WinUI_Version
{

    public sealed partial class MainWindow : Window
    {
        private AppWindow m_appWindow;
        private readonly string installedPath = Windows.ApplicationModel.Package.Current.InstalledLocation.Path;
        private static readonly string[][] soundMatrix = [
                ["kick","rim","tom","trash"],
                ["clip1","clip2","clip3","clip4"],
                ["clip5","clip6","clip7","crash"],
                ["snare","high_snare","high_snare2","elec1"]
        ];        
        private const string folder = "Assets";

        public MainWindow()
        {
            this.InitializeComponent();
            m_appWindow = GetAppWindowForCurrentWindow();
        }

        /// <summary>
        /// This will create the WinAppSDK window layer that gives you 
        /// access to all the window customization features of the app window.
        /// </summary>
        /// <returns></returns>
        private AppWindow GetAppWindowForCurrentWindow()
        {
            IntPtr hWnd = WinRT.Interop.WindowNative.GetWindowHandle(this);
            Microsoft.UI.WindowId myWndId = Microsoft.UI.Win32Interop.GetWindowIdFromWindow(hWnd);
            return AppWindow.GetFromWindowId(myWndId);
        }

        private void pad_clicked(object sender, RoutedEventArgs e)
        {
            try
            {
                if (sender is not Button btn) throw new Exception("Deu ruim");
                else
                {
                    string choosedSound = $"{soundMatrix[Grid.GetRow(btn)][Grid.GetColumn(btn)]}.wav";
                    var player = new SoundPlayer(Path.Join(installedPath, folder, choosedSound));
                    player.Play();
                }
            }
            catch { /*Ignore*/ }
        }

        private void ToggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            ToggleSwitch toggleSwitch = sender as ToggleSwitch;
            var content = (FrameworkElement)this.Content;

            if (toggleSwitch.IsOn) content.RequestedTheme = ElementTheme.Dark;
            else content.RequestedTheme = ElementTheme.Light;

            ApplicationData.Current.LocalSettings.Values["themeSetting"] = toggleSwitch.IsOn ? 0 : 1;
        }

        private void ToggleSwitch_Loaded(object sender, RoutedEventArgs e)
        {
            if (ApplicationData.Current.LocalSettings.Values.TryGetValue("themeSetting",
                                        out object themeSetting) && (int)themeSetting == 0)
                dark_switch.IsOn = true;

            else dark_switch.IsOn = false;
        }

        private void SwtichPresenter(object sender, RoutedEventArgs e)
        {
            var item = sender as MenuFlyoutItem;
            if (item.Text == "Default")
                m_appWindow.SetPresenter(AppWindowPresenterKind.Default);
            else if (item.Text == "Compact Overlay")
                m_appWindow.SetPresenter(AppWindowPresenterKind.CompactOverlay);
            else if (item.Text == "Full Screen")
                m_appWindow.SetPresenter(AppWindowPresenterKind.FullScreen);
        }
    }
}
