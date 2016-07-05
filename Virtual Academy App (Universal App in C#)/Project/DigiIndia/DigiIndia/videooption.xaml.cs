using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
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
    public sealed partial class videooption : Page
    {
        List<VideoData> VideoDataResult;
        List<VideoData> vid;
        public videooption()
        {
            this.InitializeComponent();

        }

        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            HttpClient client = new HttpClient();

            var response = await client.GetStringAsync(new Uri("http://localhost:49339/api/VideoDatas"));
            VideoDataResult = JsonConvert.DeserializeObject<List<VideoData>>(response);
            vid = new List<VideoData>();

            for(int i = 0; i < VideoDataResult.Count; i++)
            {
                VideoData ch = VideoDataResult.ElementAt(i);
                if ((Bean.chapterCode).Equals(ch.ChapCode))
                {
                    vid.Add(ch);
                }
            }

            videoList.ItemsSource = vid;
        }

        private void AppBarButton_Click(object o, RoutedEventArgs e)
        {
            int index = videoList.SelectedIndex;
            VideoData ch = vid.ElementAt(index);
            Bean.videoURL = ch.videoURL;
            Bean.videoName = ch.videoName;
            Bean.videoDesc = ch.videoDesc;
            Bean.videoTutor = ch.videoTutor;
            Frame.Navigate(typeof(videopage));
        }

        private void AppBarButton_ClickBack(object o, RoutedEventArgs e)
        {
            Frame.GoBack();
        }
    }
}
