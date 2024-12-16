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
    /// Логика взаимодействия для ToursPage.xaml
    /// </summary>
    public partial class ToursPage : Page
    {
        private Tour _currentTour = new Tour();
        public ToursPage()
        {
            InitializeComponent();
            DGridTour.ItemsSource = TourAgencyEntities.GetContext().Tours.ToList();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            FrameManager.FrameMain.Navigate(new AddEditTour(null));
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            var usersForRemoving = DGridTour.SelectedItems.Cast<User>().ToList();
            if (MessageBox.Show($"Вы точно хотите удалить следующие {usersForRemoving.Count()} данные?", "Внимание!",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    //usersForRemoving.ForEach(user => { user.IsDeleted = true; });
                    TourAgencyEntities.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены!");

                    DGridTour.ItemsSource = TourAgencyEntities.GetContext().Tours.ToList();
                }
                catch (Exception ex)
                {
                    var inner = ex.InnerException;
                    MessageBox.Show(inner.ToString());
                }
            }
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            FrameManager.FrameMain.Navigate(new AddEditTour((sender as Button).DataContext as Tour));
        }

        private void BtnLoadFile_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
