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
            MainFrame.Navigate(new ToursPage());
            FrameManager.FrameMain = MainFrame;
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            FrameManager.FrameMain.GoBack();
        }

        private void MainFrame_ContentRendered(object sender, System.EventArgs e)
        {
            if (MainFrame.CanGoBack) 
            { 
                BtnBack.Visibility = Visibility.Visible;
            }
            else
            {
                BtnBack.Visibility = Visibility.Hidden;
            }
        }
    }
}