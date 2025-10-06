using studentManagmentPlatform.Core.Entities;

namespace studentManagmentPlatform.Core.Interfaces.RepositoryInterfaces;

public interface ITeacherRepository : IRepository<Teacher>
{
    Task<Teacher?> GetByEmail(string email);
    Task<IEnumerable<Teacher>> GetBySubject(SubjectEnum subject);
}
