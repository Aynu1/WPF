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
    /// Логика взаимодействия для SotrudnikiPage.xaml
    /// </summary>
    public partial class SotrudnikiPage : Page
    {
        public SotrudnikiPage()
        {
            InitializeComponent();
            //Vivod название DataGrid которое чтобы программа понимала где выводить информацию из бд
            //Если в проекте есть GetContext его можно заменить на App.db, 
            Vivod.ItemsSource = App.db.Sotrudnikis.OrderBy(p => p.Second_name).ToList();
        }
    }
}
