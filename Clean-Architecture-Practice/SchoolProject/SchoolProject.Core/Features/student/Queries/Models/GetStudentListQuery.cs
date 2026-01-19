using MediatR;
using SchoolProject.Core.Bases;
using SchoolProject.Core.Features.student.Queries.Results;
using SchoolProject.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Core.Features.student.Queries.Models
{
    public class GetStudentListQuery : IRequest<Response<List<GetStudentListDto>>> 
    {
    }
}
