namespace EntityFramework.Models
{
    public class EmployeeModel
    {
        public Guid Id { get; set; }   
        public int EmpId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime DOB { get; set; }
    }
}
