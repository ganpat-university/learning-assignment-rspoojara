using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Models
{
    [Table("Subjects")]
    public class Subject
    {
        [Display(Name = "Subject ID")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public short SubjectId { get; set; }


        [Display(Name = "Name of the Subject")]
        [Required]
        public string SubjectName { get; set; }


        #region Navigation Properties to the Department Model


        [Display(Name ="Department Name")]
        [Required]
        [ForeignKey(nameof(Subject.Department))] //foreign key to object in the current model
        public int DepartmentId { get; set; } //Department id of the Subject


        [Display(Name ="Department Name")]
        public Department Department { get; set; }

        #endregion

    }
}
