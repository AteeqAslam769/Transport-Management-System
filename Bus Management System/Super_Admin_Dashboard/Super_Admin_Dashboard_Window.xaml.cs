using Transport_Management_System.Data_Access;

using Transport_Management_System.Models;
using Transport_Management_System.Super_Admin_Dashboard.Super_Admin_Dashboard_Pages;
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
using Transport_Management_System.Super_Admin_Dashboard.Super_Admin_Dashboard_Pages.Vehicle;

namespace Transport_Management_System
{

    public partial class Super_Admin_Dashboard_Window : Window
    {
        public string? globaleditTextBox = "";
        public string? globaldelTextBox = "";
        
        public Super_Admin_Dashboard_Window()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;

            editTextBox.LostFocus += editTextBox_Focus_Lost;
            delTextBox.LostFocus += delTextBox_Focus_Lost;

        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            editstack.Visibility = Visibility.Collapsed;
            delstack.Visibility = Visibility.Collapsed;
            MainFrame.Content = new Super_Admin_Dashboard_Basic_Page();
        }
        public void Home_Page(object sender, EventArgs e)
        {
            editstack.Visibility= Visibility.Collapsed;
            delstack.Visibility = Visibility.Collapsed;
            MainFrame.Content = new Super_Admin_Dashboard_Basic_Page();
        }
        public void View_User(object sender, EventArgs e)
        {
            editstack.Visibility = Visibility.Collapsed;
            delstack.Visibility = Visibility.Collapsed;
            MainFrame.Content = new View_Users_Page();
        }
        public void Add_User(object sender, EventArgs e)
        {
            this.Hide();
            delstack.Visibility = Visibility.Collapsed;
            editstack.Visibility = Visibility.Collapsed;
            MainFrame.Content = new Super_Admin_Dashboard_Basic_Page();
            Add_User add_User_window = new Add_User();
            add_User_window.Show();
        }

        public void Edit_User(object sender, EventArgs e)
        {
            delstack.Visibility = Visibility.Collapsed;
            MainFrame.Content = null;
            EditStackLable.Content = "Enter Email Of The Person You Want To Edit";
            EditStackButton.Click -= Check_Vehicle_For_Edit;
            EditStackButton.Click += new RoutedEventHandler(Check_User_For_Edit);
            editstack.Visibility = Visibility.Visible;
        }
        public void Delete_User(object sender, EventArgs e)
        {
            editstack.Visibility = Visibility.Collapsed;
            MainFrame.Content = null;
            DelStackLable.Content = "Enter Email Of The Person You Want To Delete";
            DelStackButton.Click -= Check_Vehicle_For_Del;
            DelStackButton.Click += Check_User_For_Del;
            delstack.Visibility= Visibility.Visible;
        }

       

        public void Check_User_For_Edit(object sender, EventArgs e)
        {

            editstack.Visibility = Visibility.Collapsed;
            using (var context = new BusManagementDbContext())
            {
                try
                {
                    
                    var personToEdit = context.Person.First(p => p.Email==globaleditTextBox && p.Role!="Super Admin");
                    if (personToEdit != null)
                    {
                        var person = personToEdit;
                        delstack.Visibility = Visibility.Collapsed;
                        Edit_User_Page obj = new Edit_User_Page(person);

                        MainFrame.Content = obj;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        public void Check_User_For_Del(object sender, EventArgs e)
        {
            delstack.Visibility = Visibility.Collapsed;
            using(var context = new BusManagementDbContext())
            {
                try
                {
                   var personToDelete = context.Person.First(p=>p.Email==globaldelTextBox && p.Role != "Super Admin");
                    if(personToDelete != null)
                    {
                        var person = personToDelete;
                        delstack.Visibility= Visibility.Collapsed;
                        Delete_User_Page  obj = new Delete_User_Page(person);
                        
                        MainFrame.Content = obj;
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
        }

        public void Add_Vehicle(object sender, EventArgs e)
        {
            this.Hide();
            delstack.Visibility = Visibility.Collapsed;
            editstack.Visibility = Visibility.Collapsed;
            MainFrame.Content = new Super_Admin_Dashboard_Basic_Page();
            Add_Vehicle add_Vehicle_Window = new Add_Vehicle();
            add_Vehicle_Window.Show();
        }

        public void View_Vehicles(object sender, EventArgs e)
        {
            editstack.Visibility = Visibility.Collapsed;
            delstack.Visibility = Visibility.Collapsed;
            MainFrame.Content = new View_Vehicle_Page();
        }

        public void Edit_Vehicle(object sender, EventArgs e)
        {
            delstack.Visibility = Visibility.Collapsed;
            MainFrame.Content = null;
            EditStackLable.Content = "Enter Registration Number Of The Vehicle You Want To Edit";
            EditStackButton.Click -= Check_User_For_Edit;
            EditStackButton.Click += new RoutedEventHandler(Check_Vehicle_For_Edit);
            editstack.Visibility = Visibility.Visible;
        }


        public void Check_Vehicle_For_Edit(object sender, EventArgs e)
        {
            editstack.Visibility = Visibility.Collapsed;
            using (var context = new BusManagementDbContext())
            {
                try
                {
                    var vehicleToEdit = context.Vehicle.First(p => p.Vehicle_Id == globaleditTextBox);
                    if (vehicleToEdit != null)
                    {
                        var vehicle = vehicleToEdit;
                        editstack.Visibility = Visibility.Collapsed;
                        Edit_Vehicle_Page obj = new Edit_Vehicle_Page(vehicle);

                        MainFrame.Content = obj;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        public void Delete_Vehicle(object sender, EventArgs e)
        {
            editstack.Visibility = Visibility.Collapsed;
            MainFrame.Content = null;
            DelStackLable.Content = "Enter Registration Number Of The Vehicle You Want To Delete";
            DelStackButton.Click -= Check_User_For_Del;
            DelStackButton.Click += new RoutedEventHandler(Check_Vehicle_For_Del);
            delstack.Visibility = Visibility.Visible;
        }

        public void Check_Vehicle_For_Del(object sender, EventArgs e)
        {
            delstack.Visibility = Visibility.Collapsed;
            using (var context = new BusManagementDbContext())
            {
                try
                {
                    var vehicleToDelete = context.Vehicle.First(p => p.Vehicle_Id == globaldelTextBox);
                    if (vehicleToDelete != null)
                    {
                        var vehicle = vehicleToDelete;
                        delstack.Visibility = Visibility.Collapsed;
                        Delete_Vehicle_Page obj = new Delete_Vehicle_Page(vehicle);

                        MainFrame.Content = obj;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
        public void editTextBox_Focus_Lost(object sender, EventArgs e)
        {
            globaleditTextBox = editTextBox.Text;
            editTextBox.Text = null;
        }

        public void delTextBox_Focus_Lost(object sender, EventArgs e)
        {
            globaldelTextBox = delTextBox.Text;
            delTextBox.Text = null;
        }
        public void Logout_Window(object sender, EventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
