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
using System.IO;
using Microsoft.Win32;
namespace Exam
{
    /// <summary>
    /// Логика взаимодействия для Add.xaml
    /// </summary>
    public partial class Add : Page
    {
        private Sotrudniki _currentGood = new Sotrudniki();
        private string _filePath = null;
        private string _photoName = null;
        private static string _currentDirectory = Directory.GetCurrentDirectory() + @"\Images\";
        public Add(Sotrudniki selectedGood)
        {
            InitializeComponent();
            if (selectedGood != null)
            {
                _currentGood = selectedGood;
                int x = selectedGood.Id_Sotrudnika;
                List<Sotrudniki> flowers = new List<Sotrudniki>();
                _filePath = _currentDirectory + _currentGood.Photo;
            }
            DataContext = _currentGood;
            _photoName = _currentGood.Photo;
        }
        private StringBuilder CheckFileds()
        {
            StringBuilder s = new StringBuilder();
            if (_currentGood.Id_Sotrudnika < 0)
                s.AppendLine("Поле Id пустое");
            if (string.IsNullOrWhiteSpace(_currentGood.Second_name))
                s.AppendLine("Поле название пустое");
            if (string.IsNullOrWhiteSpace(_currentGood.Name))
                s.AppendLine("Поле имя пустое");
            if (string.IsNullOrWhiteSpace(_currentGood.Surname))
                s.AppendLine("Поле фамилия пустое");
            if (string.IsNullOrWhiteSpace(_currentGood.Pol))
                s.AppendLine("Выберите пол");
            if (string.IsNullOrWhiteSpace(_photoName))
                s.AppendLine("фото не выбрано");
            return s;
        }
        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder _error = CheckFileds();
            if (_error.Length > 0)
            {
                MessageBox.Show(_error.ToString());
                return;
            }
            if (_currentGood.Id_Sotrudnika == 0)
            {
                string photo = ChangePhotoName();
                string dest = _currentDirectory + photo;
                File.Copy(_filePath, dest);
                _currentGood.Photo = photo;
                testPrimerEntities.GetContext().Sotrudnikis.Add(_currentGood);
            }
            try
            {
                if (_filePath != null)
                {
                    string photo = ChangePhotoName();
                    string dest = _currentDirectory + photo;
                    File.Copy(_filePath, dest);
                    _currentGood.Photo = photo;
                }
                // сохраняем изменения в БД
                testPrimerEntities.GetContext().SaveChanges();
                MessageBox.Show("Запись изменена");
                //Manager.MainFrame.GoBack();
                NavigationService.Navigate(new Spisok());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
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

        private void LoagImage_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //Диалог открытия файла
                OpenFileDialog op = new OpenFileDialog();
                op.Title = "Select a picture";
                op.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files(*.gif) | *.gif";
                if (op.ShowDialog() == true)
                {
                    // проверка размера файла
                    // по условию файл дожен быть не более 2Мб.
                    FileInfo fileInfo = new FileInfo(op.FileName);
                    if (fileInfo.Length > (1024 * 1024 * 2))
                    {
                        // размер файла меньше 2Мб. Поэтому выбрасывается новое исключение
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
    }
}
