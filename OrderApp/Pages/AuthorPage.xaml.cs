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
using OrderApp.Pages;
namespace OrderApp
{
    /// <summary>
    /// Interaction logic for AuthorPage.xaml
    /// </summary>
    public partial class AuthorPage : Page
    {
        public AuthorPage()
        {
            InitializeComponent();
        }

        private void BtnRegistrate_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RegisterPage());
        }

        private void BtnAuthorize_Click(object sender, RoutedEventArgs e)
        {
            var user = DBConnection.connection.User.Where(x => x.Login == TBLogin.Text && x.Password == TBPassword.Password).FirstOrDefault();
            if (user != null)
                NavigationService.Navigate(new MenuPage());

            else
                MessageBox.Show("NE NORM");
        }
    }
}
