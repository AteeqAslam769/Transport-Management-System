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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Transport_Management_System.Super_Admin_Dashboard.Super_Admin_Dashboard_Pages
{
    /// <summary>
    /// Interaction logic for Edit_User.xaml
    /// </summary>
    public partial class Edit_User_Page : Page
    {
        Person personobj = new Person();
        string? mainEmail = "";
        public Edit_User_Page(Person obj)
        {
            InitializeComponent();
            NameTextBox.Text = obj.Name;
            PasswordBox.Password = obj.Password;
            EmailTextBox.Text = obj.Email;
            RoleComboBox.Text = obj.Role;
            personobj.Email = obj.Email;
            mainEmail = obj.Email;
            personobj.Name = obj.Name;
            editbutton.Visibility = Visibility.Collapsed;
            

            NameTextBox.TextChanged += FieldChanged;
            PasswordBox.PasswordChanged += FieldChanged;
            EmailTextBox.TextChanged += FieldChanged;
            RoleComboBox.SelectionChanged += FieldChanged;
        }

        private void FieldChanged(object sender, RoutedEventArgs e)
        {
            editbutton.Visibility = Visibility.Visible;
            personobj.Name = NameTextBox.Text;
            personobj.Email = EmailTextBox.Text;
            personobj.Password = PasswordBox.Password;
            personobj.Role = RoleComboBox.Text;
        }
        public void Update_User(object sender, EventArgs e)
        {
            using(var context = new BusManagementDbContext())
            {
                try
                {
                    var personToUpdate = context.Person.First(p=>p.Email==mainEmail);
                    if (personToUpdate != null)
                    {
                        personToUpdate.Name = personobj.Name;
                        personToUpdate.Email = personobj.Email;
                        personToUpdate.Password = personobj.Password;
                        personToUpdate.Role = RoleComboBox.Text;
                        context.SaveChanges();
                        MessageBox.Show($"Data About {personobj.Name} Has Been Changed");
                        this.Content = null;
                                               
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
