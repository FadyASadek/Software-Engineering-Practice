using Microsoft.EntityFrameworkCore;
using SchoolProject.Data;
using SchoolProject.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Service;

public class StudentService:IStudentService
{
    private readonly IStudentRepository _studentRepository;

    public StudentService(IStudentRepository studentRepository)
    {
        _studentRepository = studentRepository;
    }
    public async Task<List<Student>> GetAllStudentAsync()
    {
        return await _studentRepository.GetStudentListAsync();
    }

    public async Task<Student?> GetStudentDyIdAsync(Guid id)
    {
        return await _studentRepository.GetTableNoTracking()
            .Include(d=>d.Department)
            .Where(s=>s.id==id).FirstOrDefaultAsync();
    }
}
