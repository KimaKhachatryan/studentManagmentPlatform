using studentManagmentPlatform.Core.Entities;

namespace studentManagmentPlatform.Core.Interfaces.RepositoryInterfaces;

public interface IStudentRepository : IRepository<Student>
{
    Task<Student?> GetByEmail(string email);
    Task<IEnumerable<Student>> GetByClassroom(int classroomId);
}
