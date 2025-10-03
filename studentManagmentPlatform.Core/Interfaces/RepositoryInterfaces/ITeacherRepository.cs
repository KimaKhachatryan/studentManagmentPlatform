using studentManagmentPlatform.Core.Entities;

namespace studentManagmentPlatform.Core.Interfaces.RepositoryInterfaces;

public interface ITeacherRepository : IRepository<Teacher>
{
    Task<Teacher?> GetByEmailAsync(string email);
    Task<IEnumerable<Teacher>> GetBySubjectAsync(SubjectEnum subject);
}
