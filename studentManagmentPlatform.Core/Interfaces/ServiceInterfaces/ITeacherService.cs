using studentManagmentPlatform.Core.Entities;

namespace studentManagmentPlatform.Core.Interfaces.ServiceInterfaces;

public interface ITeacherService
{
    Task<Teacher> GetByIdAsync(int id);
    Task<IEnumerable<Teacher>> GetAllAsync();
    Task<Teacher> RegisterTeacherAsync(Teacher teacher);
    Task UpdateTeacherAsync(Teacher teacher);
    Task DeleteTeacherAsync(int id);

    Task<IEnumerable<Teacher>> GetBySubjectAsync(SubjectEnum subject);
}
