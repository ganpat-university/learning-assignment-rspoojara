using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class StudentsController : Controller
    {
        public IActionResult Index()
        {
            return Ok("Hello World from ASP.NET");
        }
    }
}
