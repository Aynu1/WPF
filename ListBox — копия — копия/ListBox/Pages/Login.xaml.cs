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
    /// Логика взаимодействия для Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Registrationbtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Registration());
        }

        private void Loginbtn_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(Logintb.Text) && !string.IsNullOrEmpty(Passtb.Password))
            {

                user user1 = Login.user.ToList().Find(c => c.Login == Logintb.Text);
                if (user1 != null)
                {
                    if (date <= DateTime.Now)
                    {
                        MainPage.AuthUser = MainPage.db.User.ToList().Find(c => c.Login == Logintb.Text && c.Password == Passtb.Password);
                        if (MainPage.AuthUser != null)
                        {
                            NavigationService.Navigate(new MainPage());
                        }
                        else
                        {
                            MessageBox.Show("Логин или пароль введены не правильно");
                            countenter += 1;
                            if (countenter == 3)
                            {
                                countenter = 0;
                                date = DateTime.Now.AddMinutes(1);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Вам бан!");
                    }
                }
                else
                {
                    MessageBox.Show("Логин или пароль введены не правильно");
                }
            }
            else
            {
                MessageBox.Show("Одно или несколько полей пусты");
            }
        }
    }
}
