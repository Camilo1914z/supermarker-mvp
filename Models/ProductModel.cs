using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Supermarker_MVP.Models
{
    internal class ProductModel
    {
        [DisplayName("Product Id")]
        public int Id { get; set; }

        [DisplayName("Product Name")]
        [Required(ErrorMessage = "Product name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Product name mus be between 3 and 50 characters")]
        public string Name { get; set; }

        [DisplayName("Product Description")]
        [Required(ErrorMessage = "Product description is required")]
        [StringLength(200, MinimumLength = 3, ErrorMessage = "Product description must be between 3 and 200 characters")]
        public string Description { get; set; }


    }
}
