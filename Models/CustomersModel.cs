using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarker_MVP.Models
{
    internal class CustomersModel
    {
        [DisplayName("Customers Id")]
        public int Id { get; set; }
        [DisplayName("Customers Name")]
        [Required(ErrorMessage = "Customers is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Customers name mus be between 3 and 50 characters")]
        public string Name { get; set; }

        [DisplayName("Customers Observation")]
        [Required(ErrorMessage = "Customers observation is required")]
        [StringLength(200, MinimumLength = 3, ErrorMessage = "Customers observations must be between 3 and 200 characters")]
        public string Observation { get; set; }
    }
}
