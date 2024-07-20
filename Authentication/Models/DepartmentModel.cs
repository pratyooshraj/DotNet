using System.ComponentModel.DataAnnotations;

namespace Authentication.Models
{
    public class DepartmentModel
    {
        [Key]
        [Required]
        public int DeptId { get; set; }
        public string DepartmentName { get; set; }
        public string Description { get; set; }

    }
}
