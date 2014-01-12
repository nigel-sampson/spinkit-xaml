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
    }
}
