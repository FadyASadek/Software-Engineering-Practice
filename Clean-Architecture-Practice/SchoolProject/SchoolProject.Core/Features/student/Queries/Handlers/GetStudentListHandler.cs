using AutoMapper;
using MediatR;
using SchoolProject.Core.Bases;
using SchoolProject.Core.Features.student.Queries.Models;
using SchoolProject.Core.Features.student.Queries.Results;
using SchoolProject.Data;
using SchoolProject.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Core.Features.student.Queries.Handlers
{
    public class GetStudentListHandler : ResponseHandler, 
        IRequestHandler<GetStudentListQuery,Response<List<GetStudentDto>>>,
        IRequestHandler<GetStudentByIdQuery,Response<GetStudentDto>>
    {
        private readonly IStudentService _studentService;
        private readonly IMapper _mapper;

        public GetStudentListHandler(IStudentService studentService , IMapper mapper)
        {
            _studentService = studentService;
            _mapper = mapper;
        }

        public async Task<Response<List<GetStudentDto>>> Handle(GetStudentListQuery request, CancellationToken cancellationToken)
        {
            var StudentList = await _studentService.GetAllStudentAsync();
            var StudentListMapper = _mapper.Map<List<GetStudentDto>>(StudentList);
            return Success(StudentListMapper,"All Student");
        }

        public async Task<Response<GetStudentDto>> Handle(GetStudentByIdQuery request, CancellationToken cancellationToken)
        {
            var student = await _studentService.GetStudentDyIdAsync(request.Id);
            if (student == null)
            {
                return NotFound<GetStudentDto>();
            }
            var studentMapper = _mapper.Map<GetStudentDto>(student);
            return Success(studentMapper);
        }
    }
}
