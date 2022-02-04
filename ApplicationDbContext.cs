using Kadry.Models.Configurations;
using Kadry.Models.Domains;
using Kadry.Models.Wrappers;
using System;
using System.Data.Entity;
using System.Linq;

namespace Kadry
{
    public class ApplicationDbContext : DbContext
    {
        // Your context has been configured to use a 'ApplicationDbContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Kadry.ApplicationDbContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'ApplicationDbContext' 
        // connection string in the application configuration file.
        public ApplicationDbContext()
            : base("name=ApplicationDbContext")
        {
                     
            
        }

        public DbSet<Employee> Employees { get; set; }

        public DbSet <Status > Statuses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new EmployeeConfiguration());
            modelBuilder.Properties<DateTime>().Configure(c => c.HasColumnType("datetime2"));
            modelBuilder.Configurations.Add(new StatusConfiguration());
        }


        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}