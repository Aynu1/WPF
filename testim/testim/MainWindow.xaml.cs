using System;
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

namespace testim
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new SotrudnikiPage());
        }

        private void Frame_ContentRendered(object sender, EventArgs e)
        {
            if(MainFrame.CanGoBack)
                BackBtn.Visibility = Visibility.Visible;
            else
                BackBtn.Visibility = Visibility.Collapsed;
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            if(MainFrame.CanGoBack)
                MainFrame.GoBack();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            AddPage Page = new AddPage(new Sotrudniki());
            MainFrame.Navigate(Page);
        }
    }
}
