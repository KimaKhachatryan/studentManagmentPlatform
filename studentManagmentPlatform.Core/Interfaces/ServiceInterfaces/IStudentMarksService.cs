using studentManagmentPlatform.Core.Entities;

namespace studentManagmentPlatform.Core.Interfaces.ServiceInterfaces;

public interface IStudentMarksService
{
    Task<StudentMarksDetails> GetById(int id);
    Task<IEnumerable<StudentMarksDetails>> GetAll();
    Task<StudentMarksDetails> AddMark(StudentMarksDetails details);
    Task UpdateMark(StudentMarksDetails details);
    Task DeleteMark(int id);

    Task<IEnumerable<StudentMarksDetails>> GetMarksByStudent(int studentId);
    Task<double> GetAverageBySubject(int studentId, SubjectEnum subject);
}
