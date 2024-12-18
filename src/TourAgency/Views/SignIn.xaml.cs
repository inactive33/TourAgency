using System.Windows;
using System.Windows.Controls;
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
