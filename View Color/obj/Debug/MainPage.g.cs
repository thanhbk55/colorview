﻿#pragma checksum "c:\users\thanh\documents\visual studio 2012\Projects\View Color\View Color\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "9FCFD6D5CE198C2E09D681A04BFB9312"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34003
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace View_Color {
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal Microsoft.Phone.Controls.Panorama RootPanorama;
        
        internal Microsoft.Phone.Controls.PanoramaItem Item1;
        
        internal Microsoft.Phone.Controls.HubTile EnterColor;
        
        internal Microsoft.Phone.Controls.HubTile SelectColor;
        
        internal Microsoft.Phone.Controls.HubTile Help;
        
        internal Microsoft.Phone.Controls.HubTile About;
        
        internal Microsoft.Phone.Controls.PanoramaItem Item2;
        
        internal System.Windows.Controls.TextBox Color_R;
        
        internal System.Windows.Controls.TextBox Color_G;
        
        internal System.Windows.Controls.TextBox Color_B;
        
        internal System.Windows.Controls.TextBox Color_Hex;
        
        internal System.Windows.Controls.Button Ok;
        
        internal System.Windows.Controls.StackPanel Background_Color;
        
        internal System.Windows.Controls.TextBlock Result;
        
        internal System.Windows.Controls.TextBlock Result1;
        
        internal System.Windows.Controls.TextBlock Result2;
        
        internal System.Windows.Controls.TextBlock Result3;
        
        internal Microsoft.Phone.Controls.PanoramaItem Item3;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/View%20Color;component/MainPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.RootPanorama = ((Microsoft.Phone.Controls.Panorama)(this.FindName("RootPanorama")));
            this.Item1 = ((Microsoft.Phone.Controls.PanoramaItem)(this.FindName("Item1")));
            this.EnterColor = ((Microsoft.Phone.Controls.HubTile)(this.FindName("EnterColor")));
            this.SelectColor = ((Microsoft.Phone.Controls.HubTile)(this.FindName("SelectColor")));
            this.Help = ((Microsoft.Phone.Controls.HubTile)(this.FindName("Help")));
            this.About = ((Microsoft.Phone.Controls.HubTile)(this.FindName("About")));
            this.Item2 = ((Microsoft.Phone.Controls.PanoramaItem)(this.FindName("Item2")));
            this.Color_R = ((System.Windows.Controls.TextBox)(this.FindName("Color_R")));
            this.Color_G = ((System.Windows.Controls.TextBox)(this.FindName("Color_G")));
            this.Color_B = ((System.Windows.Controls.TextBox)(this.FindName("Color_B")));
            this.Color_Hex = ((System.Windows.Controls.TextBox)(this.FindName("Color_Hex")));
            this.Ok = ((System.Windows.Controls.Button)(this.FindName("Ok")));
            this.Background_Color = ((System.Windows.Controls.StackPanel)(this.FindName("Background_Color")));
            this.Result = ((System.Windows.Controls.TextBlock)(this.FindName("Result")));
            this.Result1 = ((System.Windows.Controls.TextBlock)(this.FindName("Result1")));
            this.Result2 = ((System.Windows.Controls.TextBlock)(this.FindName("Result2")));
            this.Result3 = ((System.Windows.Controls.TextBlock)(this.FindName("Result3")));
            this.Item3 = ((Microsoft.Phone.Controls.PanoramaItem)(this.FindName("Item3")));
        }
    }
}

