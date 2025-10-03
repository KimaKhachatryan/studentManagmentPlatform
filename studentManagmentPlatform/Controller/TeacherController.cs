using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using studentManagmentPlatform.Core;
using studentManagmentPlatform.Core.Interfaces.ServiceInterfaces;

namespace studentManagmentPlatform.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        private readonly ITeacherService _teacherService;

        public TeacherController(ITeacherService teacherService)
        {
            _teacherService = teacherService;
        }

        [HttpGet("teachers")]
        public ActionResult<List<Teacher>> GetAll()
        {
            var teachers = _teacherService.GetAll();

            return Ok(teachers);
        }
    }
}
