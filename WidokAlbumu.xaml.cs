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

namespace bindingDoKlas
{
    /// <summary>
    /// Interaction logic for WidokAlbumu.xaml
    /// </summary>
    public partial class WidokAlbumu : Window
    {
        public Album Album { get; set; }

        public WidokAlbumu(Album album)
        {
            Album = album;
            DataContext = Album;
            InitializeComponent();
        }

        private void Dodaj_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}