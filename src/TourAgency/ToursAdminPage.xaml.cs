using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using TourAgency.Entities;

namespace TourAgency
{
    /// <summary>
    /// Логика взаимодействия для ToursPage.xaml
    /// </summary>
    public partial class ToursAdminPage : Page
    {
        public ToursAdminPage()
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
            var tourForRemoving = DGridTour.SelectedItems.Cast<Tour>().ToList();
            if (MessageBox.Show($"Вы точно хотите удалить следующие {tourForRemoving.Count()} данные?", "Внимание!",
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

        private void BtnOpenFile_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible) 
            {
                try
                {
                    TourAgencyEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                }
                catch { }
                DGridTour.ItemsSource = TourAgencyEntities.GetContext().Tours.ToList();
            }
        }
    }
}
