using System.ComponentModel.DataAnnotations;

namespace WebAppLab5.Models
{
    public class DepartmentModel
    {
        [Required(ErrorMessage = "Department ID is required")]
        public int DepId { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [MaxLength(100, ErrorMessage = "Description cannot exceed 100 characters")]
        public string Description { get; set; }
    }
}
