using System;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using TourAgency.Entities;

namespace TourAgency
{
    /// <summary>
    /// Логика взаимодействия для AddEditTour.xaml
    /// </summary>
    public partial class AddEditTour : Page
    {
        readonly private Tour _currentTour = new Tour();
        public AddEditTour(Tour selectedTour)
        {
            InitializeComponent();

            if (selectedTour != null) _currentTour = selectedTour;
            DataContext = _currentTour;
            Update();


        }
        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (string.IsNullOrWhiteSpace(_currentTour.Departure_date.ToString()))   errors.AppendLine("Укажите дату отправления!");
            if (string.IsNullOrWhiteSpace(_currentTour.Tour_duration.ToString()))    errors.AppendLine("Укажите длительность тура!");
            if (string.IsNullOrWhiteSpace(_currentTour.Flight.ToString()))           errors.AppendLine("Укажите рейс!");
            if (string.IsNullOrWhiteSpace(_currentTour.Price.ToString()))            errors.AppendLine("Укажите цену!");
            if (string.IsNullOrWhiteSpace(_currentTour.Tour_type.ToString()))        errors.AppendLine("Укажите тип тура!");
            if (string.IsNullOrWhiteSpace(_currentTour.Comission.ToString()))        errors.AppendLine("Укажите комиссию!");
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
                FrameManager.FrameMain.GoBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        public void Update() {

            CoBox_City.ItemsSource    = TourAgencyEntities.GetContext().Cities.ToList();
            CoBox_Country.ItemsSource = TourAgencyEntities.GetContext().Countries.ToList();
            CoBox_Hotel.ItemsSource   = TourAgencyEntities.GetContext().Hotels.ToList();
            CoBox_Resort.ItemsSource  = TourAgencyEntities.GetContext().Resorts.ToList();
            CoBox_Company.ItemsSource = TourAgencyEntities.GetContext().Companies.ToList();
        }
    }
}