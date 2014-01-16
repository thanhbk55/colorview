using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Windows.Media;
using System.Text.RegularExpressions;

namespace View_Color
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Set the data context of the listbox control to the sample data
           
        }

        // Load data for the ViewModel Items
        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            if (!App.ViewModel.IsDataLoaded)
            {
                App.ViewModel.LoadData();
            }
            if (NavigationService.BackStack.Count() == 1)
            {
                NavigationService.RemoveBackEntry();
            }

        }

        private void enter_color(object sender, System.Windows.Input.GestureEventArgs e)
        {
            RootPanorama.DefaultItem = RootPanorama.Items[1];
        }
        private void select_color(object sender, System.Windows.Input.GestureEventArgs e)
        {
            RootPanorama.DefaultItem = RootPanorama.Items[2];
        }
        private void help(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Help.xaml", UriKind.Relative));
        }
        private void about(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/About.xaml", UriKind.Relative));
        }

        private void setting(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/Setting.xaml", UriKind.Relative));
        }
        private void Ok_Click(object sender, RoutedEventArgs e)
        {
            if (Color_R.Text != "R:" && Color_G.Text != "G:" && Color_B.Text != "B:"
                && Color_R.Text != "" && Color_G.Text != "" && Color_B.Text != "")
            {
                string rtex = Color_R.Text;
                string gtex = Color_G.Text;
                string btex = Color_B.Text;
                Color_R.Text = "R:";
                Color_G.Text = "G:";
                Color_B.Text = "B:";
                rtex = rtex.Replace("R:", "");
                gtex = gtex.Replace("G:", "");
                btex = btex.Replace("B:", "");
                byte r = byte.Parse(rtex);
                byte g = byte.Parse(gtex);
                byte b = byte.Parse(btex);
                if (r >= 0 && r <= 255 && g >= 0 && g <= 255 && b >= 0 && b <= 255)
                {
                    Background_Color.Background = new SolidColorBrush(Color.FromArgb(255, r, g, b));
                    Result.Text = "";
                    Result1.Text = "";
                    Result2.Text = "";
                    Result3.Text = "";
                    string rt, gt, bt;
                    if (r <= 16)
                        rt = "0" + r.ToString("X");
                    else
                        rt = r.ToString("X");
                    if (g <= 16)
                        gt = "0" + g.ToString("X");
                    else
                        gt = g.ToString("X");
                    if (b <= 16)
                        bt = "0" + b.ToString("X");
                    else
                        bt = b.ToString("X");
                    Result.Text = "#" + rt + gt + bt + "       #" + rt.Substring(0, 1) + gt.Substring(0, 1) + bt.Substring(0, 1);
                    Result3.Text = "rgb("+r+","+g+","+b+")";
                }
                else
                {
                    Result.Text = "Error!";
                }
            }
            else if (Color_Hex.Text != "#")
            {
                string hexaColor = Color_Hex.Text;
                string partem = "[a-fA-F_0-9]{6}";
                hexaColor = hexaColor.Replace("Hex:#", "");
                //  if (hexaColor.Length != 6)
                Regex myRegex = new Regex(partem);
                if (myRegex.IsMatch(hexaColor) && hexaColor.Length == 6)
                {
                    Result.Text = hexaColor;
                    Background_Color.Background = new SolidColorBrush(Color.FromArgb(
                    255,
                    Convert.ToByte(hexaColor.Substring(0, 2), 16),
                    Convert.ToByte(hexaColor.Substring(2, 2), 16),
                    Convert.ToByte(hexaColor.Substring(4, 2), 16)
                ));
                    Result.Text = "";
                    Result1.Text = "";
                    Result2.Text = "";
                    Result3.Text = "";
                    Result.Text = "#" + hexaColor + "       #" + hexaColor.Substring(0, 1) + hexaColor.Substring(2, 1) + hexaColor.Substring(4, 1);
                    Result3.Text = "rgb(" + Convert.ToByte(hexaColor.Substring(0, 2), 16) + "," + Convert.ToByte(hexaColor.Substring(2, 2), 16) + "," + Convert.ToByte(hexaColor.Substring(4, 2), 16) + ")";
                }

                else
                {
                    Result.Text = "Error!";
                    //Background_Color.Background = new SolidColorBrush(Color.FromArgb(51, 80, 62, 40));
                }
            }

            else
            {
                Result.Text = "Enter Color!";
            }
        }

        private void EnterColor_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            RootPanorama.DefaultItem = RootPanorama.Items[1];
        }

       

       
    }
}