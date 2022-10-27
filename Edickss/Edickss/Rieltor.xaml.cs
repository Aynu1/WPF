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

namespace Edickss
{
    /// <summary>
    /// Логика взаимодействия для Rieltor.xaml
    /// </summary>
    public partial class Rieltor : Page
    {
        public Rieltor()
        {
            InitializeComponent();
            LViewGoods.ItemsSource = App.db.Sotrudnikis.OrderBy(p => p.Second_name).ToList();

        }
    }
}
