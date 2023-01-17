using OrderApp.DataBase;
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

namespace OrderApp
{
    /// <summary>
    /// Interaction logic for RegisterPage.xaml
    /// </summary>
    public partial class RegisterPage : Page
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

        private void BtnCansel_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void BtnRegister_Click(object sender, RoutedEventArgs e)
        {
            if (DBConnection.connection.User.Where(x => x.Login == TBLogin.Text).ToList().Count == 0)
            {
                if (TBPassword.Password == TBPassword2.Password)
                {
                    User user = new User
                    {
                        Login = TBLogin.Text,
                        Password = TBPassword.Password,
                    };

                    DBConnection.connection.User.Add(user);
                    DBConnection.connection.SaveChanges();

                    NavigationService.GoBack();
                }
                else
                    MessageBox.Show("Пароли не совпадают");
            }
            else
                MessageBox.Show("Логин уже существует");
        }
    }
}
