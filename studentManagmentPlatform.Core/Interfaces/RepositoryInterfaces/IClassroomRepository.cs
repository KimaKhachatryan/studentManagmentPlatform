using studentManagmentPlatform.Core.Entities;

namespace studentManagmentPlatform.Core.Interfaces.RepositoryInterfaces;

public interface IClassroomRepository : IRepository<Classroom>
{
    Task<Classroom?> GetByNameAsync(string name);
    Task<IEnumerable<Student>> GetStudentsInClassroomAsync(int classroomId);
    Task<IEnumerable<Teacher>> GetTeachersInClassroomAsync(int classroomId);
}
