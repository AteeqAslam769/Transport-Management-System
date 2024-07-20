using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using Transport_Management_System.Data_Access;

namespace Transport_Management_System.Admin_Dashboard
{
    /// <summary>
    /// Interaction logic for Show_Vehicle_Page.xaml
    /// </summary>
    public partial class Show_Vehicle_Page : Page
    {

        string globalVehicalTextBox = string.Empty;
        public Show_Vehicle_Page()
        {
            InitializeComponent();

            Loaded += OnLoad;
            VehicleTextBox.GotFocus += Vehicle_Text_Focus;
            VehicleTextBox.LostFocus += Vehicle_Text_Lost_Focus;
        }

    

        private void OnLoad(object sender, RoutedEventArgs e)
        {
            using (var context = new BusManagementDbContext())
            {
                try
                {

                    var Vehicle = context.Vehicle.ToList();


                    VehicleLabel.Content = $"Vehicles({Vehicle.Count})";


                    VehicleGrid.ItemsSource = Vehicle;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while fetching users: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        public void Vehicle_Text_Focus(object sender, RoutedEventArgs e)
        {
            VehicleTextBox.Text = string.Empty;
        }




        public void Vehicle_Search(object sender, EventArgs e)
        {

            var searchedVehicleId = globalVehicalTextBox.Trim();

            ICollectionView view = CollectionViewSource.GetDefaultView(VehicleGrid.ItemsSource);

            if (view != null)
            {
                if (!string.IsNullOrWhiteSpace(searchedVehicleId))
                {

                    view.Filter = (item) =>
                    {
                        var vehicle = item as Transport_Management_System.Models.Vehicle;
                        bool isMatch = vehicle.Vehicle_Id.Contains(searchedVehicleId);


                        if (isMatch)
                        {
                            VehicleGrid.SelectedItem = item;
                            VehicleGrid.ScrollIntoView(item);
                        }

                        return isMatch;
                    };
                }
                else
                {

                    view.Filter = null;
                }
            }

        }
        public void Vehicle_Text_Lost_Focus(object sender, RoutedEventArgs e)
        {
            globalVehicalTextBox = VehicleTextBox.Text;
            VehicleTextBox.Text = "Enter Vehicle Registration Number";
        }
    }
}
