using System.ComponentModel.DataAnnotations;

namespace studentManagmentPlatform.Core.Entities;
public class Classroom
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    public string Name { get; set; } = string.Empty;

    public ICollection<Student> Students { get; set; } 
    public ICollection<Teacher> Teachers { get; set; }
}