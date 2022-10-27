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
using System.IO;
namespace Exam
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new Login());
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            Add Page = new Add(new Sotrudniki());
            MainFrame.Navigate(Page);
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(MainFrame.CanGoBack)
                MainFrame.GoBack();
        }

        private void MainFrame_ContentRendered(object sender, EventArgs e)
        {
            if (MainFrame.CanGoBack)
                BtnBack.Visibility = Visibility.Visible;
            else
                BtnBack.Visibility = Visibility.Collapsed;
            if (MainFrame.CanGoBack)
                AddBtn.Visibility = Visibility.Visible;
            else
                AddBtn.Visibility = Visibility.Collapsed;
        }
    }
}
