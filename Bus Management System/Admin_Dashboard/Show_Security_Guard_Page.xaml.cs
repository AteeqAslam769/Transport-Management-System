using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace Transport_Management_System.Admin_Dashboard
{
    /// <summary>
    /// Interaction logic for Show_Security_Guard_Page.xaml
    /// </summary>
    public partial class Show_Security_Guard_Page : Page
    {
        string globalSecurityGuardSearchTextBox = string.Empty;
        public Show_Security_Guard_Page()
        {
            InitializeComponent();

            Loaded += OnLoad;

            SecurityGuardSearchTextBox.GotFocus += Security_Guard_Text_Focus;

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


                    SecurityGuardLabel.Content = $"Security Guards({Security_guards.Count})";


                    SecurityGuardDataGrid.ItemsSource = Security_guards;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while fetching users: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        public void Security_Guard_Text_Focus(object obj, RoutedEventArgs e)
        {
            SecurityGuardSearchTextBox.Text = string.Empty;
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
                        var person = item as Models.Person; // Assuming 'Person' is the type of items in your DataGrid
                        bool isMatch = person.Email.Contains(searchedEmail);

                        // If the person matches the search query, select the row
                        if (isMatch)
                        {
                            SecurityGuardDataGrid.SelectedItem = item;
                            SecurityGuardDataGrid.ScrollIntoView(item);
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

        public void Security_Guard_Text_Lost_Focus(Object sender, EventArgs e)
        {
            globalSecurityGuardSearchTextBox = SecurityGuardSearchTextBox.Text;
            SecurityGuardSearchTextBox.Text = "Enter Email";
        }

    }
}
