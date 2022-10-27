using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace app_for_shashluk
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    
    public partial class MainPage : Page, INotifyPropertyChanged
    {
        public List<Product> basket = new List<Product>();
        public List<Product> Basket { get { return basket; } set { basket = value; OnPropertyChanged("Basket"); } }
        public MainPage()
        {
            InitializeComponent();
            UpdateBasket();
            ProductListView.ItemsSource = App.db.Product.ToList();
        }
        public void UpdateBasket()
        {
            BasketLisView.ItemsSource = null;
            float? summ = 0;
            BasketLisView.ItemsSource = Basket;
            foreach(Product product in Basket)
            {
                summ += product.Price;
            }
            ProductSumm.Content = summ.ToString();
        }
        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            if (ProductListView.SelectedItem != null)
                Basket.Add(ProductListView.SelectedItem as Product);
            UpdateBasket();
        }

        private void OpenBasketButton_Click(object sender, RoutedEventArgs e)
        {
            if (BasketBorder.Visibility == Visibility.Visible)
            {
                BasketBorder.Visibility = Visibility.Collapsed;
                BasketWindow.Visibility = Visibility.Collapsed;
                AddProductBtn.IsEnabled = true;
            }
            else if (BasketBorder.Visibility != Visibility.Visible)
            {
                BasketBorder.Visibility = Visibility.Visible;
                BasketWindow.Visibility = Visibility.Visible;
                AddProductBtn.IsEnabled = false;
            }
        }

        private void DeleteFromBasket_Click(object sender, RoutedEventArgs e)
        {
            Basket.Remove((sender as Button).DataContext as Product);
            UpdateBasket();
            
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        private void OrderBtn_Click(object sender, RoutedEventArgs e)
        {
            if (BasketLisView.Items.Count > 0)
            {
                App.db.Check.Add(new Check() { Date_Check = DateTime.Now, Summ = float.Parse(ProductSumm.Content.ToString())});
                App.db.SaveChanges();
                basket.Clear();
                UpdateBasket();
            }
        }
    }
}
