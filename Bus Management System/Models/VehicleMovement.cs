using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport_Management_System.Models
{
    public class VehicleMovement
    {
        [Key] public int MovementId { get; set; }
        public string? VehicleRegistrationNumber { get; set; }
        public string? VehicleType { get; set; }
        public string? MovementStatus { get; set; }
        public string? Date { get; set; }
        public string? Time { get; set; }
        public string? Day { get; set; }

        public string? VehicleStatus { get; set;}
   }
}
