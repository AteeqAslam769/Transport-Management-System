
using System.Data;
using System.Windows;
using System.Windows.Controls;

using Transport_Management_System.Data_Access;
using Transport_Management_System.Models;

namespace Transport_Management_System.Admin_Dashboard
{
    /// <summary>
    /// Interaction logic for Report_Generation_Page.xaml
    /// </summary>
    public partial class Report_Generation_Page : Page
    {
        public Report_Generation_Page()
        {
            InitializeComponent();
            Loaded += OnLoad;
        }

        public void OnLoad(object sender, RoutedEventArgs e)
        {
            using( var context = new BusManagementDbContext())
            {
                try
                {
                    var vehicleMovementData = context.VehicleMovement.ToList();
                    var MovementId = vehicleMovementData.Select(vm => vm.MovementId).ToList();
                    var registrationNumber = vehicleMovementData.Select(vm => vm.VehicleRegistrationNumber).Distinct().ToList();
                    var vehicleTypeComboBox = vehicleMovementData.Select(vm => vm.VehicleType).Distinct().ToList();

                    MovementId.Insert(0, -1);
                    
                    VehicleMovementComboBox.ItemsSource = MovementId;
                    VehicleMovementComboBox.SelectedIndex = 0;
                    registrationNumber.Insert(0,"All");
                    VehicleRegistrationNumberComboBox.SelectedIndex = 0;
                    VehicleRegistrationNumberComboBox.ItemsSource= registrationNumber;
                    vehicleTypeComboBox.Insert(0, "All");
                    VehicleTypeComboBox.SelectedIndex = 0;
                    VehicleTypeComboBox.ItemsSource = vehicleTypeComboBox;
                    VehicleMovementTypeComboBox.SelectedIndex = 2;
                    VehicleStatusComboBox.SelectedIndex = 2;



                    fromDatePicker.SelectedDate = DateTime.Now.AddDays(-1);
                    toDatePicker.SelectedDate = DateTime.Now;

                    fromTimehour.SelectedIndex = 6;
                    fromTimesection.SelectedIndex = 0;
                    toTimeHour.SelectedIndex = 4;
                    toTimeSection.SelectedIndex = 1;

                }
                catch( Exception ex )
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void VehicleMovementComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(VehicleMovementComboBox.SelectedIndex != 0 && VehicleMovementComboBox.SelectedValue != null)
            {
                VehicleRegistrationNumberComboBox.SelectedValue = null;
                VehicleRegistrationNumberComboBox.IsEnabled = false;

                VehicleTypeComboBox.SelectedValue= null;
                VehicleTypeComboBox.IsEnabled = false;

                VehicleStatusComboBox.IsEnabled = false;
                VehicleStatusComboBox.SelectedValue = null;

                VehicleMovementTypeComboBox.IsEnabled=false;
                VehicleMovementTypeComboBox.SelectedValue = null;

                fromDatePicker.IsEnabled = false;
                fromDatePicker.SelectedDate = null;
                toDatePicker.IsEnabled = false;
                toDatePicker.SelectedDate = null;

                fromTimehour.IsEnabled = false;
                fromTimehour.SelectedValue = null;
                toTimeHour.IsEnabled = false;
                toTimeHour.SelectedValue = null;

                fromTimesection.IsEnabled = false;
                fromTimesection.SelectedValue = null;
                toTimeSection.IsEnabled = false;
                toTimeSection.SelectedValue = null;
            }
            else if(VehicleMovementComboBox.SelectedValue != null)
            {
                VehicleRegistrationNumberComboBox.SelectedIndex = 0;
                VehicleRegistrationNumberComboBox.IsEnabled = true;

                VehicleTypeComboBox.SelectedIndex = 0;
                VehicleTypeComboBox.IsEnabled = true;

                VehicleStatusComboBox.IsEnabled = true;
                VehicleStatusComboBox.SelectedIndex = 2;

                VehicleMovementTypeComboBox.IsEnabled = true;
                VehicleMovementTypeComboBox.SelectedIndex = 2;

                fromDatePicker.IsEnabled = true;
                fromDatePicker.SelectedDate = DateTime.Now.AddDays(-1);
                toDatePicker.IsEnabled = true;
                toDatePicker.SelectedDate = DateTime.Now;

                fromTimehour.IsEnabled = true;
                fromTimehour.SelectedIndex = 6;
                toTimeHour.IsEnabled = true;
                toTimeHour.SelectedIndex = 4;

                fromTimesection.IsEnabled = true;
                fromTimesection.SelectedIndex = 0;
                toTimeSection.IsEnabled = true;
                toTimeSection.SelectedIndex = 1;
            }
        }

        private void VehicleRegistrationNumberComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (VehicleRegistrationNumberComboBox.SelectedIndex != 0 && VehicleRegistrationNumberComboBox.SelectedValue != null)
            {
                

                VehicleTypeComboBox.IsEnabled = false;
                VehicleTypeComboBox.SelectedValue = null;

                VehicleMovementComboBox.IsEnabled = false;  
                VehicleMovementComboBox.SelectedValue = null;
            }
            else if(VehicleRegistrationNumberComboBox.SelectedValue != null)
            {
                

                VehicleTypeComboBox.IsEnabled = true;
                VehicleTypeComboBox.SelectedIndex = 2;

                VehicleMovementComboBox.IsEnabled = true;
                VehicleMovementComboBox.SelectedIndex = 0;
            }
        }

