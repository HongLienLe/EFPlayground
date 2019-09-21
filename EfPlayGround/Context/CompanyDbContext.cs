using System;
using EfPlayGround.Models;
using Microsoft.EntityFrameworkCore;

namespace EfPlayGround.Context
{
    public class CompanyDbContext : DbContext
    {
        public DbSet<Company> Companies { get; set; }
         
        public CompanyDbContext(DbContextOptions<CompanyDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

    }
}
