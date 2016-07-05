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
    public sealed partial class course : Page
    {
        public course()
        {
            this.InitializeComponent();

            //Button btn1 = new Button();
            //btn1.Name = "English";
            //btn1.Content = "English";
            //btn1.Click += CourseSelect;
            //btn1.VerticalAlignment = VerticalAlignment.Top;
            //btn1.HorizontalAlignment = HorizontalAlignment.Left;
            //Thickness t = new Thickness();
            //t.Top = 20.0;
            //t.Left = 20.0;
            //t.Right = 0.0;
            //t.Bottom = 0.0;
            //btn1.Margin = t;

            //Button btn2 = new Button();
            //btn2.Name = "EVS";
            //btn2.Content = "EVS";
            //btn2.Click += CourseSelect;
            //btn2.VerticalAlignment = VerticalAlignment.Top;
            //btn2.HorizontalAlignment = HorizontalAlignment.Left;
            //t.Top = 70.0;
            //t.Left = 20.0;
            //t.Right = 0.0;
            //t.Bottom = 0.0;
            //btn2.Margin = t;

            //Button btn3 = new Button();
            //btn3.Name = "Hindi";
            //btn3.Content = "Hindi";
            //btn3.Click += CourseSelect;
            //btn3.VerticalAlignment = VerticalAlignment.Top;
            //btn3.HorizontalAlignment = HorizontalAlignment.Left;
            //t.Top = 130.0;
            //t.Left = 20.0;
            //t.Right = 0.0;
            //t.Bottom = 0.0;
            //btn3.Margin = t;

            //gridname.Children.Add(btn1);
            //gridname.Children.Add(btn2);
            //gridname.Children.Add(btn3);

        }

        private void CourseSelect(object sender, RoutedEventArgs e)
        {

            String pagename = ((Button)sender).Name;

            Bean.SetCourse(pagename);
            this.Frame.Navigate(typeof(chapter));

        }

        private void AppBarButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.GoBack();
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {


            String pagename = ((Button)sender).Name;

            Bean.SetCourse(pagename);
            this.Frame.Navigate(typeof(chapter));

        }


    }
}
