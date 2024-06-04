using DatabaseTask.Core.Domain;
using Microsoft.EntityFrameworkCore;

namespace DatabaseTask.Data
{
    public class DatabaseTaskDbContext : DbContext
    {
        public DatabaseTaskDbContext(DbContextOptions<DatabaseTaskDbContext> options)
            : base(options) { }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Child> Children { get; set; }
        public DbSet<VacationSchedule> VacationSchedules { get; set; }
        public DbSet<SickLeave> SickLeaves { get; set; }
        public DbSet<HealthChecklist> HealthChecklists { get; set; }
        public DbSet<AccessLevel> AccessLevels { get; set; }
        public DbSet<LoanableItem> LoanableItems { get; set; }
        public DbSet<EmployeeLoan> EmployeeLoans { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Request> Requests { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<AccessLevel>(entity =>
            {
                entity.HasKey(e => e.Access_Level_ID);
            });

            modelBuilder.Entity<Company>(entity =>
            {
                entity.HasKey(e => e.Company_ID);
            });

        }
    }
}
