using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NZWalksAPI.Controllers
{

    //http://localhost:5072/api/students
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        // GET: api/Students
        [HttpGet]
        public IActionResult GetAllStudents()
        {
            string[]  studentNames = new string[]
            {
                "John Doe",
                "Jane Smith",
                "Alice Johnson",
                "Bob Brown"
            };
            return Ok(studentNames);
        }

    }
}
