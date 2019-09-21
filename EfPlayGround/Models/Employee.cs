using System;
using System.Collections.Generic;

namespace EfPlayGround.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Role { get; set; }
        public Company Company { get; set; }
    }

}
