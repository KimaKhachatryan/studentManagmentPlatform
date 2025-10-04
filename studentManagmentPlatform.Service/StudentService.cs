namespace studentManagmentPlatform.Service
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepo;
        private readonly IGradeRepository _gradeRepo;
        private readonly ICourseRepository _courseRepo;

        public StudentService(IStudentRepository studentRepo, IGradeRepository gradeRepo, ICourseRepository courseRepo)
        {
            _studentRepo = studentRepo;
            _gradeRepo = gradeRepo;
            _courseRepo = courseRepo;
        }

        // Student Management
        public void AddStudent(StudentDto student)
        {
            _studentRepo.Add(student);
        }

        public void UpdateStudent(int studentId, StudentDto student)
        {
            student.Id = studentId;
            _studentRepo.Update(student);
        }

        public void DeleteStudent(int studentId)
        {
            _studentRepo.Delete(studentId);
        }

        public StudentDto GetStudentById(int studentId)
        {
            return _studentRepo.GetById(studentId);
        }

        public IEnumerable<StudentDto> GetAllStudents()
        {
            return _studentRepo.GetAll();
        }

        // Grade Management
        public void AssignGrade(int studentId, int courseId, GradeDto grade)
        {
            grade.StudentId = studentId;
            grade.CourseId = courseId;
            _gradeRepo.Add(grade);
        }

        public void UpdateGrade(int gradeId, GradeDto grade)
        {
            grade.Id = gradeId;
            _gradeRepo.Update(grade);
        }

        public void DeleteGrade(int gradeId)
        {
            _gradeRepo.Delete(gradeId);
        }

        public IEnumerable<GradeDto> GetGradesByStudentId(int studentId)
        {
            return _gradeRepo.GetByStudentId(studentId);
        }

        public double GetAverageGrade(int studentId)
        {
            var grades = _gradeRepo.GetByStudentId(studentId);
            return grades.Any() ? grades.Average(g => g.Value) : 0;
        }

        // Course Enrollment
        public void EnrollStudentInCourse(int studentId, int courseId)
        {
            _courseRepo.Enroll(studentId, courseId);
        }

        public void UnenrollStudentFromCourse(int studentId, int courseId)
        {
            _courseRepo.Unenroll(studentId, courseId);
        }

        public IEnumerable<CourseDto> GetCoursesByStudentId(int studentId)
        {
            return _courseRepo.GetByStudentId(studentId);
        }
    }

}
