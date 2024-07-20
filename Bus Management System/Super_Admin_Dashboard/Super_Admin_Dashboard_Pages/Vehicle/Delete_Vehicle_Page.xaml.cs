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

namespace Transport_Management_System.Super_Admin_Dashboard.Super_Admin_Dashboard_Pages.Vehicle
{
    /// <summary>
    /// Interaction logic for Delete_Vehicle_Page.xaml
    /// </summary>
    public partial class Delete_Vehicle_Page : Page
    {
        Models.Vehicle GlobalVehical = new Models.Vehicle();
        public Delete_Vehicle_Page(Models.Vehicle obj)
        {
            InitializeComponent();

            VehicleIDTextBox.Text = obj.Vehicle_Id;
            VehicleTypeTextBox.Text = obj.Vehicle_Type;
            GlobalVehical.Vehicle_Id = obj.Vehicle_Id;
            GlobalVehical.Vehicle_Type = obj.Vehicle_Type;

            VehicleIDTextBox.IsEnabled = false;
            VehicleTypeTextBox.IsEnabled = false;
        }
        public void Delete_Vehicle(object sender, EventArgs e)
        {
            using (var context = new BusManagementDbContext())
            {
                try
                {
                    var FinalVehiclePerson = context.Vehicle.First(p => p.Vehicle_Id == GlobalVehical.Vehicle_Id);
                    context.Remove(FinalVehiclePerson);
                    context.SaveChanges();
                    MessageBox.Show($"{GlobalVehical.Vehicle_Id} Deleted From Database");
                    this.Content = null;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
