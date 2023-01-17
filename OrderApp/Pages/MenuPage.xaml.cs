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

namespace OrderApp.Pages
{
    /// <summary>
    /// Логика взаимодействия для MenuPage.xaml
    /// </summary>
    public partial class MenuPage : Page
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        private void ShowMenu_Click(object sender, RoutedEventArgs e)
        {
            ShowMenu.Visibility = Visibility.Collapsed;
            BurgerMenu.Visibility = Visibility.Visible;
        }

        private void HideMenu_Click(object sender, RoutedEventArgs e)
        {
            ShowMenu.Visibility = Visibility.Visible;
            BurgerMenu.Visibility = Visibility.Collapsed;
        }
    }
}
