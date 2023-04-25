using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Supermarker_MVP.Models
{
    internal class PayModeModel
    {
        [DisplayName ("Pay Mode Id")]
        public int Id { get; set; }
        [DisplayName("Pay Mode Name")]
        [Required(ErrorMessage ="Pay mode name is required")]
        [StringLength(50,MinimumLength =3, ErrorMessage ="Pay mode name mus be between 3 and 50 characters")]
        public string Name { get; set; }

        [DisplayName("Pay Mode Observation")]
        [Required(ErrorMessage = "Pay mode observation is required")]
        [StringLength(200,MinimumLength=3, ErrorMessage ="Pay mode observations must be between 3 and 200 characters")]
        public string Observation { get; set; }

    }
}
