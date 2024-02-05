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

namespace KR2_Stepanova.Pages
{
    /// <summary>
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void BExit_Click(object sender, RoutedEventArgs e)
        {
            var loggedUser = App.DB.User.FirstOrDefault(x => x.Login == TBLogin.Text && x.Password == PBPassword.Password);
            if (loggedUser == null)
            {
                MessageBox.Show("Неверный логин или пароль");
                return;
            }
            App.loggedUser = loggedUser;
            NavigationService.Navigate(new ServicePage());
        }
    }
}
