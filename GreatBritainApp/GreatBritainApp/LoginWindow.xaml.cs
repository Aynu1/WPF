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
using GreatBritainApp.Models;

namespace GreatBritainApp
{
    /// <summary>
    /// Логика взаимодействия для LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void BtnOkClick(object sender, RoutedEventArgs e)
        {
            try

            { //загрузка всех пользователей из БД в список

                List<User> users = GreatBritainEntities.GetContext().Users.ToList();

                //попытка найти пользователя с указанным паролем и логином

                //если такого пользователя не будет обнаружено то переменная u будет равна null

                User u = users.FirstOrDefault(p => p.password == TbPass.Password && p.username ==

                TbLogin.Text);

                if (u != null)

                {

                    // логин и пароль корректные запускаем главную форму приложения

                    MainWindow mainWindow = new MainWindow();

                    mainWindow.Owner = this;

                    this.Hide();

                    mainWindow.Show();

                }

                else

                {

                    MessageBox.Show("Не верный логин или пароль");

                }

            }

            catch (Exception ex)

            {

                MessageBox.Show(ex.Message.ToString());

            }

        }

        //код кнопки Cancel
    }

    private void BtnCancelClick(object sender, RoutedEventArgs e)
    {

    }

    private void WindowClosing(object sender, System.ComponentModel.CancelEventArgs e)
    {

    }
}
