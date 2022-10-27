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

namespace PPSash
{
    /// <summary>
    /// Логика взаимодействия для TablePage.xaml
    /// </summary>
    public partial class TablePage : Page
    {
        public List<Auto> Autos { get; set; }
        public TablePage()
        {
            InitializeComponent();
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Spisok());
        }

        private void DataFlower_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            e.Row.Header = (e.Row.GetIndex() + 1).ToString();
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                DataFlower.ItemsSource = null;
                SashEntities6.GetContext().ChangeTracker.Entries().ToList().ForEach(p =>p.Reload());
                List<Auto> flowers =
                SashEntities6.GetContext().Autoes.OrderBy(p => p.Model).ToList();
                DataFlower.ItemsSource = flowers;
            }
        }
    }
}
