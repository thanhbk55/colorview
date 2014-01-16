using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Threading.Tasks;

namespace View_Color
{
    public partial class SpalshScreen : PhoneApplicationPage
    {
        public SpalshScreen()
        {
            InitializeComponent();
            Spalsh_Screen();
        }

        async void Spalsh_Screen()
        {
            await Task.Delay(TimeSpan.FromSeconds(3));
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
        }
    }
}