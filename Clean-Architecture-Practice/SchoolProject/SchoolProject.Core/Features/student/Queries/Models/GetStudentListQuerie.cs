using MediatR;
using SchoolProject.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Core.Features.student.Queries.Models
{
    public class GetStudentListQuerie : IRequest<List<Student>> 
    {
    }
}
