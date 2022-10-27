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
using System.Windows.Shapes;
using System.IO;
using Microsoft.Win32;

namespace FlowersMagazine2
{
    /// <summary>
    /// Логика взаимодействия для GoodAddPage.xaml
    /// </summary>
    public partial class GoodAddPage : Window
    {
        private Flower _currentGood = new Flower();
        private string _filePath = null;
        private string _photoName = null;
        private static string _currentDirectory = Directory.GetCurrentDirectory() + @"\Images\";
        public GoodAddPage()
        {
            InitializeComponent();
            if (selectedGood != null)
            {
                _currenGood = selectedGood;
                TextBoxld.Visibility = Visibility.Hidden;
                TextBlockFlowerld.Visibility = Visibility.Hidden;
                int x = selectedGood.FlowerID;
                List<Flower> flowers = new List<Flower>();
                _filePath = _currentDirectory + _currentGood.image;
            }
            DataContext = _currentGood;
            _photoName = _currentGood.image;
            CmbPostavchik.ItemsSource = FlowersMagEntities.GetContext().Postavshiks.ToList();
        }
        private StringBuilder CheckFileds()
        {
            StringBuilder s = new StringBuilder();
            if (string.IsNullOrWhiteSpace(_currentGood.Naimenovanie))
                s.AppendLine("Поле название пустое");
            if (_currentGood.Price < 0)
                s.AppendLine("цена не может быть отрицательной");
            if (_currentGood.Kolichestvo < 0)
                s.AppendLine("Количество не может быть отрицательной");
            if (_currentGood.Postavshik == null)
                s.AppendLine("Выберите поставщика");
            if (string.IsNullOrWhiteSpace(_photoName))
                s.AppendLine("фото не выбрано");
            return s;
        }
        private void LoagImage_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                OpenFileDialog op = new OpenFileDialog();
                op.Title = "Select a picture";
                op.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";
                if (op.ShowDialog() == true)
                {
                    FileInfo fileInfo = new FileInfo(op.FileName);
                    if (fileInfo.Length > (1024 * 1024 * 2))
                    {
                        throw new Exception("Размер файла должен быть меньше 2Мб");
                    }
                    ImagePhoto.Source = new BitmapImage(new Uri(op.FileName));
                    _photoName = op.SafeFileName;
                    _filePath = op.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButton.OK,
                MessageBoxImage.Error);
                _filePath = null;
            }
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder _error = CheckFileds();
            if (_error.Length > 0)
            {
                MessageBox.Show(_error.ToString());
                return;
            }
            if (_currentGood.FlowerID == 0)
            {
                string photo = ChangePhotoName();
                string dest = _currentDirectory + photo;
                File.Copy(_filePath, dest);
                _currentGood.image = photo;
                FlowersMagEntities.GetContext().Flowers.Add(_currentGood);
            }
            try
            {
                if (_filePath != null)
                {
                    string photo = ChangePhotoName();
                    string dest = _currentDirectory + photo;
                    File.Copy(_filePath, dest);
                    _currentGood.image = photo;
                }
                FlowersMagEntities.GetContext().SaveChanges();
                MessageBox.Show("Запись изменена");
                Manager.MainFrame.GoBack();
                //NavigationService.Navigate(new Pages.FlowerGoodPage());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        string ChangePhotoName()
        {
            string x = _currentDirectory + _photoName;
            string photoname = _photoName;
            int i = 0;
            if (File.Exists(x))
            {
                while (File.Exists(x))
                {
                    i++;
                    x = _currentDirectory + i.ToString() + photoname;
                }
                photoname = i.ToString() + photoname;
            }
            return photoname;
        }

    }
}
