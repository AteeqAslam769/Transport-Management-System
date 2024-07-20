using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transport_Management_System.Models;
using Microsoft.EntityFrameworkCore;

namespace Transport_Management_System.Data_Access
{
    public class BusManagementDbContext : Microsoft.EntityFrameworkCore.DbContext
    {   
        public DbSet<Person> Person { get; set; }
        public DbSet<Vehicle> Vehicle { get; set; }

        public DbSet<VehicleMovement> VehicleMovement { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=192.168.100.5,1433;Initial Catalog=Bus Management System;User ID=MyAdmin;Password=abc123xyz;TrustServerCertificate=True");


            }
        }

    }
}
