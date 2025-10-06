using studentManagmentPlatform.Core.Entities;
using studentManagmentPlatform.Core.Interfaces.RepositoryInterfaces;
using studentManagmentPlatform.Core.Interfaces.ServiceInterfaces;

namespace studentManagmentPlatform.Service
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepo;

        public StudentService(IStudentRepository studentRepo)
        {
            _studentRepo = studentRepo;
        }

        public Task<Student> DeleteStudent(int studentId)
        {
            var student = GetById(studentId);
            _studentRepo.Delete(studentId);
            return student;
        }

        public Task<Student> GetById(int id)
        {
            var student = _studentRepo.GetById(id);
            return student;
        }
        public Task<Student> RegisterStudent(Student student)
        {
            if (student == null)
            {
                throw new ArgumentNullException(nameof(student));
            }
            _studentRepo.Add(student);
            return Task.FromResult(student);
        }

        public Task UpdateStudent(Student student)
        {
            if (student == null)
            {
                throw new ArgumentNullException(nameof(student));
            }
            _studentRepo.Update(student);
            return Task.FromResult(student);
        }

        Task IStudentService.DeleteStudent(int id)
        {
            var student = GetById(id);
            if (student == null)
            {
                throw new ArgumentNullException(nameof(student));
            }
            _studentRepo.Delete(id);
            return Task.FromResult(student);
        }

        public Task<IEnumerable<Student>> GetByClassroom(int classroomId)
        {
            var classroom = GetByClassroom(classroomId);
            if (classroom == null)
            {
                throw new ArgumentNullException(nameof(classroom));
            }

            var students = _studentRepo.GetByClassroom(classroomId);
            return students;
        }
    }
}
