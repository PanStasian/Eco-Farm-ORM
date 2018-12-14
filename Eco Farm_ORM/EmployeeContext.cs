using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eco_Farm_ORM
{
    class EmployeeContext : DbContext
    {
        public EmployeeContext() : base("DbConn")
        {
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<EmployeeContext, Configuration>());
        }

        public DbSet<Employee> Employ { get; set; }
        public DbSet<Languages> Langs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
