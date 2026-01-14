using SchoolProject.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Service;

public interface IStudentService
{
    Task<List<Student>> GetAllStudentAsync();
}
