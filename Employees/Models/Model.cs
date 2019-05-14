using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Employees.Models
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options)
            : base(options)
        { }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
    }

    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Department { get; set; }      
        public string FirstName { get; set; }
        public string LastName { get; set; }        

        public ICollection<Department> Departments { get; set; } = new List<Department>();

    }

    public class Department
    {
        public int DepartmentId { get; set; }
        public string DeptName { get; set; }
        public Employee Employee { get; set; }
    }
}
