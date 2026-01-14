using MediatR;
using SchoolProject.Core.Features.student.Queries.Models;
using SchoolProject.Data;
using SchoolProject.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Core.Features.student.Queries.Handlers
{
    public class StudentHandler : IRequestHandler<GetStudentListQuerie,List<Student>>
    {
        private readonly IStudentService _studentService;

        public StudentHandler(IStudentService studentService)
        {
            _studentService = studentService;
        }

        public async Task<List<Student>> Handle(GetStudentListQuerie request, CancellationToken cancellationToken)
        {
            return await _studentService.GetAllStudentAsync();
        }
    }
}
