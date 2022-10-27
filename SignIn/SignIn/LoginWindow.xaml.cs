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

namespace SignIn
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

        private void BtnOk_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                List<User> users = авторизацияEntities4.GetContext().Users.ToList();
                User u = users.FirstOrDefault(p => p.password == TbPass.Password && p.login == TbLogin.Text);
                if (u != null)
                {
                    MainWindow mainWindow = new MainWindow();
                    mainWindow.Owner = this;
                    this.Hide();
                    mainWindow.Show();
                }
                else
                {
                    MessageBox.Show("не верный логин или пароль");
                }
            }
            catch (Exception ex)
            { 
            MessageBox.Show(ex.Message.ToString());
            }
        }

        private void BtnCansel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBoxResult x = MessageBox.Show("Вы действительно хотите закрыть?", "Выйти", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (x == MessageBoxResult.Cancel)
                e.Cancel = true;
        }
    }
}
