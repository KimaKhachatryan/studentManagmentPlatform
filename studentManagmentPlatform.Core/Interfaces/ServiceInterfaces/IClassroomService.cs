using studentManagmentPlatform.Core.Entities;

namespace studentManagmentPlatform.Core.Interfaces.ServiceInterfaces;

public interface IClassroomService
{
    Task<Classroom> GetByIdAsync(int id);
    Task<IEnumerable<Classroom>> GetAllAsync();
    Task<Classroom> CreateClassroomAsync(Classroom classroom);
    Task UpdateClassroomAsync(Classroom classroom);
    Task DeleteClassroomAsync(int id);

    Task<IEnumerable<Student>> GetStudentsAsync(int classroomId);
    Task<IEnumerable<Teacher>> GetTeachersAsync(int classroomId);
}
