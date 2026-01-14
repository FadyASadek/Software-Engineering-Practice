
using System.ComponentModel.DataAnnotations;

namespace SchoolProject.Data;

public class Student
{
    public Guid id { get; set; }
    [Required]
    public string Name { get; set; } = string.Empty;
    [Required]
    public string Phone { get; set; } = string.Empty;
    [Required]
    public string Address { get; set; } = string.Empty;
    public Guid DepartmentId { get; set; }
    public Department? Department { get; set; }
    public ICollection<StudentSubject> studentSubjects { get; set; } = new HashSet<StudentSubject>();
}
