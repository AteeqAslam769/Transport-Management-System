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
using Transport_Management_System.Data_Access;
using Transport_Management_System.Models;

namespace Transport_Management_System.Super_Admin_Dashboard.Super_Admin_Dashboard_Pages
{
    public partial class Edit_Vehicle_Page : Page
    {
        Models.Vehicle vehicleobj = new Models.Vehicle();
        string? mainVehicleId = "";
        public Edit_Vehicle_Page(Transport_Management_System.Models.Vehicle obj)
        {
            InitializeComponent();
            VehicleIDTextBox.Text = obj.Vehicle_Id;
            VehicleTypeComboBox.Text=obj.Vehicle_Type;

            vehicleobj.Vehicle_Id = obj.Vehicle_Id;
            mainVehicleId = obj.Vehicle_Id;
            vehicleobj.Vehicle_Type = obj.Vehicle_Type;
            editbutton.Visibility = Visibility.Collapsed;


            VehicleIDTextBox.TextChanged += FieldChanged;
            VehicleTypeComboBox.SelectionChanged += FieldChanged;
        }

        private void FieldChanged(object sender, RoutedEventArgs e)
        {
            editbutton.Visibility = Visibility.Visible;
            vehicleobj.Vehicle_Type = VehicleTypeComboBox.Text;
            vehicleobj.Vehicle_Id = VehicleIDTextBox.Text;
           
        }

        public void Update_Vehicle(object sender, EventArgs e)
        {
            using (var context = new BusManagementDbContext())
            {
                try
                {
                    var VehicleToUpdate = context.Vehicle.First(p => p.Vehicle_Id == mainVehicleId);
                    if (VehicleToUpdate != null)
                    {
                        VehicleToUpdate.Vehicle_Type = VehicleTypeComboBox.Text;
                        VehicleToUpdate.Vehicle_Id = vehicleobj.Vehicle_Id;
                        
                        context.SaveChanges();
                        MessageBox.Show($"Data About {vehicleobj.Vehicle_Id} Has Been Changed");
                        this.Content = null;

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
