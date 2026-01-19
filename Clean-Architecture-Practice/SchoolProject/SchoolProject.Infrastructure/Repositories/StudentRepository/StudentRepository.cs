using Microsoft.EntityFrameworkCore;
using SchoolProject.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Infrastructure;

public class StudentRepository : IStudentRepository
{
    private readonly ApplicationDBContext _context;

    public StudentRepository(ApplicationDBContext context)
    {
        _context = context;
    }
    public async Task<List<Student>> GetStudentListAsync()
    {
        return await _context.Students.Include(d=>d.Department).ToListAsync();
    }
}
