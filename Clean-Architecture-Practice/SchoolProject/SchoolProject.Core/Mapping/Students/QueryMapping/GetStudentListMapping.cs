using SchoolProject.Core.Features.student.Queries.Results;
using SchoolProject.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Core.Mapping.Students
{
    public partial class StudentProfile
    {
       public void GetStudentListMapping()
        {
            CreateMap<Student, GetStudentListDto>()
               .ForMember(d => d.DepartmentName, opt => opt.MapFrom(d => d.Department!.Name));
        }
    }
}
