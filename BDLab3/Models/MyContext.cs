using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BDLab3.Models
{
    public class MyContext : DbContext
    {
        public DbSet<Department> Departments { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Penaltie> Penalties { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Salarie> Salaries { get; set; }
        public DbSet<Specialty> Specialty { get; set; }
    }
}