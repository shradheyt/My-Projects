using MyToolkit.Multimedia;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace DigiIndia
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class videopage : Page
    {
        public int counter = 1;

        public videopage()
        {
            this.InitializeComponent();
            title.Text = Bean.videoName;
            desc.Text = Bean.videoDesc;
            playvideo();
        }

        private async void playvideo()
        {

            var url = await YouTube.GetVideoUriAsync(Bean.videoURL, YouTubeQuality.Quality360P);
            player.Source = url.Uri;
            player.Play();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

            if (counter == 2 )//pause condition
            {
                counter = 1;
                player.Play();
            }


        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (counter == 1)//pause condition
            {
                counter = 2;
                player.Pause();
            }
        }
        private void AppBarButton_ClickBack(object sender, RoutedEventArgs e)
        {
            Frame.GoBack();
        }
        
    }
}
