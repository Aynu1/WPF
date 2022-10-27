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

namespace ListBox.Pages
{
    /// <summary>
    /// Логика взаимодействия для FlowerGoodPage.xaml
    /// </summary>
    public partial class FlowerGoodPage : Page
    {
        public FlowerGoodPage()
        {
            InitializeComponent();
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if(Visibility == Visibility.Visible)
            {
                DataFlower.ItemsSource = null;                
                //FlowersMagEntities.GetContext().ChangeTracker.Entries().ToString().ForEach(p => p.Reload());
                List<Flower> flowers = FlowersMagEntities.GetContext().Flowers.OrderBy(p => p.Naimenovanie).ToList();
                DataFlower.ItemsSource = flowers;
            }
        }

        private void DataFlower_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            e.Row.Header = (e.Row.GetIndex() + 1).ToString();
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new GoodAddPage((sender as Button).DataContext as Flower));
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new GoodAddPage(null));
        }
    }
}
