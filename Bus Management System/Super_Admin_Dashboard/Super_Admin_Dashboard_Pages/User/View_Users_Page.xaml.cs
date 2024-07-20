using Transport_Management_System.Data_Access;
using Transport_Management_System.Models;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media.Effects;

namespace Transport_Management_System.Super_Admin_Dashboard.Super_Admin_Dashboard_Pages
{
    /// <summary>
    /// Interaction logic for View_Users_Page.xaml
    /// </summary>
    public partial class View_Users_Page : Page
    {
        string globalAdminSearchTextBox = string.Empty;
        string globalSecurityGuardSearchTextBox = string.Empty;
        public View_Users_Page()
        {
            InitializeComponent();
            Loaded += OnLoad;
            AdminSearchTextBox.GotFocus += Admin_Text_Focus;
            SecurityGuardSearchTextBox.GotFocus += Security_Guard_Text_Focus;

            AdminSearchTextBox.LostFocus += Admin_Text_Lost_Focus;
            SecurityGuardSearchTextBox.LostFocus += Security_Guard_Text_Lost_Focus;

        }

        private void OnLoad(object sender, RoutedEventArgs e)
        {
            using (var context = new BusManagementDbContext())
            {
                try
                {
                    // Retrieve users from the database where Role is not "Super Admin"
                    var Admins = context.Person.Where(p => p.Role == "Admin").ToList();
                    var Security_guards = context.Person.Where(p => p.Role == "Security Guard").ToList();

                    AdminsLabel.Content = $"Admins({Admins.Count})";
                    SecurityGuardLabel.Content = $"Security Guards({Security_guards.Count})";

                    AdminsDataGrid.ItemsSource = Admins;
                    SecurityGuardDataGrid.ItemsSource = Security_guards;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while fetching users: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        public void Admin_Text_Focus(object sender, RoutedEventArgs e)
        {
            AdminSearchTextBox.Text = string.Empty;
        }
        public void Security_Guard_Text_Focus(object obj, RoutedEventArgs e)
        {
            SecurityGuardSearchTextBox.Text = string.Empty;
        }

        
        
        public void Admin_Search(object sender, EventArgs e)
        {
            
            var searchedEmail = globalAdminSearchTextBox.Trim();
            ICollectionView view = CollectionViewSource.GetDefaultView(AdminsDataGrid.ItemsSource);

            if (view != null)
            {
                if (!string.IsNullOrWhiteSpace(searchedEmail))
                {
                    // Apply the filter predicate
                    view.Filter = (item) =>
                    {
                        var person = item as Person; // Assuming 'Person' is the type of items in your DataGrid
                        bool isMatch = person.Email.Contains(searchedEmail);

                        // If the person matches the search query, select the row
                        if (isMatch)
                        {
                            AdminsDataGrid.SelectedItem = item;
                            AdminsDataGrid.ScrollIntoView(item);
                        }

                        return isMatch;
                    };
                }
                else
                {
                    // If search query is empty, remove the filter
                    view.Filter = null;
                }
            }


        }

        public void Security_Guard_Search(object sender, EventArgs e)
        {
            
            var searchedEmail = globalSecurityGuardSearchTextBox.Trim();
            ICollectionView view = CollectionViewSource.GetDefaultView(SecurityGuardDataGrid.ItemsSource);

            if (view != null)
            {
                if (!string.IsNullOrWhiteSpace(searchedEmail))
                {
                    // Apply the filter predicate
                    view.Filter = (item) =>
                    {
                        var person = item as Person; // Assuming 'Person' is the type of items in your DataGrid
                        bool isMatch = person.Email.Contains(searchedEmail);

                        // If the person matches the search query, select the row
                        if (isMatch)
                        {
                            AdminsDataGrid.SelectedItem = item;
                            AdminsDataGrid.ScrollIntoView(item);
                        }

                        return isMatch;
                    };
                }
                else
                {
                    // If search query is empty, remove the filter
                    view.Filter = null;
                }
            }


        }
        public void Admin_Text_Lost_Focus(object sender, EventArgs e)
        {
            globalAdminSearchTextBox = AdminSearchTextBox.Text;
            AdminSearchTextBox.Text = "Enter Email";
        }
        public void Security_Guard_Text_Lost_Focus(Object sender, EventArgs e)
        {
            globalSecurityGuardSearchTextBox = SecurityGuardSearchTextBox.Text;
            SecurityGuardSearchTextBox.Text= "Enter Email";
        }
    }
}
