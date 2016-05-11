namespace EmployeeRegister.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Models;

    internal sealed class Configuration : DbMigrationsConfiguration<EmployeeRegister.DataAccessLayer.EmployeeContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EmployeeRegister.DataAccessLayer.EmployeeContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            context.Employees.AddOrUpdate(
              p => p.Name,
              new Employee { Name = "Oscar Jakobsson", Salary = 100 },
              new Employee { Name = "Peter Jakobsson", Salary = 20 },
              new Employee { Name = "Oscar Svensson", Salary = 300 }           
            );

        }
    }
}
