using Microsoft.EntityFrameworkCore;

namespace EmployeeAPI.Context
{
    public class EmpContext : DbContext
    {
        public EmpContext(DbContextOptions<EmpContext> options) : base(options)
        {

        }

        public DbSet<EmpModel> EmployeeList { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmpModel>().ToTable("EmployeeList");
            // Additional configuration if needed
        }
    }
}
