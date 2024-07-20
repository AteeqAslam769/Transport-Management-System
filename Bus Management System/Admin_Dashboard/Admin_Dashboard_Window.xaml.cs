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
using Transport_Management_System.Data_Access;
using Transport_Management_System.Super_Admin_Dashboard.Super_Admin_Dashboard_Pages;

namespace Transport_Management_System.Admin_Dashboard
{
    /// <summary>
    /// Interaction logic for Admin_Dashboard_Window.xaml
    /// </summary>
    public partial class Admin_Dashboard_Window : Window
    {
        
        public Admin_Dashboard_Window()
        {
            InitializeComponent();
            Loaded += HomeButtonClicked;
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new Show_Security_Guard_Page();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new Show_Vehicle_Page();
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Add_Vehicle add_Vehicle_Window = new Add_Vehicle();
            add_Vehicle_Window.Show();
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            MainFrame.Content=new Report_Generation_Page();
        }
        public void Logout_Window(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();

        }
        public void HomeButtonClicked(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new Admin_Dashboard_Basic_Page();
        }
    }
}
