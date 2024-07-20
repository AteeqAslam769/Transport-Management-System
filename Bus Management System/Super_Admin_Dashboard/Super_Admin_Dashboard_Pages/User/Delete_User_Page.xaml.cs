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
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Transport_Management_System.Super_Admin_Dashboard.Super_Admin_Dashboard_Pages
{
    /// <summary>
    /// Interaction logic for Delete_User_Page.xaml
    /// </summary>
    public partial class Delete_User_Page : Page
    {
        Person GlobalPerson = new Person();
       
        public Delete_User_Page(Person obj)
        {
            InitializeComponent();
            NameTextBox.Text = obj.Name;
            EmailTextBox.Text = obj.Email;
            RoleTextBox.Text = obj.Role;
            GlobalPerson.Email = obj.Email;
            GlobalPerson.Name = obj.Name;

            NameTextBox.IsEnabled = false;
            EmailTextBox.IsEnabled=false;
            RoleTextBox.IsEnabled=false;


        }
        public void Delete_User(object sender,EventArgs e)
        {
            using(var context = new BusManagementDbContext())
            {
                try
                {
                    var finalDelPerson = context.Person.First(p => p.Email == GlobalPerson.Email);
                    context.Remove(finalDelPerson);
                    context.SaveChanges();
                    MessageBox.Show($"{GlobalPerson.Name} Deleted From Database");
                    this.Content = null;
                    
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            } 
        }
    }
}
