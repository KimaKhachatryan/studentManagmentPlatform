using studentManagmentPlatform.Core.Entities;

namespace studentManagmentPlatform.Core.Interfaces.RepositoryInterfaces;

public interface IStudentMarksRepository : IRepository<StudentMarksDetails>
{
    Task<IEnumerable<StudentMarksDetails>> GetMarksByStudentAsync(int studentId);
    Task<double> GetAverageBySubjectAsync(int studentId, SubjectEnum subject);
}
