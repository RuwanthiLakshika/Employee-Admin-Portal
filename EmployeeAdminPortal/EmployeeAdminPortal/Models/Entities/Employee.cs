namespace EmployeeAdminPortal.Models.Entities
{
    public class Employee
    {
        //Guid - Globally Unique Identifier
        public Guid Id { get; set; }
        public  required string Name { get; set; }
        public required string Email { get; set; }
        //Declaring Phone as nullable
        public string? Phone { get; set; }
        public decimal Salary { get; set; }

    }
}
