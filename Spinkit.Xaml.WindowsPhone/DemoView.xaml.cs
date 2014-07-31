using System;
using Windows.System;
using Windows.UI.Xaml;

namespace Spinkit.Xaml
{
    public sealed partial class DemoView
    {
        public DemoView()
        {
            InitializeComponent();
        }

        private async void OnViewSource(object sender, RoutedEventArgs e)
        {
            await Launcher.LaunchUriAsync(new Uri("https://github.com/nigel-sampson/spinkit-xaml"));
        }

        private async void OnViewCreated(object sender, RoutedEventArgs e)
        {
            await Launcher.LaunchUriAsync(new Uri("https://twitter.com/nigelsampson"));
        }

        private async void OnViewInspired(object sender, RoutedEventArgs e)
        {
            await Launcher.LaunchUriAsync(new Uri("https://twitter.com/tobiasahlin"));
        }
    }
}
