namespace selfreferingtablemvc.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? ManagerId { get; set; }
        public Employee ?Manager { get; set; }
        public ICollection<Employee> Subordinates { get; set; }
    }
}
