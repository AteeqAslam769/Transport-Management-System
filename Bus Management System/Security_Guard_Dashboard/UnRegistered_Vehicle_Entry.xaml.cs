using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    public partial class UnRegistered_Vehicle_Entry : Page
    {
        string RegTextBoxData;
        string TypeTextBoxData;
        public UnRegistered_Vehicle_Entry()
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
                    var VehicleMovement = context.VehicleMovement.ToList();
                    VehicleMovmentGrid.ItemsSource = VehicleMovement;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private bool ValidateRegistrationNumber(string regNumber)
        {
            // Check if the registration number matches the format AAA-0000
            return Regex.IsMatch(regNumber, @"^[A-Za-z]{3}-\d{4}$");
        }

        private void Entered_Button_Click(object sender, RoutedEventArgs e)
        {
            if (!ValidateRegistrationNumber(RegTextBoxData))
            {
                MessageBox.Show("Please enter the registration number in the format AAA-0000.");
                return;
            }
            using (var context = new BusManagementDbContext())
            {
                try
                {
                    VehicleMovement obj = new VehicleMovement();
                    obj.VehicleRegistrationNumber = RegTextBoxData.Trim();
                    obj.VehicleType = TypeTextBoxData.Trim();
                    obj.MovementStatus = "Inside";
                    obj.VehicleStatus = "Unregistered";
                    obj.Date = DateTime.Now.ToString("d");
                    obj.Time = DateTime.Now.ToString("t");
                    obj.Day = DateTime.Now.ToString("dddd");
                    context.VehicleMovement.Add(obj);

                    RegTextBox.Text = "Enter Registration Number";
                    TypeTextBox.Text = "Enter Vehicle Type";

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
            if (!ValidateRegistrationNumber(RegTextBoxData))
            {
                MessageBox.Show("Please enter the registration number in the format AAA-0000.");
                return;
            }
            using (var context = new BusManagementDbContext())
            {
                try
                {
                    VehicleMovement obj = new VehicleMovement();
                    obj.VehicleRegistrationNumber = RegTextBoxData.Trim();
                    obj.VehicleType = TypeTextBoxData.Trim();
                    obj.VehicleStatus = "Unregistered";
                    obj.MovementStatus = "Outside";
                    obj.Date = DateTime.Now.ToString("d");
                    obj.Time = DateTime.Now.ToString("t");
                    obj.Day = DateTime.Now.ToString("dddd");
                    context.VehicleMovement.Add(obj);

                    RegTextBox.Text = "Enter Registration Number";
                    TypeTextBox.Text = "Enter Vehicle Type";

                    context.SaveChanges();
                    Rendring();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        public void RegTextBox_GotFocus(object sender, EventArgs e)
        {
            RegTextBoxData = RegTextBox.Text;
            RegTextBox.Text = null;
        }

        public void TypeTextBox_GotFocus(object obj, EventArgs e)
        {
            TypeTextBoxData = TypeTextBox.Text;
            TypeTextBox.Text = null;
        }

        public void RegTextBoxLoseFocus(object sender, EventArgs e)
        {
            RegTextBox.Text = RegTextBoxData;
            
        }

        public void TypeTextBoxLoseFocus(object sender, EventArgs e)
        {
            TypeTextBox.Text = TypeTextBoxData;
           
        }

    }


}
