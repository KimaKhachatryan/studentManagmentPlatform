using studentManagmentPlatform.Core.Entities;
using studentManagmentPlatform.Core.Interfaces.RepositoryInterfaces;

namespace studentManagmentPlatform.DAL
{
    public class StudentRepository : IStudentRepository
    {
        private readonly StudentDbContext _context;

        public StudentRepository(StudentDbContext context)
        {
            _context = context;
        }

        public Task<Student?> GetById(int id)
        {
            var student = _context.Students.Find(id);
            return Task.FromResult(student);
        }

        public Task<IEnumerable<Student>> GetAll()
        {
            var students = _context.Students.ToList();
            return Task.FromResult<IEnumerable<Student>>(students);
        }

        public Task Add(Student entity)
        {
            _context.Students.Add(entity);
            _context.SaveChanges();
            return Task.CompletedTask;
        }

        public Task Update(Student entity)
        {
            _context.Students.Update(entity);
            _context.SaveChanges();
            return Task.CompletedTask;
        }

        public Task Delete(int id)
        {
            var student = _context.Students.Find(id);
            if (student != null)
            {
                _context.Students.Remove(student);
                _context.SaveChanges();
            }
            return Task.CompletedTask;
        }

        public Task<Student?> GetByEmail(string email)
        {
            var student = _context.Students.FirstOrDefault(s => s.Email == email);
            return Task.FromResult(student);
        }

        public Task<IEnumerable<Student>> GetByClassroom(int classroomId)
        {
            var students = _context.Students
                .Where(s => s.ClassroomId == classroomId)
                .ToList();
            return Task.FromResult<IEnumerable<Student>>(students);
        }
    }

