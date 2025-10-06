using studentManagmentPlatform.Core.Entities;

namespace studentManagmentPlatform.Core.Interfaces.ServiceInterfaces;

public interface ITeacherService
{
    Task<Teacher> GetById(int id);
    Task<IEnumerable<Teacher>> GetAll();
    Task<Teacher> RegisterTeacher(Teacher teacher);
    Task UpdateTeacher(Teacher teacher);
    Task DeleteTeacher(int id);

    Task<IEnumerable<Teacher>> GetBySubject(SubjectEnum subject);
}
