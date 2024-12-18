using Prism.Ioc;
using Prism.Unity;
using System.Windows;

namespace TourAgency
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        // Создание корневого окна (Shell)
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        // Регистрация служб и зависимостей
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            // Регистрация View и ViewModels
            containerRegistry.RegisterForNavigation<MainWindow>();
        }
    }
}
