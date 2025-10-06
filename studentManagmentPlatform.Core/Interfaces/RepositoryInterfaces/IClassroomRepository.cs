using studentManagmentPlatform.Core.Entities;

namespace studentManagmentPlatform.Core.Interfaces.RepositoryInterfaces;

public interface IClassroomRepository : IRepository<Classroom>
{
    Task<Classroom?> GetByName(string name);
    Task<IEnumerable<Student>> GetStudentsInClassroom(int classroomId);
    Task<IEnumerable<Teacher>> GetTeachersInClassroom(int classroomId);
}
