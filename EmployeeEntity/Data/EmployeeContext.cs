using EmployeeEntity.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeEntity.Data
{

    public class EmployeeContext:DbContext
    {
        public DbSet<Employee> tblEmployee { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=ABURRA01;Database=Employee;Trusted_Connection=True;MultipleActiveResultSets=True;");
            base.OnConfiguring(optionsBuilder);
        }

        
    }
}
