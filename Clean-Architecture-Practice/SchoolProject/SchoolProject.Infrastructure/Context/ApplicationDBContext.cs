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
    public DbSet<Student> Students { get; set; } 
    public DbSet<Department> Departments { get; set; }
    public DbSet<Subject> Subjects { get; set; }
    public DbSet<DepartmentSubject> departmentSubjects { get; set; }
    public DbSet<StudentSubject> StudentSubjects { get; set; }
}
