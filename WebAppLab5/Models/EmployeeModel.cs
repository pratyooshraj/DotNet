using System.ComponentModel.DataAnnotations;

namespace WebAppLab5.Models
{
    public class EmployeeModel
    {
        [Required(ErrorMessage = "EmpId Required")]
        public int EmpId { get; set; }


        [Required(ErrorMessage = "Name Required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "The Name must be between 3 and 50 characters long!")]
        public string Name { get; set; }


        [Required(ErrorMessage = "Email Required")]
        [EmailAddress(ErrorMessage = "Enter valid email address")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Gender Required")]
        public string Gender { get; set; }

        public int? DepId { get; set; }

    }
}

