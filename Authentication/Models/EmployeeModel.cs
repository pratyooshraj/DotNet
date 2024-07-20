using System.ComponentModel.DataAnnotations;

namespace Authentication.Models
{
    public class EmployeeModel
    {
        [Key]
        [Required]
        public int EmpId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public DateOnly DOB { get; set; }
    }
}
