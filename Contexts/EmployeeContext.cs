using appbasic1.Models;
using Microsoft.EntityFrameworkCore;

namespace appbasic1.Contexts
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options)
            :base(options) { }
        public EmployeeContext(){ }
        public DbSet<Employee> Employee { get; set; }
    }
}