using Transport_Management_System.Data_Access;
using Transport_Management_System.Models;
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
using System.Windows.Shapes;
using System.Text.RegularExpressions;

namespace Transport_Management_System.Admin_Dashboard
{
    /// <summary>
    /// Interaction logic for Add_User.xaml
    /// </summary>
    public partial class Add_Vehicle : Window
    {
        public Add_Vehicle()
        {
            InitializeComponent();
            Closed += Add_Vehicle_Closed;
        }

        private void Add_Vehicle_Closed(object sender, System.EventArgs e)
        {
            // Get the parent window
            Window parentWindow = Application.Current.Windows.OfType<Admin_Dashboard_Window>().FirstOrDefault();
            if (parentWindow != null)
            {
                // Enable the parent window
                parentWindow.Show();
            }
        }
        public void Add_Vehicle_Button(object sender, EventArgs e)
        {
            using (var context = new BusManagementDbContext())
            {
                // Regular expression pattern for vehicle number validation
                string vehicleNumberPattern = @"^[A-Za-z]{3}-\d{4}$";

                if (string.IsNullOrWhiteSpace(IdTextBox.Text) || string.IsNullOrWhiteSpace(VehicleTypeComboBox.Text))
                {
                    MessageBox.Show("Field is Empty or have wrong data");
                }
                else if (!Regex.IsMatch(IdTextBox.Text, vehicleNumberPattern))
                {
                    MessageBox.Show("Invalid vehicle number format. It must be in the format AAA-0000");
                }
                else
                {
                    try
                    {
                        var newVehicle = new Models.Vehicle { Vehicle_Id = IdTextBox.Text, Vehicle_Type = VehicleTypeComboBox.Text };
                        context.Add(newVehicle);
                        context.SaveChanges();
                        MessageBox.Show("Vehicle Added Successfully");
                        this.Close();
                        Window parentWindow = Application.Current.Windows.OfType<Super_Admin_Dashboard_Window>().FirstOrDefault();
                        if (parentWindow != null)
                        {
                            // Enable the parent window
                            parentWindow.Show();
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
}
