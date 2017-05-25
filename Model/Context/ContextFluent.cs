
using Model.Entities;
using System.Data.Entity;
using System.Reflection;

namespace Model.Context
{
    public class ContextFluent : DbContext
    {
        public ContextFluent() : base("name=OffresEmploi")
        {

        }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Offer> Offers { get; set; }

        public DbSet<Postulation> Postulations { get; set; }

        public DbSet<Status> Status { get; set; }

        public DbSet<Formation> Formations { get; set; }

        public DbSet<Experience> Experiences { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.HasDefaultSchema("dbo");
            modelBuilder.Configurations.AddFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
