using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace studentManagmentPlatform.Core.Entities;

public class StudentMarksDetails
{
    [Key]
    public int Id { get; set; }

    [ForeignKey("Student")]
    public int StudentId { get; set; }

    [Required]
    public SubjectEnum Subject { get; set; }

    [Range(0, 100)]
    public int AvgMark { get; set; }

    public int MarksCount { get; set; }

    public int MarksSum { get; set; }

    public virtual Student Student { get; set; }
}
