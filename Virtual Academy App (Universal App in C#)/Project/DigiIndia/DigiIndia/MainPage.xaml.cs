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
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            //Button btn1 = new Button();
            //btn1.Content = "Class 1";
            //btn1.Click += ClassSelect;
            //btn1.Name = "class1";
            //btn1.VerticalAlignment = VerticalAlignment.Top;
            //btn1.HorizontalAlignment = HorizontalAlignment.Left;
            //Thickness t = new Thickness();
            //t.Top = 10.0;
            //t.Left = 20.0;
            //t.Right = 0.0;
            //t.Bottom = 0.0;
            //btn1.Margin = t;

            //Button btn2 = new Button();
            //btn2.Content = "Class 2";
            //btn2.Click += ClassSelect;
            //btn2.Name = "class2";
            //t.Top = 70.0;
            //t.Left = 20.0;
            //t.Right = 0.0;
            //t.Bottom = 0.0;
            //btn2.Margin = t;

            //gridname.Children.Add(btn1);
            //gridname.Children.Add(btn2);
        }

        private void ClassSelect(object sender, RoutedEventArgs e)
        {

            String pagename = ((Button)sender).Name;

            Bean.SetClassel(pagename);
            this.Frame.Navigate(typeof(course));

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {

        }
        private void btn1_Click(object sender, RoutedEventArgs e)
        {

            String pagename = ((Button)sender).Name;

            Bean.SetClassel(pagename);
            this.Frame.Navigate(typeof(course));

        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            String pagename = ((Button)sender).Name;

            Bean.SetClassel(pagename);
            this.Frame.Navigate(typeof(course));

        }
    }
}
