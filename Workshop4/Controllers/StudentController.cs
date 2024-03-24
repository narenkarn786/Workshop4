using Microsoft.AspNetCore.Mvc;
using Workshop4.Service;

namespace Workshop4.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpPost, Route("AddStudent")]
        public async Task<IActionResult> AddStudent(Student student)
        {
            var addStudent=await _studentService.AddStudent(student);
            return Ok(addStudent);
        }

        [HttpGet,Route("GetAllStudents")]
        public async Task<IActionResult> GetAllStudents()
        {
            return Ok(await _studentService.GetAllStudent());
        }

        [HttpGet,Route("GetStudentById")]
        public async Task<IActionResult> GetStudentById(string id)
        {
            var result=await _studentService.GetStudentById(id);
            return Ok(result);
        }
    }
}
