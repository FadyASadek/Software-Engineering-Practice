using AutoMapper;
using SchoolProject.Core.Features.student.Queries.Results;
using SchoolProject.Data;


namespace SchoolProject.Core.Mapping.Students
{
    public partial class StudentProfile : Profile
    {
        public StudentProfile()
        {
            GetStudentListMapping();
            GetStudentByIdMapping();
        }
    }
}
