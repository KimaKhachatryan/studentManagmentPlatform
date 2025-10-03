using studentManagmentPlatform.Core.Entities;

namespace studentManagmentPlatform.Core.Interfaces.RepositoryInterfaces;

public interface IStudentMarksRepository : IRepository<StudentMarksDetails>
{
    Task<IEnumerable<StudentMarksDetails>> GetMarksByStudent(int studentId);
    Task<double> GetAverageBySubject(int studentId, SubjectEnum subject);
}
