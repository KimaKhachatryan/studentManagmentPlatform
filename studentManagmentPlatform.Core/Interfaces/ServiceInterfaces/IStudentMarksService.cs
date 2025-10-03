using studentManagmentPlatform.Core.Entities;

namespace studentManagmentPlatform.Core.Interfaces.ServiceInterfaces;

public interface IStudentMarksService
{
    Task<StudentMarksDetails> GetByIdAsync(int id);
    Task<IEnumerable<StudentMarksDetails>> GetAllAsync();
    Task<StudentMarksDetails> AddMarkAsync(StudentMarksDetails details);
    Task UpdateMarkAsync(StudentMarksDetails details);
    Task DeleteMarkAsync(int id);

    Task<IEnumerable<StudentMarksDetails>> GetMarksByStudentAsync(int studentId);
    Task<double> GetAverageBySubjectAsync(int studentId, SubjectEnum subject);
}
