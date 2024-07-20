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

namespace Transport_Management_System.Security_Guard_Dashboard
{
    /// <summary>
    /// Interaction logic for Registered_Vehicle_Entry.xaml
    /// </summary>
    public partial class Registered_Vehicle_Entry : Page
    {
        Vehicle Vehicle = new Vehicle();
        VehicleMovement DeleteVehicleEntry = new VehicleMovement();
        public Registered_Vehicle_Entry()
        {
            InitializeComponent();
            Loaded += OnLoad;

        }
        public void OnLoad(object sender, RoutedEventArgs e)
        {
            Rendring();
        }

        private void Rendring()
        {
            using (var context = new BusManagementDbContext())
            {
                try
                {
                    var vehicle = context.Vehicle.ToList();
                    VehicleGrid.ItemsSource = vehicle;
                    var VehicleMovement = context.VehicleMovement.ToList();
                    VehicleMovmentGrid.ItemsSource = VehicleMovement;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        public void VehicleDataGridFocus(object sender, EventArgs e)
        {
            Vehicle = (Vehicle)VehicleGrid.SelectedValue;
            EnteredButton.Visibility = Visibility.Visible;
            ExitedButton.Visibility = Visibility.Visible;
            VehicleMovementGridButton.Visibility = Visibility.Collapsed;
        }
        private void Entered_Button_Click(object sender, RoutedEventArgs e)
        {
            using (var context = new BusManagementDbContext())
            {
                try
                {
                    VehicleMovement obj = new VehicleMovement();
                    obj.VehicleRegistrationNumber = Vehicle.Vehicle_Id;
                    obj.VehicleType = Vehicle.Vehicle_Type;
                    obj.MovementStatus = "inside";
                    obj.VehicleStatus = "Registered";
                    obj.Date = DateTime.Now.ToString("d");
                    obj.Time = DateTime.Now.ToString("t");
                    obj.Day = DateTime.Now.ToString("dddd");
                    context.VehicleMovement.Add(obj);
                    context.Vehicle.First(p => p.Vehicle_Id == Vehicle.Vehicle_Id).Status = "Inside";
                    context.SaveChanges();
                    Rendring();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void Exited_Button_Click(object sender, EventArgs e)
        {
            using (var context = new BusManagementDbContext())
            {
                try
                {
                    VehicleMovement obj = new VehicleMovement();
                    obj.VehicleRegistrationNumber = Vehicle.Vehicle_Id;
                    obj.VehicleType = Vehicle.Vehicle_Type;
                    obj.MovementStatus = "outside";
                    obj.VehicleStatus = "Registered";
                    obj.Date = DateTime.Now.ToString("d");
                    obj.Time = DateTime.Now.ToString("t");
                    obj.Day = DateTime.Now.ToString("dddd");
                    context.VehicleMovement.Add(obj);
                    context.Vehicle.First(p => p.Vehicle_Id == Vehicle.Vehicle_Id).Status = "Outside";
                    context.SaveChanges();
                    Rendring();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void VehicleMovementGridcellChanged(object sender, EventArgs e)
        {
            VehicleMovementGridButton.Visibility = Visibility.Visible;
            EnteredButton.Visibility = Visibility.Collapsed;
            ExitedButton.Visibility = Visibility.Collapsed;
            VehicleMovementGridButton.IsEnabled = true;
        }

        public void VehicleMovementGridLoseFocus(object sender, EventArgs e)
        {

            VehicleMovementGridButton.Visibility = Visibility.Visible;
        }
        public void Delete_Entry_Clicked(object sender, EventArgs e)
        {
            DeleteVehicleEntry = (VehicleMovement)VehicleMovmentGrid.SelectedValue;
            using (var context = new BusManagementDbContext())
            {
                try
                {
                    var EntryToDel = context.VehicleMovement.First(p => p.MovementId == DeleteVehicleEntry.MovementId);
                    if (EntryToDel != null)
                    {
                        context.Remove(EntryToDel);
                        if(EntryToDel.VehicleStatus == "Registered")
                        {

                            if (DeleteVehicleEntry.MovementStatus == "inside")
                            {
                                context.Vehicle.First(p => p.Vehicle_Id == DeleteVehicleEntry.VehicleRegistrationNumber).Status = "Outside";
                            }
                            else
                            {
                                context.Vehicle.First(p => p.Vehicle_Id == DeleteVehicleEntry.VehicleRegistrationNumber).Status = "Inside";

                            }
                        }

                        context.SaveChanges();
                        VehicleMovementGridButton.Visibility = Visibility.Collapsed;
                        Rendring();
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
