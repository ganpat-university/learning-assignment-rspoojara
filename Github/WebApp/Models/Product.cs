using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Models
{
    [Table("Products")]
    public class Product
    {
        [Display(Name = "Product ID")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }

        [Display(Name = "Product Name")]
        [Required(ErrorMessage = "{0} cannot be empty")]
        [StringLength(50, ErrorMessage = "{0} cannot be more than {1} characters")]
        public string ProductName { get; set; }

        [Display(Name = "Quantity")]
        [Required(ErrorMessage = "{0} cannot be empty")]
        [MinLength(2, ErrorMessage = "{0} cannot be less than {1} no. of quantities.")]
        public int ProductQuantity { get; set; }
        
        [Display(Name = "Price")]
        [Required(ErrorMessage = "{0} cannot be empty")]
        [MinLength(2, ErrorMessage = "{0} cannot be less than {1} no. of quantities.")]
        public int Price { get; set; }


    }
}
