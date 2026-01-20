using MediatR;
using SchoolProject.Core.Bases;
using SchoolProject.Core.Features.student.Queries.Results;


namespace SchoolProject.Core.Features.student.Queries.Models
{
    public class GetStudentByIdQuery : IRequest<Response<GetStudentDto>>
    {
        public Guid Id { get; set; }
        public GetStudentByIdQuery(Guid id)
        {
            Id= id;
        }
    }
}
