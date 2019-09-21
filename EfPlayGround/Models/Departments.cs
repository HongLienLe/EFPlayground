using System;
namespace EfPlayGround.Models
{
    public class Departments
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public Company Company { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public string Department { get; set; }
    }
}
