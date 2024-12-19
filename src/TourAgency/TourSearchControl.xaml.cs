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
            Update();

            LViewTours.ItemsSource = TourAgencyEntities.GetContext().Tours.ToList();
            // 1 - админ, 2 -  пользователь
            //if (App.CurrentUser.Role_id == 1)
            {
                //BtnEdit.Visibility = Visibility.Visible;
            }
            //else
            {
                //BtnEdit.Visibility = Visibility.Collapsed;
            }
            //ResortSearchBox.SelectedIndex = 0;
            //DepartureCitySearchBox.SelectedIndex = 0;
            //CountrySearchBox.SelectedIndex = 0;
            //DepartureDateSearchBox.SelectedDate = DateTime.Now;
            //CustomCheckBoxComboBox.SelectedIndex = 0;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Update();

            var search = TourAgencyEntities.GetContext().Tours.ToList();

            //if ()

            LViewTours.ItemsSource = search;

        }

        private void Update() 
        {
            CountrySearchBox.ItemsSource = TourAgencyEntities.GetContext().Countries.ToList();
            DepartureCitySearchBox.ItemsSource = TourAgencyEntities.GetContext().Cities.ToList();
            ResortSearchBox.ItemsSource = TourAgencyEntities.GetContext().Resorts.ToList();
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            FrameManager.FrameMain.Navigate(new AddEditTour(null));
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
