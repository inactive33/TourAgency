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
using TourAgency.ViewModel;
namespace TourAgency.Views
{
    /// <summary>
    /// Логика взаимодействия для SignIn.xaml
    /// </summary>
    public partial class SignIn : Page
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void SignInButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Password_PasswordChanged(object sender, RoutedEventArgs e)
        {
            // Получаем ссылку на ViewModel через DataContext
            var viewModel = (SignInVM)DataContext;

            // Проверяем, что ViewModel существует
            if (viewModel != null)
            {
                // Обновляем свойство Password в ViewModel
                viewModel.Password = ((PasswordBox)sender).Password;
            }
        }
    }
}
