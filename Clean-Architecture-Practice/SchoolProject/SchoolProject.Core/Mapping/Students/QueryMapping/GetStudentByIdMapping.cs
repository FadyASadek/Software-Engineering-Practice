using SchoolProject.Core.Features.student.Queries.Results;
using SchoolProject.Data;
using System;


namespace SchoolProject.Core.Mapping.Students
{
    public partial class StudentProfile
    {
        public void GetStudentByIdMapping()
        {
            CreateMap<Student, GetStudentDto>()
               .ForMember(d => d.DepartmentName, opt => opt.MapFrom(d => d.Department!.Name));
        }
    }
}
