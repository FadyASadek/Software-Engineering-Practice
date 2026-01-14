using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Data;

public class Subject
{
    public Guid Id { get; set; }
    [Required]
    public string Name { get; set; }=string.Empty;
    public ICollection<DepartmentSubject> DepartmentSubjects { get; set; } = new HashSet<DepartmentSubject>();
    public ICollection<StudentSubject> studentSubjects { get; set; } = new HashSet<StudentSubject>();
}
