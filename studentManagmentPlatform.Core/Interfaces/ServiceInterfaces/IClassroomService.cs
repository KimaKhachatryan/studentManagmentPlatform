using studentManagmentPlatform.Core.Entities;

namespace studentManagmentPlatform.Core.Interfaces.ServiceInterfaces;

public interface IClassroomService
{
    Task<Classroom> GetById(int id);
    Task<IEnumerable<Classroom>> GetAll();
    Task<Classroom> CreateClassroom(Classroom classroom);
    Task UpdateClassroom(Classroom classroom);
    Task DeleteClassroom(int id);

    Task<IEnumerable<Student>> GetStudents(int classroomId);
    Task<IEnumerable<Teacher>> GetTeachers(int classroomId);
}
