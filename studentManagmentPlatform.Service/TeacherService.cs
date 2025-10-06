using studentManagmentPlatform.Core;
using studentManagmentPlatform.Core.Entities;
using studentManagmentPlatform.Core.Interfaces.RepositoryInterfaces;
using studentManagmentPlatform.Core.Interfaces.ServiceInterfaces;

namespace studentManagmentPlatform.Service
{
    public class TeacherService : ITeacherService
    {
        private readonly ITeacherRepository _teacherRepository;

        public TeacherService(ITeacherRepository teacherRepository)
        {
            _teacherRepository = teacherRepository;
        }

        public Task DeleteTeacher(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Teacher>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Teacher> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Teacher>> GetBySubject(SubjectEnum subject)
        {
            throw new NotImplementedException();
        }

        public Task<Teacher> RegisterTeacher(Teacher teacher)
        {
            throw new NotImplementedException();
        }

        public Task UpdateTeacher(Teacher teacher)
        {
            throw new NotImplementedException();
        }
    }
}
