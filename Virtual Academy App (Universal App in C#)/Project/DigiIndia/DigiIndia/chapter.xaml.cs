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
    public sealed partial class chapter : Page
    {
        List<Chapter> ChapterResult;
        public chapter()
        {
            this.InitializeComponent();
            

        }

        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            HttpClient client = new HttpClient();

            var response = await client.GetStringAsync(new Uri("http://localhost:49339/api/Chapters"));
            ChapterResult = JsonConvert.DeserializeObject<List<Chapter>>(response);
            chapterList.ItemsSource = ChapterResult;
        }

        private void AppBarButton_Click(object o,RoutedEventArgs e)
        {
            int index = chapterList.SelectedIndex;
            Chapter ch = ChapterResult.ElementAt(index);
            Bean.chapterName = ch.ChapterName;
            Bean.chapterCode = ch.ChapCode;
            Frame.Navigate(typeof(videooption));
        }

        private void AppBarButton_ClickBack(object o,RoutedEventArgs e)
        {
            Frame.GoBack();
        }
    }
}
