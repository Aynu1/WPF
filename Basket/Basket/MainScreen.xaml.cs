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

namespace Basket
{
    /// <summary>
    /// Логика взаимодействия для MainScreen.xaml
    /// </summary>
    public partial class MainScreen : Page
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void VisiterBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new VisitorMenuPage());
        }

        private void AdminBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
