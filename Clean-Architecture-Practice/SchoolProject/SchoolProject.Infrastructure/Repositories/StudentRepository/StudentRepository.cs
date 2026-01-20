using Microsoft.EntityFrameworkCore;
using SchoolProject.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Infrastructure;

public class StudentRepository : GenericRepositoryAsync<Student>, IStudentRepository 
{

    public StudentRepository(ApplicationDBContext context) : base(context)
    {
    }
    public async Task<List<Student>> GetStudentListAsync()
    {
        return await _dbContext.Students.Include(d=>d.Department).ToListAsync();
    }
}
