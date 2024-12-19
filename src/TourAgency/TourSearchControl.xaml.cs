using System.Linq;
using System.Windows;
using System.Windows.Controls;
using TourAgency.Entities;

namespace TourAgency
{
    /// <summary>
    /// Логика взаимодействия для TourSearchControl.xaml
    /// </summary>
    public partial class TourSearchControl : UserControl
    {
        public TourSearchControl()
        {
            InitializeComponent();

            //Button deleteBtn = (Button)FindName("BtnReserveTour");
            //Button editBtn = (Button)FindName("BtnReserveTour");

            LViewTours.ItemsSource = TourAgencyEntities.GetContext().Tours.ToList();
            Update();

            //if (App.CurrentUser.Role_id == 2)
            //{
            //    deleteBtn.Visibility = Visibility.Collapsed;
            //    editBtn.Visibility = Visibility.Collapsed;
            //}
            //else if (App.CurrentUser.Role_id == 3) {
            //    deleteBtn.Visibility = Visibility.Collapsed;
            //    editBtn.Visibility = Visibility.Collapsed;
            //}
            //else if (App.CurrentUser.Role_id == 4){

            //    deleteBtn.Visibility = Visibility.Collapsed;
            //    editBtn.Visibility = Visibility.Collapsed;
            //}
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Update();

            var tours = TourAgencyEntities.GetContext().Tours.ToList();

            LViewTours.ItemsSource = tours;
        }

        private void Update() 
        {
            CountrySearchBox.ItemsSource = TourAgencyEntities.GetContext().Countries.ToList();
            ResortSearchBox.ItemsSource = TourAgencyEntities.GetContext().Resorts.ToList();
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            FrameManager.FrameMain.Navigate(new AddEditTour((sender as Button).DataContext as Tour));
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
