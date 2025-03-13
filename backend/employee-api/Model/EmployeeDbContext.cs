using Microsoft.EntityFrameworkCore;

namespace employee_api.Model
{
    public class EmployeeDbContext:DbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options) 
        { 
        }

        public DbSet<Employee> Employees { get; set; }

    }
}
