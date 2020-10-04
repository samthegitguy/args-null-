﻿using System;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace config
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public static bool hastobetrue = true;
        public static bool hastobefalse = false;
        public MainPage()
        {
            this.InitializeComponent();
            Stop.Visibility = Visibility.Collapsed;
         }

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Collapsed;
            Stop.Visibility = Visibility.Visible;
        }

        private void Stop_Click(object sender, RoutedEventArgs e)
        {
            // TODO: Add event handler
        }
    }
}
