using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SchoolProject.Data;

public class Department
{
    public Guid id { get; set; }
    [Required]
    public string Name { get; set; } = string.Empty;
    public ICollection<Student> Students { get; set; } = new HashSet<Student>();
    public ICollection<DepartmentSubject> DepartmentSubjects { get; set; } = new HashSet<DepartmentSubject>();
    
}
