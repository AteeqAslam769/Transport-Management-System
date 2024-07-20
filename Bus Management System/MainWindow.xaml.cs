using Transport_Management_System.Data_Access;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using Transport_Management_System.Admin_Dashboard;
using Transport_Management_System.Security_Guard_Dashboard;

namespace Transport_Management_System
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            
        }

        private void Button_Click(object sender, EventArgs e)
        {
            
            using (var context = new BusManagementDbContext())
            {
                if (CredentialComboBox.SelectedItem != null && EmailTextBox != null && PasswordBox != null)
                {
                    if (CredentialComboBox.Text == "Super Admin")
                    {
                        try
                        {
                            var person = context.Person.First(p => p.Email == EmailTextBox.Text && p.Password == PasswordBox.Password && p.Role == "Super Admin");
                            if (person != null)
                            {
                                Super_Admin_Dashboard_Window super_admin_Dashboard = new Super_Admin_Dashboard_Window();
                                super_admin_Dashboard.Show();
                                Close();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occurred: " + ex.Message + "\n Account Not Found Check Email And Password");
                        }
                    }
                    else if (CredentialComboBox.Text == "Admin")
                    {
                        try
                        {
                            var person = context.Person.First(p => p.Email == EmailTextBox.Text && p.Password == PasswordBox.Password && p.Role == "Admin");
                            if (person != null)
                            {
                                Admin_Dashboard_Window admin_Dashboard = new Admin_Dashboard_Window();
                                admin_Dashboard.Show();
                                Close();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occurred: " + ex.Message + "\n Account Not Found Check Email And Password");
                        }
                    }
                    else if (CredentialComboBox.Text == "Security Guard")
                    {
                        try
                        {
                            var person = context.Person.First(p => p.Email == EmailTextBox.Text && p.Password == PasswordBox.Password && p.Role == "Security Guard");
                            if (person != null)
                            {
                                Security_Guard_Dashboard_Window newobj = new Security_Guard_Dashboard_Window();
                                newobj.Show();
                                Close();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occurred: " + ex.Message + "\n Account Not Found Check Email And Password");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Empty fields are not allowed. Please fill in all fields.");
                }
            }
        }
    }
}
