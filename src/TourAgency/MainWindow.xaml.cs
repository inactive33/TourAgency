using System.Windows;
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
           // App.CurrentUser.Role_id = 4;
            MainFrame.Navigate(new TourSearchControl());
            FrameManager.FrameMain = MainFrame;
        }

        private void MainFrame_ContentRendered(object sender, System.EventArgs e)
        {

        }

        private void BtnNavTour_Click(object sender, RoutedEventArgs e)
        {
            FrameManager.FrameMain.Navigate(new SignIn());
        }

        private void BtnTours_Click(object sender, RoutedEventArgs e)
        {
                FrameManager.FrameMain.Navigate(new TourSearchControl());
        }

        private void BtnNavHotels_Click(object sender, RoutedEventArgs e)
        {
            FrameManager.FrameMain.Navigate(new HotelsSearchPage());
        }
    }
}