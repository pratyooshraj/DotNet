namespace WebAppLab3.Models
{
    public class EmployeeModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        //For Q3
        public int? DepId { get; set; }
    }
}
