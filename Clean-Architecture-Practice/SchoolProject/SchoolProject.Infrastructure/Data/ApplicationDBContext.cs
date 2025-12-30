using Microsoft.EntityFrameworkCore;
using SchoolProject.Data;

namespace SchoolProject.Infrastructure;

public class ApplicationDBContext :DbContext
{
    public ApplicationDBContext()
    {
        
    }
    public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) 
    {
        
    }
    public DbSet<Student> students { get; set; }
}
