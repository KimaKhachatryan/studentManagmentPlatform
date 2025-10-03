using System.ComponentModel.DataAnnotations;

namespace studentManagmentPlatform.Core.Entities;

public class Student
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
    
    public int ClassroomId { get; set; }
    public virtual Classroom Classroom { get; set; }

    public ICollection<Teacher> Teachers { get; set; } 
}
