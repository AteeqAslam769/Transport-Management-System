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

namespace Transport_Management_System.Super_Admin_Dashboard.Super_Admin_Dashboard_Pages
{
    /// <summary>
    /// Interaction logic for Add_User.xaml
    /// </summary>
    public partial class Add_User : Window
    {
        public  Add_User()
        {
            InitializeComponent();
            Closed += Add_User_Closed;
        }

        private void Add_User_Closed(object sender, System.EventArgs e)
        {
            // Get the parent window
            Window parentWindow = Application.Current.Windows.OfType<Super_Admin_Dashboard_Window>().FirstOrDefault();
            if (parentWindow != null)
            {
                // Enable the parent window
                parentWindow.Show();
            }
        }
        public void Add_User_Button(object sender, EventArgs e)
        {
            
            using(var context = new BusManagementDbContext())
            {
                if(string.IsNullOrWhiteSpace(NameTextBox.Text) || !IsValidEmail(EmailTextBox.Text) || PasswordBox.Password.Length!=8 || RoleComboBox.Text == null)
                {
                    MessageBox.Show("Field is Empty or have wrong data");

                }
                else
                {
                    try
                    {
                        var newUser = new Person {Name = NameTextBox.Text, Email = EmailTextBox.Text, Password = PasswordBox.Password, Role = RoleComboBox.Text };
                        context.Add(newUser);
                        context.SaveChanges();
                        MessageBox.Show("User Added Successfully");
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
        private bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                return false;
            }

            // Regular expression for basic email format validation
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            if (!Regex.IsMatch(email, emailPattern))
            {
                return false;
            }

            try
            {
                // Split email address into local part and domain part
                string[] parts = email.Split('@');
                string localPart = parts[0];
                string domainPart = parts[1];

                // Check if domain part contains at least one dot
                if (!domainPart.Contains('.'))
                {
                    return false;
                }

                // Check if domain part does not start or end with a dot
                if (domainPart.StartsWith(".") || domainPart.EndsWith("."))
                {
                    return false;
                }

                // Check if domain part does not contain consecutive dots
                if (domainPart.Contains(".."))
                {
                    return false;
                }

                // Additional checks can be added as needed

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
