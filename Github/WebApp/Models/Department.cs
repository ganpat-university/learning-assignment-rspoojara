using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Models
{
    [Table("Departments")]
    public class Department
    {
        [Display(Name = "Department ID")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DepartmentId { get; set; }

        [Display(Name ="Department Name")]
        [Required(ErrorMessage ="{0} cannot be empty")]
        [StringLength(50, ErrorMessage ="{0} cannot be more than {1} characters")]
        [MinLength(3, ErrorMessage ="{0} should have atleast {1} characters")]
        public string DepartmentName { get; set; }

        #region nAvigation properties to the Subejct model
        public ICollection<Subject> Subjects { get; set; }

        #endregion
    }
}
