using studentManagmentPlatform.Core.Entities;

namespace studentManagmentPlatform.Core.Interfaces.ServiceInterfaces;

public interface IStudentService
{
    Task<Student> GetById(int id);
    Task<Student> RegisterStudent(Student student);
    Task UpdateStudent(Student student);
    Task DeleteStudent(int id);

    Task<IEnumerable<Student>> GetByClassroom(int classroomId);
}
