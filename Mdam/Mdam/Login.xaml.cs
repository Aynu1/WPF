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

namespace Mdam
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
            try
            {
                List<user> users = FlowersMagEntities.GetContext().users.ToList();
                user u = users.FirstOrDefault(p => p.password == Passtb.Password && p.login == Logintb.Text);
                if (u != null)
                {
                    NavigationService.Navigate(new ListView());
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
    }
}
