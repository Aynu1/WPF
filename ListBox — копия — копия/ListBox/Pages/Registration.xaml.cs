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
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Page
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void Registrationtb_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(Logintb.Text) && !string.IsNullOrEmpty(Passtb1.Text) && !string.IsNullOrEmpty(Passtb2.Text))
            {

                if (Passtb1.Text == Passtb2.Text)
                {
                    var sel = MainWindow.db.User.ToList().Find(c => c.Login == Logintb.Text);
                    if (sel == null)
                    {
                        string pass = Passtb1.Text;
                        if ((Regex.IsMatch(pass, @"[А-ЯЁ]") || Regex.IsMatch(pass, @"[A-Z]")) && Regex.IsMatch(pass, @"[0-9]") && pass.Length >= 6 && CheckSymbol())
                        {
                            MainWindow.db.User.Add(new User()
                            {
                                Login = Logintb.Text,
                                Password = Passtb1.Text,
                                RoleId = 2
                            });
                            MainWindow.db.SaveChanges();

                            Logintb.Clear();
                            Passtb1.Clear();
                            Passtb2.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Пароль не соотвествует требованиям: " + "\n" + "Минимум 6 символов." + "\n" + "Минимум 1 прописная буква" + "\n" + "Минимум 1 цифра." + "\n" + "Минимум один символ из набора: ! @ # $ % ^.");
                        }


                    }
                    else
                    {
                        MessageBox.Show("Логин уже занят!");
                    }
                }
                else
                {
                    MessageBox.Show("Пароли не совпадают!");
                }
            }
            else
            {
                MessageBox.Show("Одно или несколько полей не заполнены!");
            }
        }

        private void Backbtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
