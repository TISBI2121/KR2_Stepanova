using KR2_Stepanova.Models;
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
    /// Логика взаимодействия для AddPage.xaml
    /// </summary>
    public partial class AddPage : Page
    {
        Employee contextEmployee;
        public AddPage(Employee employee)
        {
            InitializeComponent();
            contextEmployee = employee;
            DataContext = contextEmployee;

        }

        private void BSave_Click(object sender, RoutedEventArgs e)
        {
            string errorMessage = "";
            if (string.IsNullOrWhiteSpace(contextEmployee.FullName))
                errorMessage += "Введите название\n";
            if (string.IsNullOrWhiteSpace(contextEmployee.Address))
                errorMessage += "Введите адрес\n";
            if (string.IsNullOrWhiteSpace(contextEmployee.Number))
                errorMessage += "Введите номер\n";
            if (string.IsNullOrWhiteSpace(contextEmployee.Pasport))
                errorMessage += "Введите паспорт\n";

        }

        private void BBack_Click(object sender, RoutedEventArgs e)
        {
            if (NavigationService.CanGoBack)
                NavigationService.GoBack();
        }
    }
}
