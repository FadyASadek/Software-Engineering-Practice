using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Data;

public class DepartmentSubject
{
    public Guid Id { get; set; }
    public Guid DepartmentId { get; set; }
    public Department? Department { get; set; }
    public Guid SubjectId { get; set; }
    public Subject? Subject { get; set; }
}
