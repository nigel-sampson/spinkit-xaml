using System;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Activation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Spinkit.Xaml
{
    public sealed partial class App
    {
        public App()
        {
            InitializeComponent();
        }

        protected override void OnLaunched(LaunchActivatedEventArgs e)
        {
            var frame = Window.Current.Content as Frame;

            if (frame == null)
            {
                frame = new Frame
                {
                    Language = Windows.Globalization.ApplicationLanguages.Languages[0]
                };

                Window.Current.Content = frame;
            }

            if (frame.Content == null)
            {
                frame.Navigate(typeof (DemoView));
            }

            Window.Current.Activate();
        }
    }
}
