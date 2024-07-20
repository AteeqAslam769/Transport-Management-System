using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport_Management_System.Models
{
    public class Vehicle
    {
        
        [Key]public string? Vehicle_Id { get; set; }
        public string? Vehicle_Type { get; set; }

        public string? Status {  get; set; }

    }
}
