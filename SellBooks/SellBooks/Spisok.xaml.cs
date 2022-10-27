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

namespace SellBooks
{
    /// <summary>
    /// Логика взаимодействия для Spisok.xaml
    /// </summary>
    public partial class Spisok : Page
    {
        public Spisok()
        {
            InitializeComponent();
            LViewGoods.ItemsSource = ProdaSEntities1.GetContext().Продажи.OrderBy(p => p.NameBook).ToList();
        }
    }
}
