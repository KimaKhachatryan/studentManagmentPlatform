using studentManagmentPlatform.Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace studentManagmentPlatform.Core;

public class Teacher
{
    [Key]
    public int Id { get; set; }

    [Required, StringLength(50)]
    public string FirstName { get; set; } = string.Empty;

    [Required, StringLength(50)]
    public string LastName { get; set; } = string.Empty;

    [Required, EmailAddress]
    public string Email { get; set; } = string.Empty;

    [DataType(DataType.Date)]
    public DateTime? DateOfBirth { get; set; }

    [Required]
    public SubjectEnum Subject { get; set; } 

    public ICollection<Student> Students { get; set; } 
    public ICollection<Classroom> Classrooms { get; set; } 
}
