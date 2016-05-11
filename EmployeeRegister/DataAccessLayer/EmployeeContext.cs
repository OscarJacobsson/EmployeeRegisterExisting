using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace EmployeeRegister.DataAccessLayer
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext() : base("DefaultConnection") { }

        public DbSet<Models.Employee> Employees { get; set; }
    }
}