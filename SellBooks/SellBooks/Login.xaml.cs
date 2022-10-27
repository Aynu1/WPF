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

namespace SellBooks
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

        private void Loginbtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                List<User> users = ProdaSEntities1.GetContext().Users.ToList();
                User u = users.FirstOrDefault(p => p.Password == Passtb.Password && p.Login == Logintb.Text);
                if (u != null)
                {
                    NavigationService.Navigate(new Spisok());
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
            //NavigationService.Navigate(new Spisok());
        }

        private void Registrationbtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
