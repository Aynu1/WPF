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
    /// Логика взаимодействия для CatalogFlowerPage.xaml
    /// </summary>
    public partial class CatalogFlowerPage : Page
    {
        int _itemcount = 0;
        public CatalogFlowerPage()
        {
            InitializeComponent();
            ListoxBoxFlower.ItemsSource = FlowersMagEntities.GetContext().Flowers.OrderBy(p =>p.Naimenovanie).ToList();
            var postavchik = FlowersMagEntities.GetContext().Postavshiks.OrderBy(p =>p.FIO).ToList();
            postavchik.Insert(0, new Postavshik
            {
                FIO = "Все поставщики"
            }
            );
            CmbPostavchik.ItemsSource = postavchik;
            CmbPostavchik.SelectedIndex = 0;
            ListoxBoxFlower.ItemsSource = FlowersMagEntities.GetContext().Flowers.OrderBy(p =>p.Naimenovanie).ToList();
            _itemcount = ListoxBoxFlower.Items.Count;
        }
        private void TBoxSerach_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateData();
        }
        private void CmbPostavchik_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateData();
        }
        private void CmbSort_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateData();
        }
        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
                FlowersMagEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p =>p.Reload());
            ListoxBoxFlower.ItemsSource = FlowersMagEntities.GetContext().Flowers.OrderBy(p =>p.Naimenovanie).ToList();
        }
        private void UpdateData()
        {
            var currentFlower = FlowersMagEntities.GetContext().Flowers.OrderBy(p =>p.Naimenovanie).ToList();
            if (CmbPostavchik.SelectedIndex > 0)
                //выбор только тех товаров, которые принадлежат данному поставщику
                currentFlower = currentFlower.Where(p => p.IDPostavshika ==(CmbPostavchik.SelectedItem as Postavshik).IDPostavshika).ToList();
            // выбор тех товаров, в названии которых есть поисковая строка
            currentFlower = currentFlower.Where(p =>p.Naimenovanie.ToLower().Contains(TBoxSerach.Text.ToLower())).ToList();
            // сортировка
            if (CmbSort.SelectedIndex >= 0)
            {
                // сортировка по возрастанию цены
                if (CmbSort.SelectedIndex == 0)
                    currentFlower = currentFlower.OrderBy(p => p.Price).ToList();
                // сортировка по убыванию цены
                if (CmbSort.SelectedIndex == 1)
                    currentFlower = currentFlower.OrderByDescending(p => p.Price).ToList();
            }
            // В качестве источника данных присваиваем список данных
            ListoxBoxFlower.ItemsSource = currentFlower;
        }

        private void BtnPlitka_Click(object sender, RoutedEventArgs e)
        {
            //Навигация по страницам
            NavigationService.Navigate(new FlowerGoodPage());
        }

        private void BtnPlitka2_Click(object sender, RoutedEventArgs e)
        {

        }
    }    
}
