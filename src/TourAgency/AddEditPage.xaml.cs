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
    /// Логика взаимодействия для AddEditTour.xaml
    /// </summary>
    public partial class AddEditTour : Page
    {
        private Tour _currentTour = new Tour();
        public AddEditTour(Tour selectedTour)
        {
            InitializeComponent();
            ComboDeparture_city_id.ItemsSource = TourAgencyEntities.GetContext().Cities.ToList();
            ComboArrival_country_id.ItemsSource = TourAgencyEntities.GetContext().Countries.ToList();
            ComboResort.ItemsSource = TourAgencyEntities.GetContext().Resorts.ToList();
            ComboHotel.ItemsSource = TourAgencyEntities.GetContext().Hotels.ToList();
            ComboList_Include.ItemsSource = TourAgencyEntities.GetContext().List_Include.ToList();
            ComboTour_company_id.ItemsSource = TourAgencyEntities.GetContext().Companies.ToList();
            if (selectedTour != null)
                _currentTour = selectedTour;

        }
        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            //if (string.IsNullOrWhiteSpace(_currentTour.Departure_date)) errors.AppendLine("Укажите дату отправления!");
            //if (string.IsNullOrWhiteSpace(_currentTour.Tour_duration)) errors.AppendLine("Укажите длительность тура!");
            //if (string.IsNullOrWhiteSpace(_currentTour.Flight)) errors.AppendLine("Укажите рейс!");
            //if (string.IsNullOrWhiteSpace(_currentTour.Price)) errors.AppendLine("Укажите цену!");
            //if (string.IsNullOrWhiteSpace(_currentTour.Tour_type)) errors.AppendLine("Укажите тип тура!");
            //if (string.IsNullOrWhiteSpace(_currentTour.Tour_description)) errors.AppendLine("Укажите описание тура!");
            //if (string.IsNullOrWhiteSpace(_currentTour.Comission)) errors.AppendLine("Укажите комиссию!");
            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            if (_currentTour.ID_tour == 0)
                TourAgencyEntities.GetContext().Tours.Add(_currentTour);
            try
            {
                TourAgencyEntities.GetContext().SaveChanges();
                MessageBox.Show("Данные сохранены!");
                //Tour.MainFrame.GoBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}