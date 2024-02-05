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
using KR2_Stepanova.Models;

namespace KR2_Stepanova.Pages
{
    /// <summary>
    /// Логика взаимодействия для ServicePage.xaml
    /// </summary>
    public partial class ServicePage : Page
    {
        public ServicePage()
        {
            InitializeComponent();
            DGOrganizations.ItemsSource = App.DB.Employee.ToList();
        }

        private void DGOrganizations_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
        }

        private void BEdit_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddPage());
        }

        private void BAdd_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new TaskPage());
        }

        private void BRemove_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
