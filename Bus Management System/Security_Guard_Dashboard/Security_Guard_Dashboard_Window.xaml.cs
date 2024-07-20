using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Eventing.Reader;
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
using Transport_Management_System.Data_Access;
using Transport_Management_System.Models;

namespace Transport_Management_System.Security_Guard_Dashboard
{
    public partial class Security_Guard_Dashboard_Window : Window
    {

        public Security_Guard_Dashboard_Window()
        {
            InitializeComponent();
            Loaded += homeButtonClicked;
        }
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            SecurityGuardMainFrame.Content = new Registered_Vehicle_Entry();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            SecurityGuardMainFrame.Content=new UnRegistered_Vehicle_Entry();
        }
        public void Logout_Window(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
        public void homeButtonClicked(object sender, RoutedEventArgs e)
        {
            SecurityGuardMainFrame.Content = new Security_Guard_Dashboard_Basic_Page();
        }
    }
}
