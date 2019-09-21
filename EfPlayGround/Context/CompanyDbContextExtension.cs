using System;
using System.Collections.Generic;
using System.Linq;
using EfPlayGround.Models;

namespace EfPlayGround.Context
{
    public static class CompanyDbContextExtension
    {
        public static void CreateSeedData
               (this CompanyDbContext context)
        {
            if (context.Companies.Any())
                return;
            var companies = new List<Company>()
               {
                    new Company()
                    {
                         CompanyName = "Avengers: Infinity War",
                         Employees = new List<Employee>()
                         {
                             new Employee(){FullName = "Hong Le", Role = "Queen"},
                             new Employee(){FullName = "Hong Lien", Role = "King"}
                         }
                    },
                    new Company()
                    {
                         CompanyName = "Thor: Ragnarock",
                         Employees =new List<Employee>()
                         {
                             new Employee(){FullName = "Thor", Role = "God Of Thunder"},
                             new Employee(){FullName = "Loki", Role = "Thor's Brother"}
                         }
                    },
                    new Company()
                    {
                         CompanyName = "Black Panther",
                         Employees = new List<Employee>()
                         {
                             new Employee(){FullName = "Panther", Role = "King"},
                             new Employee(){FullName = "Wanada", Role = "Quote"}
                         }
                    }
               };
            context.AddRange(companies);
            context.SaveChanges();
        }
    }
}