        private void VehicleTypeComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (VehicleTypeComboBox.SelectedIndex != 0 && VehicleTypeComboBox.SelectedValue != null)
            {
                VehicleMovementComboBox.IsEnabled = false;
                VehicleMovementComboBox.SelectedValue = null;

                VehicleRegistrationNumberComboBox.IsEnabled = false;
                VehicleRegistrationNumberComboBox.SelectedValue = null;

                
            }
            else if (VehicleTypeComboBox.SelectedValue != null)
            {
                VehicleRegistrationNumberComboBox.IsEnabled = true;
                VehicleRegistrationNumberComboBox.SelectedIndex = 0;


                VehicleMovementComboBox.IsEnabled = true;
                VehicleMovementComboBox.SelectedIndex = 0;
            }
        }

        private void VehicleMovementTypeComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (VehicleMovementTypeComboBox.SelectedIndex != 2 && VehicleMovementTypeComboBox.SelectedValue != null && VehicleRegistrationNumberComboBox.SelectedIndex==0)
            {
                VehicleMovementComboBox.IsEnabled = false;
                VehicleMovementComboBox.SelectedValue = null;

                VehicleRegistrationNumberComboBox.IsEnabled = false;
                VehicleRegistrationNumberComboBox.SelectedValue = null;
            }
            else if (VehicleMovementTypeComboBox.SelectedValue != null && VehicleMovementTypeComboBox.SelectedIndex == 2)
            {
                VehicleRegistrationNumberComboBox.IsEnabled = true;
                VehicleRegistrationNumberComboBox.SelectedIndex = 0;


                VehicleMovementComboBox.IsEnabled = true;
                VehicleMovementComboBox.SelectedIndex = 0;
            }
        }

        private void VehicleStatusComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (VehicleStatusComboBox.SelectedIndex != 2 && VehicleStatusComboBox.SelectedValue != null)
            {
                VehicleMovementComboBox.IsEnabled = false;
                VehicleMovementComboBox.SelectedValue = null;

                
            }
            else if (VehicleStatusComboBox.SelectedValue != null && VehicleTypeComboBox.SelectedIndex == 0 && VehicleMovementTypeComboBox.SelectedIndex==2)
            {
           


                VehicleMovementComboBox.IsEnabled = true;
                VehicleMovementComboBox.SelectedIndex = 0;
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using(var context = new BusManagementDbContext())
            {

                if( VehicleMovementComboBox.SelectedIndex == 0)
                {
                    var allRecords = context.VehicleMovement.ToList();
                    var filteredRecords = new List<VehicleMovement>();
                    foreach (var record in allRecords)
                    {      
                        if (DateTime.TryParse(record.Date, out DateTime parsedDate))
                        {
                            if (parsedDate >= fromDatePicker.SelectedDate && parsedDate <= toDatePicker.SelectedDate)
                            {
                                filteredRecords.Add(record);
                            }
                        }
                    }             
                    VehicleMovmentGrid.ItemsSource = filteredRecords;
                }
                else if(VehicleMovementComboBox.SelectedItem == null)
                {
                    if (VehicleRegistrationNumberComboBox.SelectedItem != null && VehicleRegistrationNumberComboBox.SelectedIndex!=0)
                    {
                        var allrecords = context.VehicleMovement.Where(e=>e.VehicleRegistrationNumber== VehicleRegistrationNumberComboBox.Text).ToList();
                        if (VehicleMovementTypeComboBox.SelectedIndex != 2 || VehicleStatusComboBox.SelectedIndex!=2)
                        {

                            if (VehicleMovementTypeComboBox.SelectedIndex != 2)
                            {
                                if(VehicleStatusComboBox.SelectedIndex != 2)
                                {
                                    allrecords = context.VehicleMovement.Where(e => e.MovementStatus == VehicleMovementTypeComboBox.Text && e.VehicleRegistrationNumber == VehicleRegistrationNumberComboBox.Text && VehicleStatusComboBox.Text == e.VehicleStatus).ToList();
                                }
                                else
                                {
                                    allrecords = context.VehicleMovement.Where(e => e.MovementStatus == VehicleMovementTypeComboBox.Text && e.VehicleRegistrationNumber == VehicleRegistrationNumberComboBox.Text).ToList();
                                }
                            }
                            else if(VehicleStatusComboBox.SelectedIndex!=2)
                            {
                                allrecords = context.VehicleMovement.Where(e => e.VehicleStatus == VehicleStatusComboBox.Text && e.VehicleRegistrationNumber == VehicleRegistrationNumberComboBox.Text).ToList();

                            }
                        }
                        var filteredRecords = new List<VehicleMovement>();
                        foreach (var record in allrecords)
                        {
                            if (DateTime.TryParse(record.Date, out DateTime parsedDate))
                            {
                                if (parsedDate >= fromDatePicker.SelectedDate && parsedDate <= toDatePicker.SelectedDate)
                                {
                                    filteredRecords.Add(record);
                                }
                            }
                        }
                        VehicleMovmentGrid.ItemsSource = filteredRecords;
                    }
                    else
                    {
                        if (VehicleTypeComboBox.Text != "All")
                        {
                            var allrecords = context.VehicleMovement.Where(e => e.VehicleType == VehicleTypeComboBox.Text).ToList();
                            if (VehicleMovementTypeComboBox.SelectedIndex != 2 || VehicleStatusComboBox.SelectedIndex != 2)
                            {
                                if (VehicleMovementTypeComboBox.SelectedIndex != 2)
                                {
                                    if (VehicleStatusComboBox.SelectedIndex != 2)
                                    {
                                        allrecords = context.VehicleMovement.Where(e => e.MovementStatus == VehicleMovementTypeComboBox.Text && e.VehicleType == VehicleTypeComboBox.Text && VehicleStatusComboBox.Text == e.VehicleStatus).ToList();
                                    }
                                    else
                                    {
                                        allrecords = context.VehicleMovement.Where(e => e.MovementStatus == VehicleMovementTypeComboBox.Text && e.VehicleType == VehicleTypeComboBox.Text).ToList();
                                    }
                                }
                                else if (VehicleStatusComboBox.SelectedIndex != 2)
                                {
                                    allrecords = context.VehicleMovement.Where(e => e.VehicleStatus == VehicleStatusComboBox.Text && e.VehicleType == VehicleMovementTypeComboBox.Text).ToList();

                                }

                            }
                            var filteredRecords = new List<VehicleMovement>();
                            foreach (var record in allrecords)
                            {
                                if (DateTime.TryParse(record.Date, out DateTime parsedDate))
                                {
                                    if (parsedDate >= fromDatePicker.SelectedDate && parsedDate <= toDatePicker.SelectedDate)
                                    {
                                        filteredRecords.Add(record);
                                    }
                                }
                            }
                            VehicleMovmentGrid.ItemsSource = filteredRecords;
                        }
                        else
                        {
                            var allrecords = context.VehicleMovement.Where(e => e.VehicleType == VehicleTypeComboBox.Text).ToList();
                            if (VehicleMovementTypeComboBox.SelectedIndex != 2 || VehicleStatusComboBox.SelectedIndex != 2)
                            {
                                if (VehicleMovementTypeComboBox.SelectedIndex != 2)
                                {
                                    if (VehicleStatusComboBox.SelectedIndex != 2)
                                    {
                                        allrecords = context.VehicleMovement.Where(e => e.MovementStatus == VehicleMovementTypeComboBox.Text && VehicleStatusComboBox.Text == e.VehicleStatus).ToList();
                                    }
                                    else
                                    {
                                        allrecords = context.VehicleMovement.Where(e => e.MovementStatus == VehicleMovementTypeComboBox.Text).ToList();
                                    }
                                }
                                else if (VehicleStatusComboBox.SelectedIndex != 2)
                                {
                                    allrecords = context.VehicleMovement.Where(e => e.VehicleStatus == VehicleStatusComboBox.Text).ToList();

                                }

                            }
                            var filteredRecords = new List<VehicleMovement>();
                            foreach (var record in allrecords)
                            {
                                if (DateTime.TryParse(record.Date, out DateTime parsedDate))
                                {
                                    if (parsedDate >= fromDatePicker.SelectedDate && parsedDate <= toDatePicker.SelectedDate)
                                    {
                                        filteredRecords.Add(record);
                                    }
                                }
                            }
                            VehicleMovmentGrid.ItemsSource = filteredRecords;
                        }
                       
                    }
                }
                else
                {
                    var allRecords = context.VehicleMovement.Where(e=>e.MovementId==int.Parse(VehicleMovementComboBox.Text)).ToList();
                    VehicleMovmentGrid.ItemsSource= allRecords;
                }
                
            }
        }
    }
}
