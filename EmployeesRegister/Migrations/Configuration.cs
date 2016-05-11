namespace EmployeesRegister.Migrations
{
    using Models; //Har lagt till Models
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EmployeesRegister.DataAccessLayer.EmployeesContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EmployeesRegister.DataAccessLayer.EmployeesContext context)
        {
            //  This method will be called after migrating to the latest version.
            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );         

            //            public static void AddOrUpdate<TEntity>(
            //              this IDbSet<TEntity> set,
            //              params TEntity[] entities)              
            //              where TEntity : class
            
            context.Employees.AddOrUpdate(
              p => p.FirstName,     //Id genereras automatisk//Nedan är Entiteter //Filter, seednyckel, predikat
              new Employee {FirstName = "Ceasar", LastName = "Peters", Salary = 1200, Position = "R&D, Controller", Department = "Sport", Company = "Intel" },
              new Employee {FirstName = "Andrew", LastName = "Johnson", Salary = 60000, Position = "Chief Executive Officer", Department = "Top Department" },
              new Employee {FirstName = "Bruce", LastName = "Lennartsson" , Salary = 9000, Position = "HR and Chief Financial Officer", Department = "Financial Dep" }, 
              new Employee {FirstName = "Roman", LastName = "Johnson", Salary = 60000, Position = "Chief Executive Officer", Department = "Top Department" }
                );      
        }
    }
}
