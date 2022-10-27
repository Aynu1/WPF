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

namespace ReadyProduct
{
    /// <summary>
    /// Логика взаимодействия для Basket.xaml
    /// </summary>
    public partial class Basket : Page
    {
        public static List<Product> BasketProducts = new List<Product>();
        public Basket()
        {
            InitializeComponent();
            LViewGoods.ItemsSource = ProductDBEntities1.GetContext().Products.OrderBy(p => p.Name).ToList();

        }
    }
}
