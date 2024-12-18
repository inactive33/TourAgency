using System.Windows;
using TourAgency.Entities;
using TourAgency.Views;

namespace TourAgency
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new ToursAdminPage());
            FrameManager.FrameMain = MainFrame;
        }

        private void MainFrame_ContentRendered(object sender, System.EventArgs e)
        {

        }

        private void BtnNavTour_Click(object sender, RoutedEventArgs e)
        {
            FrameManager.FrameMain.Navigate(new SignIn());
        }

        private void BtnNavHotels_Click(object sender, RoutedEventArgs e)
        {
            //FrameManager.FrameMain.Navigate(new HotelPage());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FrameManager.FrameMain.Navigate(new ToursAdminPage());
        }
    }
}