﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Diagnostics;

namespace WpfApp2
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            var watch = new Stopwatch();

            watch.Start();
                var basta = new BastaManager();

            var er1 = await basta.LoadSpeakersAsync();
            var er2 = await basta.LoadSeesionsAsync();

            //Task.WaitAll(er1, er2);

            listViewSpeakers.ItemsSource = er1;
            listViewSessions.ItemsSource = er2;

            watch.Stop();

            MessageBox.Show((watch.ElapsedMilliseconds)+ "ms");

        }
    }
}
