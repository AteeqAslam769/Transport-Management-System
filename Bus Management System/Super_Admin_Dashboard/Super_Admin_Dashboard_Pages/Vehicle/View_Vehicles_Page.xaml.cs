using Transport_Management_System.Data_Access;
using Transport_Management_System.Models;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media.Effects;
using Microsoft.Identity.Client;

namespace Transport_Management_System.Super_Admin_Dashboard.Super_Admin_Dashboard_Pages
{
    /// <summary>
    /// Interaction logic for View_Users_Page.xaml
    /// </summary>
    public partial class View_Vehicle_Page : Page
    {
        string globalVehicalTextBox = string.Empty;
        public View_Vehicle_Page()
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
