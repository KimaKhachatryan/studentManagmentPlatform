using Microsoft.AspNetCore.Mvc;
using studentManagmentPlatform.Core.Entities;
using studentManagmentPlatform.Core.Interfaces.ServiceInterfaces;

namespace studentManagmentPlatform.Controller
{
    [Route("api/[controller]")]
    [ApiController]

    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet("student")]
        public ActionResult<Student> Get(int id)
        {
            var student = _studentService.GetById(id);
            return Ok(student);
        }

        [HttpGet("students")]
        public ActionResult<List<Student>> GetStudentsByClassroom(int classrommId)
        {
            var students = _studentService.GetByClassroom(classrommId);
            if (students == null)
            {
                return BadRequest("Students list is empty.");
            }
            return Ok(students);

        }


        [HttpPost("student")]
        public ActionResult Add(Student student)
        {
            if (student == null)
            {
                return BadRequest("Student data is null.");
            }
            _studentService.RegisterStudent(student);
            return Ok();
        }

        [HttpPut("student")]
        public ActionResult Update(int id, Student student)
        {
            var findedStudent = _studentService.GetById(id);
            if (findedStudent == null)
            {
                return BadRequest("Student data is null.");
            }
            else if (findedStudent.Equals(student))
            {
                return Ok();
            }
            _studentService.UpdateStudent(student);
            return Ok();
        }

        [HttpDelete("student")]
        public ActionResult Delete(int id)
        {
            var student = _studentService.GetById(id);
            if (student == null)
            {
                return BadRequest("Student data is null.");
            }
            _studentService.DeleteStudent(id);
            return Ok("Deleted" + student);
        }
    }
}
