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
using System.Windows.Threading;
using Transport_Management_System.Data_Access;

namespace Transport_Management_System.Security_Guard_Dashboard
{
    /// <summary>
    /// Interaction logic for Security_Guard_Dashboard_Basic_Page.xaml
    /// </summary>
    public partial class Security_Guard_Dashboard_Basic_Page : Page
    {
        private DispatcherTimer _timer;
        public Security_Guard_Dashboard_Basic_Page()
        {
            InitializeComponent();
            // Subscribe to the event from the first window
            var mainWindow = Application.Current.Windows
                                .OfType<MainWindow>()
                                .FirstOrDefault();

            if (mainWindow != null)
            {

            }

            Loaded += OnLoad;

            // Initialize the timer
            _timer = new DispatcherTimer();
            _timer.Interval = TimeSpan.FromSeconds(1); // Update every second
            _timer.Tick += Timer_Tick;
            _timer.Start();
        }
        private void OnLoad(object sender, RoutedEventArgs e)
        {
            using (var context = new BusManagementDbContext())
            {
                try
                {
                    var totalBuses = context.Vehicle.Count();
                    var insideUni = context.Vehicle.Count(e => e.Status == "Inside");
                    var outsideUni = context.Vehicle.Count(e => e.Status == "Outside");
                    Total.Content = $"Total Buses : {totalBuses}";
                    InUni.Content = $"Buses Inside University : {insideUni}";
                    OutUni.Content = $"Buses Outside University : {outsideUni}";
                }
                catch
                {

                }
            }
            // Set initial values
            Date.Content = $"Date: {DateTime.Now.ToString("yyyy-MM-dd")}";
            Time.Content = $"Time: {DateTime.Now.ToString("hh:mm:ss tt")}";
            Day.Content = $"Day: {DateTime.Now.ToString("dddd")}";
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Update date, time, and day
            Date.Content = $"Date: {DateTime.Now.ToString("yyyy-MM-dd")}";
            Time.Content = $"Time: {DateTime.Now.ToString("hh:mm:ss tt")}";
            Day.Content = $"Day: {DateTime.Now.ToString("dddd")}";
        }
    }
}
