using Microsoft.EntityFrameworkCore;

namespace DemoApp.Employee;
public class EmployeeDbContext : DbContext
{
    public DbSet<Emp> Employees { get; set; }
    public DbSet<Dept> Depts { get; set; }
    

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=iitdac.met.edu;Database=Shop4;User Id=dac4;Password=Dac4@1234;Trust Server Certificate=true");
    }
}

